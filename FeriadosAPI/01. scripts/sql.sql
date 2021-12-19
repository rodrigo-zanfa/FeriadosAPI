
/*
drop table [FuncionalPlant].[dbo].[API_FeriadoNacional]

drop table [FuncionalPlant].[dbo].[API_FeriadoEstadual]

drop table [FuncionalPlant].[dbo].[API_FeriadoMunicipal]
*/

select * from [FuncionalPlant].[dbo].[API_FeriadoNacional]

select * from [FuncionalPlant].[dbo].[API_FeriadoEstadual]

select * from [FuncionalPlant].[dbo].[API_FeriadoMunicipal]



select * from [FuncionalPlant].[dbo].[Estado] e
order by e.IdRegiao, e.SiglaEstado

select * from [FuncionalPlant].[dbo].[Cidade] c
order by c.IdEstado, c.NomeCidade
