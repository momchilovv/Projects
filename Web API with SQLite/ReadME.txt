Part 1: API General

1.> I have created Addresses SQLite Database with random Street, House number, ZIP Code, City which are in the Netherlands.

2.> Created a new project from Visual Studio 2022.

3.> Used the ASP.NET Core Web API template.

4.> Made a Connection String => Data source=../Database/addresses.sqlite

5.> I have added the following packages: 
	- Microsoft.EntityFrameworkCore.Design
	- Microsoft.EntityFrameworkCore.Sqlite
	- Microsoft.AspNetCore.Mvc.NewtonsoftJson

6.> Installed and updated the .NET Entity Framework Tool.

7.> After the update of the EF tool I have scaffolded the SQLite database.

8.> Next I have added the DB Context in the Program.cs which makes it function.

9.> I have added the API Controller with actions, using Entity Framework.

The first part is done with all requirements covered, as now when starting the project, it opens the Swagger UI with 2 GET, 
1 POST, 1 PUT and 1 DELETE query options, which are correctly working with the SQLite database.


Part 2: Filters

1.> I have added a new parameter for search in the GET/api/Addresses endpoint. If the search is empty it will display all addresses, 
otherwise it will display all addresses that contain the characters in the search box (case insensitive).

2.> For the sorting, I have created a new GET endpoint, which contains 2 query parameters.
The first one is the field of the database you want to sort and the second is how you want them to be sorted (Ascending/Descending).

Example:

field: City
order: Ascending

field: Street
order: Descending


How to run the API (Execution files)

1.> Open the net6.0 folder and run the execution file 'start.exe'.

2.> Open your browser and go to: localhost:5001/swagger/index.html

NOTE: Because of the Connection String in 'appsettings.json' the execution file 'start.exe' and the database 'addresses.sqlite'
must be on two separate folders which are in one main folder, otherwise the API won't be able to connect to the database. 

Example: 

folder\Database\addresses.sqlite
folder\net6.0\start.exe


How to run the API (Source code)

1.> Open Web API SQLite.sln with Visual Studio 2022.

2.> Press F5 to build the solution.

NOTE: Make sure the Database folder is in the same folder as the Web API SQLite, again because of the Connection String in 
'appsettings.json'.

Example: 

folder\Database\addresses.sqlite
folder\Web API SQLite\Web API SQLite.sln
