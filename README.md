# ICMPC Test Submission

## Overview
This is a responsive web application built using **ASP.NET Core MVC (Version 9)** with **Entity Framework Core** and **MySQL** as the database. The application supports user authentication, session control, and CRUD operations for managing products with pagination.

## Features
- **User Registration & Login** (with hashed passwords using BCrypt)
- **Session Control** (Auto logout after 1 minute of inactivity)
- **Product Management** (Add, Edit, Delete, View Details)
- **Pagination** (5 products per page in Admin Dashboard)
- **Secure Authentication** using ASP.NET Identity and Cookie Authentication

## Prerequisites
Ensure you have the following installed before running the project:

- [.NET SDK 9+]
- [Visual Studio Code / Visual Studio]
- [MySQL Server]
- [Git]

## Setup Instructions

### 1. Clone the Repository
```sh
git clone https://github.com/yourusername/ICMPC-WebApp.git
cd ICMPC-WebApp
```

### 2. Configure Database
- Import the provided **SQL script** into MySQL Server:

  1. Open MySQL Workbench or command line.
  2. Create a new database:
     ```sql
     CREATE DATABASE ICMPCDb;
     ```
  3. Use the database:
     ```sql
     USE ICMPCDb;
     ```
  4. Import the `ICMPCDb.sql` file provided in the `SQL script` folder:
     ```sh
     mysql -u root -p ICMPCDb < ICMPCDb.sql
     ```

### 3. Update Connection String
Modify `appsettings.json` to match your MySQL credentials:
```json
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=ICMPCDb;User=root;Password=yourpassword;"
}
```

### 4. Run Database Migrations (if needed)
```sh
dotnet ef database update
```

### 5. Run the Application
```sh
dotnet run
```
- The application will be accessible at `http://localhost:5000`

## Flowchart
The flowchart below illustrates the architecture and workflow of the application:

![System Flowchart](System%20Flowchart/ICMPCTestFlowChart.png)

## API Endpoints
| Endpoint             | Method | Description                     |
|----------------------|--------|---------------------------------|
| `/Account/Login`    | POST   | Authenticate user login        |
| `/Account/Register` | POST   | Register a new user            |
| `/Admin/Dashboard`  | GET    | View paginated product list    |
| `/Product/Add`      | POST   | Add a new product              |
| `/Product/Edit/{id}` | POST   | Edit existing product          |
| `/Product/Delete/{id}` | DELETE | Remove a product from DB    |

## Contact
For any questions, feel free to reach out at **haziqiskandar443@gmail.com**
