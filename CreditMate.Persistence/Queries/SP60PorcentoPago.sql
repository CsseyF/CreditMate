WITH Parcela_cte_pago as (
	SELECT 
		FinanciamentoId,  
		COUNT(*) as quantidadePago
	FROM CreditMateDb.dbo.Parcela
	where FoiPago = 1
	GROUP BY FinanciamentoId	
)
SELECT DISTINCT c.Nome
FROM CreditMateDb.dbo.Cliente c
LEFT JOIN CreditMateDb.dbo.Financiamento f ON c.Cpf = f.Cpf
LEFT JOIN Parcela_cte_pago ON Parcela_cte_pago.FinanciamentoId = f.Id
WHERE c.UF = 'SP'
	  and (
	  	select 
		(COUNT(*) * 0.6) as QuantidadeDesejadaPaga 
		from CreditMateDb.dbo.Parcela as total
		where total.FinanciamentoId = F.Id 
		group by Financiamentoid
      ) < Parcela_cte_pago.quantidadePago
	
