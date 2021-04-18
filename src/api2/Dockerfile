FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY /src/api2 .

RUN dotnet restore 1-Servico/Api2.Servico/Api2.Servico.csproj

#WORKDIR /src/3-Dominio/Api2.Dominio.Teste
#RUN dotnet test

WORKDIR /src/1-Servico/Api2.Servico
RUN dotnet build Api2.Servico.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Api2.Servico.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet","Api2.Servico.dll"]