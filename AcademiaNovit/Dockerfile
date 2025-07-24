# Imagen base para build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copiar y restaurar dependencias
COPY *.csproj ./
RUN dotnet restore

# Copiar todo y compilar
COPY . ./
RUN dotnet publish -c Release -o out

# Imagen base para producción
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Puerto que expone la API
EXPOSE 8080

# Comando para iniciar la aplicación
ENTRYPOINT ["dotnet", "AcademiaNovit.dll"]
