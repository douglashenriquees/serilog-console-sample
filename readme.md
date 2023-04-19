* ```dotnet add package Serilog```
* ```dotnet add package Serilog.Sinks.Console```
* ```dotnet add package Serilog.Sinks.File```
* ```dotnet add package Serilog.Sinks.Seq```

* ```docker-compose up -d```
  * ```docker exec -it es-container /bin/bash```
    * ```elasticsearch-create-enrollment-token --scope kibana```
  * ```docker exec -it kb-container /bin/bash```
    * ```kibana-verification-code```

* ```docker run --name seq --restart unless-stopped -e ACCEPT_EULA=Y -p 80:80 -p 5341:5341 datalust/seq```