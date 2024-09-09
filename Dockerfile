FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app

# Copia el proyecto completo desde el directorio local 'PizzaApp' al contenedor
COPY PizzaApp/ ./
COPY Index.razor ./Pages

# Restaura las dependencias y construye el proyecto
RUN dotnet restore
RUN dotnet build

# Expone el puerto en el que correrá la aplicación
EXPOSE 8000

# Ejecuta la aplicación al iniciar el contenedor
ENTRYPOINT ["dotnet", "run", "--urls=http://0.0.0.0:8000"]

