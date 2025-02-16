# Etapa de construcción
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar archivos y restaurar dependencias
COPY . .
RUN dotnet restore

# Compilar y publicar
RUN dotnet publish -c Release -o out

# Etapa de ejecución
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .
CMD ["dotnet", "csharp-api.dll"]
EXPOSE 5000