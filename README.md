# CreditMate

CreditMate é uma aplicação para simulação de processamento de liberação de crédito.

## Recursos Utilizados:

Se faz necessário realizar a instalação das aplicações/frameworks abaixo:

* Visual Studio

    - **[Visual Studio](https://visualstudio.microsoft.com/downloads/?WT.mc_id=javascript-0000-gllemos)**
    - **[.NET 8]([https://dotnet.microsoft.com/download?WT.mc_id=javascript-0000-gllemos](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0))**

## Rodando o projeto
Rode estes comandos do CLI no na pasta do projeto CreditMate.API:

```console
dotnet build
dotnet run
```

## Criando o container docker

```
docker run -v ~/docker --name creditMate -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=creditMate2929" -p 1433:1433 -d mcr.microsoft.com/mssql/server
```



## Rodando as migrations

A partir do projeto CreditMate.Persistence, rode o seguinte comando:

```console
dotnet ef database update --startup-project ..\CreditMate.API\
```
### 
