# Lucas's Docker cheat sheet

Checks instances running
`docker ps`

Stop instance running
`docker stop container_id`


## Installing SQL Server

Install SQL Server
`docker pull microsoft/mssql-server-linux`

Run the Docker instance:
`docker run -d --name sql_server_demo -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=reallyStrongPwd123' -p 1433:1433 microsoft/mssql-server-linux`
