#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PayrollManagement.Api.csproj", "."]
COPY ["/PayrollManagement.Business/PayrollManagement.Business.csproj", "PayrollManagement.Business/"]
COPY ["/PayrollManagement.Infraestructure/PayrollManagement.Infraestructure.csproj", "PayrollManagement.Infraestructure/"]
RUN dotnet restore "./PayrollManagement.Api.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "PayrollManagement.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PayrollManagement.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PayrollManagement.Api.dll"]