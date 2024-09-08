from mcr.microsoft.com/dotnet/sdk:8.0
workdir app
run dotnet new blazor -o BlazingPizza
workdir BlazingPizza
copy PizzaApp/* .
run dotnet restore
run dotnet build
entrypoint dotnet run --urls="http://0.0.0.0:8000"
