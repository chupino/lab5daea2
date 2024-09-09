from mcr.microsoft.com/dotnet/sdk:6.0
workdir app
run dotnet new blazorserver -o BlazingPizza --no-https true -f net6.0
workdir BlazingPizza
copy PizzaApp/* .
run dotnet restore
run dotnet build
entrypoint dotnet run --urls="http://0.0.0.0:8000"
