FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /app

run dotnet new blazor -o BlazingPizza
workdir /app/BlazingPizza
run mkdir PizzaData

COPY Pizza.razor ./Components/Pages/
COPY Program.cs .
COPY PizzaData/* PizzaData/

# Restaura las dependencias y construye el proyecto
RUN dotnet restore
RUN dotnet build

# Expone el puerto en el que correrá la aplicación
EXPOSE 8000

# Ejecuta la aplicación al iniciar el contenedor
ENTRYPOINT ["dotnet", "run", "--urls=http://0.0.0.0:8000"]

