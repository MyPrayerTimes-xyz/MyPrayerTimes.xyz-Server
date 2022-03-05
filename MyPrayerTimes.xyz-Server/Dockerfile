FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MyPrayerTimes.xyz-Server/MyPrayerTimes.xyz-Server.csproj", "MyPrayerTimes.xyz-Server/"]
RUN dotnet restore "MyPrayerTimes.xyz-Server/MyPrayerTimes.xyz-Server.csproj"
COPY . .
WORKDIR "/src/MyPrayerTimes.xyz-Server"
RUN dotnet build "MyPrayerTimes.xyz-Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyPrayerTimes.xyz-Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyPrayerTimes.xyz-Server.dll"]
