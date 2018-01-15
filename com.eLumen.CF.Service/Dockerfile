FROM microsoft/dotnet:latest

ENV DOTNET_CLI_TELEMETRY_OPTOUT 1

RUN mkdir -p /app/com.eLumen.CF.Service
COPY . /app/com.eLumen.CF.Service
WORKDIR /app/com.eLumen.CF.Service

EXPOSE 5000/tcp

RUN ["dotnet", "restore"]
ENTRYPOINT ["dotnet", "run", "-p", "project.json", "web"]
