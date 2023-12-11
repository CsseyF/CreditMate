using CreditMate.Core.Consts;
using CreditMate.Core.Enums;
using FluentValidation;

namespace CreditMate.Application.Dtos.CreditoDtos.Validators
{
    public class CreditRequestValidator : AbstractValidator<CreditoRequestDto>
    {
        public CreditRequestValidator()
        {
            var now = DateTime.Now;
            
            RuleFor(request => request.QuantidadeParcelas)
                .GreaterThanOrEqualTo(CreditConsts.ParcelaMin)
                .WithMessage($"A Quantidade de parcelas não pode ser menor que {CreditConsts.ParcelaMin}x");
                
            RuleFor(request => request.QuantidadeParcelas)
                .LessThanOrEqualTo(CreditConsts.ParcelaMax)
                .WithMessage($"A Quantidade de parcelas não pode ultrapassar {CreditConsts.ParcelaMax}x");

            RuleFor(request => request.PrimeiroVencimento)
                .GreaterThanOrEqualTo(now.AddDays(CreditConsts.DiasPrimeiroVencimentoMin))
                .WithMessage($"A data do primeiro vencimento deve ser de no mínimo {CreditConsts.DiasPrimeiroVencimentoMin} dias");

            RuleFor(request => request.PrimeiroVencimento)
                .LessThanOrEqualTo(now.AddDays(CreditConsts.DiasPrimeiroVencimentoMax))
                .WithMessage($"A data do primeiro vencimento deve ser de no máximo {CreditConsts.DiasPrimeiroVencimentoMax} dias");

            RuleFor(request => request.ValorSolicitado)
                .GreaterThanOrEqualTo(CreditConsts.PfEmprestimoMin)
                .When(x => x.TipoFinanciamento == TipoFinanciamentoEnum.PJ)
                .WithMessage($"O valor mínimo a ser liberado para Pessoa Jurídica é de R$ {CreditConsts.PfEmprestimoMin},00");

            RuleFor(request => request.ValorSolicitado)
                .LessThanOrEqualTo(CreditConsts.EmprestimoMax)
                .WithMessage($"O valor máximo a ser liberado para qualquer tipo de empréstimo é de R$ {CreditConsts.EmprestimoMax},00");
        }
    }
}
