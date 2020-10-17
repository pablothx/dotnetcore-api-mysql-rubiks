# dotnetcore-api-mysql-rubiks

### Documentation 
## MySql 

CREATE DATABASE Rubik;

USE Rubik;

CREATE TABLE RubiksCube (
RubikId INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
Name VARCHAR(30) NOT NULL,
Sides VARCHAR(30) NOT NULL,
Complexity VARCHAR(30) NOT NULL,
Description VARCHAR(5000)
)

CREATE TABLE TrackingSolution (
TrackingSolution INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
RubikId  INT(6) UNSIGNED NOT NULL,
ResolutionDate DATETIME NOT NULL,
ResolutionFinishedSeconds INT NOT NULL
)

Must have DotNet-Core installed on your system.

Then we create the "webapi" solution:

` dotnet new webapi -n Rubiks ` 

We run EF Migrations
You must have DotNet-Core references in  on your Rubiks.csproj file.

` dotnet ef dbcontext scaffold "Server=localhost;database=Rubik;user=root;pwd=pass;" "Pomelo.EntityFrameworkCore.MySql" -o \Models -f ` 

