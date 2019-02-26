Steps to build project from scratch
- Open Visual Studio 2017 CE
- Create a new C# project, Desktop Windows Form App
- In Solution Explorer, create three empty folders under the project: Entities, Mappings, and Migrations
- Open Tools, NuGet Package Manager, Manage NuGet Packages for Solution
  - Select Browse Tab, Package Source=All, Search for Entity Framework
  - install EntityFramework 6.2.0 by Microsoft
- Create a class corresponding to each database table (see Entities\EntityName.cs classes in repository for examples)
- Create a database context class (see ToDosContext.cs)
- Edit the main form... Add controls, set up bindings
- Create initial migration (this allows app to create database instance in SQL Server using EF Code First)... See https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/migrations/
  - open NuGet Package Manager console
  - enter 'Enable-Migrations'
      PM> enable-migrations
      Checking if the context targets an existing database...
      Code First Migrations enabled for project Snips.
  - Having trouble making this work in another project.  May need additional code and or nuget commands to create database, create initial migration, apply initial migration.  When project is running, tried Ctx = new SnipsContext("Snippets");
Ctx.Database.CreateIfNotExists(); - but this did not work.  Created database manually from VS SQL Server Object Explorer.  Then had to go to NuGet console and enter Add-Migration Initial and then Update-Database.

  -
-
-
