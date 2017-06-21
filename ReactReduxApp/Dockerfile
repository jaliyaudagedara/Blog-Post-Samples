FROM microsoft/aspnetcore:1.1.2
LABEL Name=ReactReduxApp Version=0.0.0
ARG source
WORKDIR /app
EXPOSE 30000
COPY ${source:-bin/Release/netcoreapp1.1/publish} .
RUN apt-get update
RUN apt-get install -y npm
RUN npm install -g n; n stable
ENTRYPOINT dotnet ReactReduxApp.dll