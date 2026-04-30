# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# copy csproj and restore (from subfolder)
COPY MyTestWebApi/*.csproj ./MyTestWebApi/
RUN dotnet restore MyTestWebApi/MyTestWebApi.csproj

# copy full source
COPY MyTestWebApi/. ./MyTestWebApi/
WORKDIR /src/MyTestWebApi

# publish
RUN dotnet publish -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8080

ENTRYPOINT ["dotnet", "MyTestWebApi.dll"]