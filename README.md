# _Eau\_Claire's\_Salon_

#### By _**S-Espinet**_

#### _C# web application that tracks a salon's stylists and their clients._

## Technologies Used

* _C#_
* _.NET5.0_
* _Microsoft Entity Framework Core_
* _MySQLWorkbench_
* _SQL_
* _C# HTML_
* _Razor view engine_
* _Bootstrap_

## Description

_This is a C# web application that tracks an imaginary salon's stylists and their clients by adding them and information about them to a database._

## GitHub Pages Link

* _N/A_

## Setup/Installation Requirements
### To Create Database:
* _make sure MySQLWorkbench is installed_
* _click the icon to make a new schema (hover text: "create new schema in the connected server)_
* _enter name for schema_
* _in a series of popup windows, click apply, then apply, then close_
* _in the schemas tab or the navigator window, click the arrow next to the name of your database/schema to toggle its contents_
* _right-click on tables, and select create table_
* _enter table name (should be plural and lowercase)_
* _enter column names (should be singular and PascalCase)_

### For Project

* _navigate to github.com/S-Espinet in browser_
* _select repository (HairSalon.Solution)_
* _click `Code` button and select desired security protocol_
* _run git clone in terminal into desired directory_
* _make sure that dotnet is installed_
* _run "dotnet restore" in terminal from HairSalon directory_
* _you may need to run the following commands in the terminal:_  
	*  _dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0_ 
	* _dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2_ 
	* _dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0_
* _create appsettings.json file; if should appear as follows:_  

	~~~
{
  "ConnectionStrings": {
      "DefaultConnection":  "Server=localhost;Port=3306;database=sarah_espinet;uid=root;pwd=epicodus;"
        }
}
~~~
* _your appsettings.json file, and any auto-generated files/directories (bin, obj, .vscode) should be stored in your .gitignore file_
* _run "dotnet run" in terminal from HairSalon directory_
* _navigate to appropriate localhost location_
* _respond to prompts in browser to add contents to your database_

## Known Bugs

* _No known bugs at this time_

## License

_[MIT](https://en.wikipedia.org/wiki/MIT_License)_

Copyright (c) _2022_ _S-Espinet_