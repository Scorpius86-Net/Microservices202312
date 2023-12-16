FROM mcr.microsoft.com/dotnet/aspnet:6.0

WORKDIR /app
#Physical to Container
COPY bin/Debug/net6.0/publish .

ENTRYPOINT ["dotnet","Microservices.Docker.API.dll"]