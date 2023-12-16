FROM mcr.microsoft.com/dotnet/sdk:6.0

WORKDIR /api
COPY . .

RUN dotnet dev-certs https
RUN dotnet restore
RUN dotnet publish -o /publish

WORKDIR /publish

ENTRYPOINT ["dotnet","/publish/Microservices.Docker.API.dll","--urls", "http://+:80;https://+:443"]