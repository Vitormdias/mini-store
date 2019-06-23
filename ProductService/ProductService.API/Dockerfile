FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.2-sdk AS build

ENV ASPNETCORE_URLS=http://+:5000

WORKDIR /src
COPY ProductService.API/ProductService.API.csproj ProductService.API/
COPY ProductService.Domain/ProductService.Domain.csproj ProductService.Domain/
COPY ProductService.Infra/ProductService.Infra.csproj ProductService.Infra/
RUN dotnet restore ProductService.API/ProductService.API.csproj
COPY . .
WORKDIR /src/ProductService.API
RUN dotnet build ProductService.API.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ProductService.API.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ProductService.API.dll"]
