FROM mcr.microsoft.com/dotnet/runtime:3.1

COPY bin/Release/netcoreapp3.1/publish App/
WORKDIR /App
ENTRYPOINT ["dotnet", "HelloWorld.dll"]
