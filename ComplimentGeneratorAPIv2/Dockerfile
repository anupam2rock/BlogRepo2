FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ComplimentGeneratorAPIv2.csproj", "./"]
RUN dotnet restore "ComplimentGeneratorAPIv2.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "ComplimentGeneratorAPIv2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ComplimentGeneratorAPIv2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ComplimentGeneratorAPIv2.dll"]
