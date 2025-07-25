# Imagen base para build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copiar .csproj y restaurar dependencias
COPY AcademiaNovit.csproj ./AcademiaNovit.csproj
RUN dotnet restore

# Copiar el resto del código
COPY . ./
RUN dotnet publish -c Release -o /app/publish

# Imagen para producción
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 8080
ENTRYPOINT ["dotnet", "AcademiaNovit.dll"]