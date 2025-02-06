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
git clone https://github.com/your-repo/ICMPC_Test.git
cd ICMPC_Test
```

### 2. Database Setup
- The SQL script to create the required database and tables is provided in the `SQL script` folder.
- Execute the script in your MySQL server to set up the database.

### 3. Run Database Migration
To ensure the database is up to date and includes the default admin account, run:
```sh
dotnet ef database update
```
This will apply any pending migrations and create the `admin@example.com` account with password `admin123`.

### 4. Configure the Application
- Update `appsettings.json` with your database connection string.
```json
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;database=ICMPC_Test;user=root;password=yourpassword;"
}
```

### 5. Run the Application
```sh
dotnet restore
dotnet build
dotnet run
```

The application will be available at `http://localhost:5000`.

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
