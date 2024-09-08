from mcr.microsoft.com/dotnet/sdk:8.0
workdir app
run dotnet new blazorserver -o BlazingPizzaSite
workdir BlazingPizzaSite
copy . .
run dotnet restore
run dotnet build
entrypoint dotnet run
