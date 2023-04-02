FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ConsoleAppConfig/ConsoleAppConfig.csproj", "ConsoleAppConfig/"]
RUN dotnet restore "ConsoleAppConfig/ConsoleAppConfig.csproj"
COPY . .
WORKDIR "/src/ConsoleAppConfig"
RUN dotnet build "ConsoleAppConfig.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleAppConfig.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleAppConfig.dll"]
