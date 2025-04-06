# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia só o .csproj primeiro (isso evita cache desnecessário)
COPY API_Palusa.csproj ./
RUN dotnet restore

# Copia todo o restante da aplicação
COPY . ./
RUN dotnet publish -c Release -o /out

# Etapa de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /out .

# Define a porta que o Railway vai usar
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "API_Palusa.dll"]

