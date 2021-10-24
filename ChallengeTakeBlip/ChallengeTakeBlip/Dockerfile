
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ChallengeTakeBlip/ChallengeTakeBlip.csproj", "ChallengeTakeBlip/"]
RUN dotnet restore "ChallengeTakeBlip/ChallengeTakeBlip.csproj"
COPY . .
WORKDIR "/src/ChallengeTakeBlip"
RUN dotnet build "ChallengeTakeBlip.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ChallengeTakeBlip.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ChallengeTakeBlip.dll"]