FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app
# Copy csproj and restore as distinct layers
RUN pwd
COPY D:\a\1\s\WebAppContainer\WebAppContainer.csproj ./
RUN dotnet restore
# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out
# Build runtime image
FROM microsoft/dotnet:2.1-runtime AS runtime
EXPOSE 5555
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "WebAppContainer.dll"]
