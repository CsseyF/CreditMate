using CreditMate.Application.Dtos.CreditoDtos;
using CreditMate.Application.Dtos.CreditoDtos.Validators;
using CreditMate.Application.Dtos.FinanciamentoDtos;
using CreditMate.Application.Services.Interfaces;
using CreditMate.Core.Entities;
using CreditMate.Core.Enums;
using CreditMate.Core.Exceptions;

namespace CreditMate.Application.Services
{
    public class CreditoService : ICreditoService
    {
        private readonly IFinanciamentoService _financiamentoService;
        private readonly IClienteService _clienteService;
        private readonly IParcelaService _parcelaService;

        public CreditoService(
            IFinanciamentoService financiamentoService,
            IClienteService clienteService,
            IParcelaService parcelaService)
        {
            _financiamentoService = financiamentoService;
            _clienteService = clienteService;
            _parcelaService = parcelaService;

        }
        public async Task<CreditoResponseDto> ProcessamentoCredito(CreditoRequestDto request,
            CancellationToken cancellationToken)
        {

            var validator = new CreditRequestValidator();
            var result = validator.Validate(request);
            var valorTotal = GetValorTotalJuros(request.ValorSolicitado, request.TipoFinanciamento);

            if (!result.IsValid)
            {
                var message = result.Errors.Select(error => error.ErrorMessage + "| ");
                return new CreditoResponseDto()
                {
                    Approved = false,
                    Message = string.Concat(message),
                    ValorTotal = valorTotal,
                    ValorJuros = GetValorDoJuros(request.ValorSolicitado, request.TipoFinanciamento)
                };
            }

            var cliente = await _clienteService.FindOneAsync(request.ClienteId, cancellationToken);
            var parcelas = new List<Parcela>(); 

            if (cliente == null)
            {
                throw new EntityNotFoundException(nameof(Cliente));
            }
            var financiamento = new CreateFinanciamentoRequestDto()
            {
                Id = Guid.NewGuid(),     
                Cpf = cliente.Cpf,
                TipoFinanciamento = request.TipoFinanciamento,
                UltimoVencimento = DateTime.Now,
                ValorTotal = valorTotal,
            };

            for (var i = 0; i < request.QuantidadeParcelas; i++)
            {
                var newParcela = new Parcela()
                {
                    NumeroParcela = i + 1,
                    FinanciamentoId = financiamento.Id,
                    Valor = valorTotal / request.QuantidadeParcelas,
                    DataPagamento = DateTime.MinValue,
                    DataVencimento = request.PrimeiroVencimento.AddMonths(i),
                };

                parcelas.Add(newParcela);
            }

            financiamento.UltimoVencimento = parcelas.Last().DataVencimento.Value;

            await _financiamentoService.InsertAsync(financiamento, cancellationToken);
            await _parcelaService.InsertRangeAsync(parcelas, cancellationToken);

            return new CreditoResponseDto()
            {
                Approved = true,
                ValorTotal = valorTotal,
                ValorJuros = GetValorDoJuros(request.ValorSolicitado, request.TipoFinanciamento)
            };


        }

        private decimal GetValorTotalJuros(decimal valorCredito, TipoFinanciamentoEnum tipoFinanciamento)
        {
            return valorCredito * (1 + GetTaxaDeJuros(tipoFinanciamento));
        }
        private decimal GetValorDoJuros(decimal valorCredito,
            TipoFinanciamentoEnum tipoFinanciamento)
        {
            return valorCredito * GetTaxaDeJuros(tipoFinanciamento);
        }
        private decimal GetTaxaDeJuros(TipoFinanciamentoEnum tipoFinanciamento)
        {
            switch (tipoFinanciamento)
            {
                case TipoFinanciamentoEnum.Direto:
                    return 0.02m; // 2%
                case TipoFinanciamentoEnum.Consignado:
                    return 0.01m; // 1%
                case TipoFinanciamentoEnum.PJ:
                    return 0.05m; // 5%
                case TipoFinanciamentoEnum.PF:
                    return 0.03m; // 3%
                case TipoFinanciamentoEnum.Imobiliario:
                    return 0.09m; // 9%
                default:
                    return 0;
            }
        }

    }
}
