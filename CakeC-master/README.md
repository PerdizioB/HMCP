# HMCP - ASP.NET Core MVC E-commerce

HMCP is an e-commerce web application built with ASP.NET Core MVC and Entity Framework. It provides features such as product management, user registration and login, shopping cart, and authentication. This project serves as a practical example for learning and developing web applications using Microsoft technologies.

## Features

- User registration and login
- Product management (add, edit, delete)
- Shopping cart with quantity control
- Authentication and authorization system
- User-friendly interface with easy navigation
- Entity Framework Core for data persistence

## Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server (or any configured relational database)
- Bootstrap (for frontend styling)
- C#

## How to Run the Project

1. Clone this repository:

   ```bash
   git clone https://github.com/PerdizioB/HMCP.git
Open the solution in Visual Studio or VS Code.

Configure the database connection string in the appsettings.json file.

Run the migrations to create the database:

bash
Copy
Edit
dotnet ef database update
Run the application:

bash
Copy
Edit
dotnet run
Open your browser and navigate to https://localhost:5001 (or your configured port).

Project Structure
Controllers/ - Contains MVC controllers responsible for business logic and route control.

Models/ - Defines the entities and data models used in the application.

Views/ - Razor views for frontend pages.

Data/ - Entity Framework context and database configurations.

wwwroot/ - Static files like CSS, JavaScript, and images.

Contributing
Contributions are welcome! To contribute:

Fork the repository.

Create a feature branch: git checkout -b my-feature

Commit your changes: git commit -m 'Add some feature'

Push to the branch: git push origin my-feature

Open a Pull Request.

Contact
For questions, suggestions or support, please contact:
Fernanda Perdizio Bezerra - perdizio.uk@gmail.com

License
This project is licensed under the MIT License. See the LICENSE file for details.
