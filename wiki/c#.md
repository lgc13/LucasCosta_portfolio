# C# and dotnet cheat sheet

To compile and build c# files, use the following cmd:

`mcs file_name.cs file_class.cs`

then run with:

`mono file_name.exe`

## DB Migrations (mssql)

Use this to create a migration file:
`dotnet ef migrations add something`

To update database:
`dotnet ef database update`
