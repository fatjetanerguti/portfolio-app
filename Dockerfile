FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["PortfolioApp.csproj", "."]
RUN dotnet restore "./PortfolioApp.csproj"
COPY . .
RUN dotnet build "./PortfolioApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./PortfolioApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN mkdir -p /app/data
RUN mkdir -p wwwroot/uploads/projects wwwroot/uploads/profile
ENTRYPOINT ["dotnet", "PortfolioApp.dll"]