FROM microsoft/dotnet:latest

ENV DOTNET_CLI_TELEMETRY_OPTOUT 1

RUN mkdir -p /app/com.eLumen.CF
COPY . /app/com.eLumen.CF
WORKDIR /app/com.eLumen.CF

EXPOSE 5000/tcp

RUN ["dotnet", "restore"]
ENTRYPOINT ["dotnet", "run", "-p", "project.json", "web"]
