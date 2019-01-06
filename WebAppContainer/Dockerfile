FROM microsoft/dotnet:sdk AS build
WORKDIR /app
# Copy csproj and restore as distinct layers
RUN pwd
COPY *.csproj ./
RUN dotnet restore
# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out
# Build runtime image
FROM microsoft/dotnet:aspnetcore-runtime AS runtime
EXPOSE 5555
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "WebAppContainer.dll"]