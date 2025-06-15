# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia os arquivos do projeto e restaura as dependências
COPY ["vet-gestor-api.csproj", "./"]
RUN dotnet restore "./vet-gestor-api.csproj"

# Copia todo o código e faz o build da aplicação
COPY . .
RUN dotnet publish "vet-gestor-api.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Porta que a aplicação irá expor
EXPOSE 80
EXPOSE 443

# Definir o comando para rodar a aplicação
ENTRYPOINT ["dotnet", "vet-gestor-api.dll"]