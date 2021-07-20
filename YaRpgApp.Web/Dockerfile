FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["YaRpgApp.Web/YaRpgApp.Web.csproj", "YaRpgApp.Web/"]
RUN dotnet restore "YaRpgApp.Web/YaRpgApp.Web.csproj"
COPY . .
WORKDIR "/src/YaRpgApp.Web"
RUN dotnet build "YaRpgApp.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "YaRpgApp.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "YaRpgApp.Web.dll"]
