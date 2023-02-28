FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Vulcanova.Febe/Vulcanova.Febe.csproj", "Vulcanova.Febe/"]
RUN dotnet restore "Vulcanova.Febe/Vulcanova.Febe.csproj"
COPY . .
WORKDIR "/src/Vulcanova.Febe"
RUN dotnet build "Vulcanova.Febe.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Vulcanova.Febe.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Vulcanova.Febe.dll"]
