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

2. **Open the solution**  
   Open the project solution in Visual Studio or Visual Studio Code.


3. **Configure the database**  
   Update the database connection string in the `appsettings.json` file to point to your database.

4. **Apply migrations**  
   Run the following command to create the database and apply migrations:  
   ```bash
   dotnet ef database update
5. Run the application  
   ```bash
   dotnet run
6. Open your browser and navigate to:
https://localhost:port

## Project Structure

- **Controllers/**: MVC controllers handling business logic and routes  
- **Models/**: Entities and data models  
- **Views/**: Razor views for the frontend pages  
- **Data/**: Entity Framework context and database configurations  
- **wwwroot/**: Static files (CSS, JavaScript, images)
- 
## Contributing

Contributions are always welcome! To contribute to this project, please follow these steps:

1. **Fork** the repository to create your own copy.  
2. **Create a new branch** for your feature or bugfix:  
   ```bash
   git checkout -b my-feature
3. Commit your changes with a descriptive message:

   ```bash
   git commit -m "Add some feature"

4. Push your branch to your forked repository:
     ```bash
   git push origin my-feature
5.Open a Pull Request on the original repository to propose your changes.

## Contact

For questions, suggestions, or support, please contact:  
Fernanda Perdizio Bezerra - perdizio.uk@gmail.com

## License

This project is licensed under the MIT License. See the LICENSE file for details.








