#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["services/catalog/RentCar.Catalog.Api/RentCar.Catalog.Api.csproj", "services/catalog/RentCar.Catalog.Api/"]
RUN dotnet restore "services/catalog/RentCar.Catalog.Api/RentCar.Catalog.Api.csproj"
COPY . .
WORKDIR "/src/services/catalog/RentCar.Catalog.Api"
RUN dotnet build "RentCar.Catalog.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RentCar.Catalog.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RentCar.Catalog.Api.dll"]
