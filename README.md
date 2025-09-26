# Week 11 Independent Project: Dr. SillyStringz's Factory Database Solution!

#### A website that allows Factory Managers to track their Engineers and Machines!

#### By Ashe Urban

## Technologies Used

* _C#_ 
* _.NET 5 (ASP.NET Core MVC)_ 
* _CSHTML_ 
* _CSS_ 
* _Entity Framework Core_ 
* _SQL Database_ 
* _dotnet_ 
* _LINQ_ 
* _Markdown_

## Description

_You've been contracted by the factory of the famous Dr. Sillystringz to build an application to keep track of their machine repairs. You are to build an MVC web application to manage their engineers, and the machines they are licensed to fix. The factory manager should be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines. There should be a many-to-many relationship between Engineers and Machines. An engineer can be licensed to repair (belong to) many machines (such as the Dreamweaver, the Bubblewrappinator, and the Laughbox) and a machine can have many engineers licensed to repair it_

* _List of all Engineers._
* _List of all Machines._
* _Engineer Details including Machines they work on._
* _Machine Details including Engineers that work on them._
* _Add new Engineers._
* _Add new Machines._
* _Add and Delete Machines from Engineers._
* _Add and Delete Engineers from Machines._

## Setup/Installation Requirements

* _Clone or download responsitory to your local._
* _Cd into .\Factory and run dotnet restore to confirm the project has no errors._
* _Touch appsettings.json and add the following configuration:_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[first_last];uid=[yours];pwd=[password];"
  }
}
```
_NOTE:_ [first_last] [yours] [password] should all be replaced by your MySql access details. Do not include square brackets in final configuration.

* _Start localhost in MySQL_
* _Build database:_
  ```
  dotnet ef migrations add Initial 
  ```
  ```
  dotnet ef database update 
  ```
* _Then use the following to run web application:_
   ```
   dotnet run OR dotnet watch run
   ```
* _Navigate to the localhost from your browser and explore the project!_
* _If you are seeing an error that tables cannot befound, there are missing or more than one DbContexts, or there are unresolvable errors related to the database use:_
  ```
  dotnet ef database drop -f --context FactoryContext
  ```
* _Then delete your migrations folder and everything in it, then rerun intial migrations and database update using dotnet as outlined above._

## Known Bugs

* _No known bugs._

## License

* MIT

## Contact Information

_Please contact me with any questions or contribuitions, ashe@goldentongue.com_

Copyright(c) July 2022 Ashe Urban