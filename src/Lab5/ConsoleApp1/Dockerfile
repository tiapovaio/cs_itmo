FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Lab5/ConsoleApp1/ConsoleApp1.csproj", "src/Lab5/ConsoleApp1/"]
RUN dotnet restore "src/Lab5/ConsoleApp1/ConsoleApp1.csproj"
COPY . .
WORKDIR "/src/src/Lab5/ConsoleApp1"
RUN dotnet build "ConsoleApp1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleApp1.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleApp1.dll"]
