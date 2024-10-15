-------------------------------------------------
Install Required NuGet Packages
-------------------------------------------------
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL

-------------------------------------------------
Create the Database and Run Migrations
-------------------------------------------------
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet tool install --global dotnet-ef

-------------------------------------------------------
Install the Microsoft.EntityFrameworkCore.Design Package
-------------------------------------------------------
dotnet add package Microsoft.EntityFrameworkCore.Design

--------------------------------------------------------
To create new web project
--------------------------------------------------------
dotnet new web -o project-name

----------------------------------------------------------
Build and Run
----------------------------------------------------------
dotnet build
dotnet run
