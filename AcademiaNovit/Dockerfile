# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copiar solo el archivo .csproj
COPY AcademiaNovit/*.csproj ./AcademiaNovit/
WORKDIR /src/AcademiaNovit
RUN dotnet restore

# Copiar el resto del código
COPY AcademiaNovit/. ./
RUN dotnet publish -c Release -o /app/publish

# Etapa de runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Puerto expuesto
EXPOSE 8080

# Iniciar la API
ENTRYPOINT ["dotnet", "AcademiaNovit.dll"]