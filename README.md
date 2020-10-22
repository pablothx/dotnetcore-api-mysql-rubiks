# dotnetcore-api-mysql-rubiks

### Documentation 
## MySql 

CREATE DATABASE Rubik;

USE Rubik;

Follow the following steps https://entityframework-extensions.net/efcore-pomelo-mysql-provider


Must have DotNet-Core installed on your system.

Then we create the "webapi" solution:

` dotnet new webapi -n Rubiks ` 

Clone this repo

dotnet ef migrations add InitialMigration 

Run:
dotnet restore
dotnet build
dotnet run

GET
https://localhost:5001/api/rubiks

POST
https://localhost:5001/api/rubiks

{
"Name": "POST Test",
"Sides": 6,
"Complexity": "EASY",
"Description": " Desc"
}
