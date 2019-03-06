FROM microsoft/dotnet:sdk
WORKDIR /app

COPY . ./

# Disable Microsoft telemetry
ENV DOTNET_CLI_TELEMETRY_OPTOUT=true

# Restore dependencies
RUN dotnet restore

# Build in release mode
RUN dotnet publish --configuration Release

# Expose HTTP port
EXPOSE 5000

# Run server
ENTRYPOINT ["dotnet", "./App/bin/Release/netcoreapp2.2/App.dll"]
