FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app

#run dotnet new blazor -n BlazingPizza
COPY PizzaApp/ .
#workdir /app/BlazingPizza

COPY Pizza.razor ./Pages/
COPY Index.razor ./Pages/
COPY Program.cs .
COPY Controllers/* Controllers/
COPY BlazingPizza.csproj .
COPY PizzaData/* PizzaData/
COPY ConfigurePizzaDialog.razor ./Shared/
COPY Services/* Services/

# Restaura las dependencias y construye el proyecto
RUN dotnet restore
RUN dotnet build

# Expone el puerto en el que correrá la aplicación
EXPOSE 8000

# Ejecuta la aplicación al iniciar el contenedor
ENTRYPOINT ["dotnet", "run", "--urls=http://0.0.0.0:8000"]

