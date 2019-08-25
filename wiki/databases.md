# Databases

## Microsoft SQLServer

- Installation

Install SQL Server (through Docker):
`docker pull microsoft/mssql-server-linux`

Install the sql-cli command line shell:
`yarn global add sql-cli`

Install the Docker instance:
`docker run -d --name sql_server_demo -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=reallyStrongPwd123' -p 1433:1433 microsoft/mssql-server-linux`

- Running it

Run a Docker container
`docker container start container_id`

Connect to sql-cli shell:
`mssql -u sa -p reallyStrongPwd123`
