SELECT DISTINCT TOP 4 c.Nome 
FROM 		Cliente c 
INNER JOIN 	Financiamento f ON f.Cpf = c.Cpf 
INNER JOIN  Parcela p 		ON p.FinanciamentoId  = f.Id
WHERE p.DataPagamento IS NULL
      AND p.DataVencimento >= DATEADD(day, 5, getdate())