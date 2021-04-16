FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

ENV DynamoDb_LocalMode='true'

WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./practiceApi.sln ./
COPY ./practiceApi/practiceApi.csproj ./practiceApi/
COPY ./practiceApi.Tests/practiceApi.Tests.csproj ./practiceApi.Tests/

RUN dotnet restore ./practiceApi/practiceApi.csproj
RUN dotnet restore ./practiceApi.Tests/practiceApi.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out practiceApi.Tests/practiceApi.Tests.csproj

CMD dotnet test
