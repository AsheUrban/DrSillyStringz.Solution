# Week 11 Independent Project: Dr. SillyStringz's Factory Database Solution!

#### A website that allows Factory Managers to track their Engineers and Machines!

#### By Ashe Urban

## Technologies Used

* _C#_
* _CSHTML_
* _CSS_
* _Entity Framework_
* _SQL Database_
* _dotnet_
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


_Link to assignment:_ https://epicenter.epicodus.com/courses/968/code_reviews/5862

### Dr. SillyStringz Factory

_You must follow the naming conventions for your project. Projects that do not follow these conventions will not be reviewed and will be returned not passing._

_Use your first name and last name to name your database in the following way:_

_Production Database:_ first_last
_Main Project Folder:_ Factory

## Setup/Installation Requirements

* _Clone or download responsitory to your local._
* _Cd into Factory and run dotnet restore, dotnet build, and dotnet run to run web application._
* _Touch appsettings.json and add the following configuration:_

{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=ashe_urban;uid=root;pwd=[password];"
  }
}

_NOTE:_ [password] should be replaced by your password. Do not include square brackets in final configuration.

## Known Bugs -- IMPORTANT --

* _No known bugs._

## License

* MIT

## Contact Information

_Please contact me with any questions or contribuitions, ashe@goldentongue.com_

Copyright(c) July 2022 Ashe Urban