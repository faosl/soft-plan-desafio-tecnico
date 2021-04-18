FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY /src/api1 .
RUN dotnet restore 1-Servico/Ap1.Servico/Ap1.Servico.csproj

#WORKDIR /src/3-Dominio/Api1.Dominio.Teste
#RUN dotnet test

WORKDIR /src/1-Servico/Ap1.Servico
RUN dotnet build Ap1.Servico.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Ap1.Servico.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet","Ap1.Servico.dll"]