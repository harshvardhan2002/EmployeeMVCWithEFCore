# EmployeeMVCWithEFCore

### To create an ASP.NET MVC project using Entity Framework Core for CRUD operations (Create, Read, Update, Delete) with a table containing Employee data (with Id, Name, and Email properties), follow these steps:

#### 1. Have Visual Studio for writing ur code
#### 2. Install SQL Server and SSMS from it for storing Data and having a local database in ur system
#### 3. While opening Visual Studio, Select ASP.NET Web Application (.NET Framework)
#### 4. Make Sure to Select Empty project and check on MVC checkbox
#### 5. Install Necessary NuGet Packages for EF Core, Go to NuGet Package Manager and install in the below order and check versions as .NET Framework is compatible with only versions below 5.0
##### i] Microsoft.EntityFrameworkCore.SqlServer -Version 3.1.32
##### ii] Microsoft.EntityFrameworkCore.Design -Version 3.1.32
##### iii] Microsoft.EntityFrameworkCore.Tools -Version 3.1.32
#### 6. Create a class in Models folder. It contains properties of the Employee.
#### 7. Set Up DbContext- Create a Data folder with a context class that represents ur database context. It contains the path of local database where ur data will get stored during CRUD.
#### 8. Add a Migration and Update the Database in Package Manager Console. It will create the database table (check sql server object explorer)
##### i] add-migration migrationName
##### ii] update-database
#### 9. Create the EmployeeController in the Controllers folder. It handles user input, interacts with the Model to retrieve or manipulate data, and then selects the appropriate View to display the results.
#### 10. Create Views for CRUD Operations
##### i] Index View (empty with models)
##### ii] Create View
##### iii] Details View
##### iv] Edit View
##### v] Delete View
#### 11. Run the Program.

Snapshots of my Output
### MVC application with EF Core database integration
![MVCEF1](https://github.com/user-attachments/assets/e10f95bb-444b-4fa8-b1f6-d27f9a7aac71)
### Details
![MVCEF2](https://github.com/user-attachments/assets/b1b2e7e7-8b4b-4510-820c-ab59b063dfbd)
### Edit
![MVCEF3](https://github.com/user-attachments/assets/2b5e452d-b5e2-44ef-8bd0-723f31265170)
### Edit is updated in Database
![MVCEF4](https://github.com/user-attachments/assets/1f74f546-b477-4619-af0c-8bcdbbf77877)
### Create New Employee
![MVCEF5](https://github.com/user-attachments/assets/79309602-4d87-44a2-901d-99e68ecb325c)
### Employee created in database
![MVCEF6](https://github.com/user-attachments/assets/f0bdb8f5-f982-47e2-8309-ed3645870872)


