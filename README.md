# Educational Resource API

## Overview
The **Educational Resource API** is a RESTful web API built using **.NET 6** and **MongoDB** for managing educational resources. The API supports CRUD operations, user authentication using **JWT**, and additional features like pagination**.

## Features
- **User Authentication** (JWT-based login & registration)
- **CRUD operations** for educational resources
- **MongoDB Integration** for data storage
- **Dependency Injection** for modular service management
- **Error Handling** for robustness
- **Swagger API Documentation** for easy testing

## Technologies Used
- **.NET 6** (ASP.NET Core)
- **MongoDB** (NoSQL Database)
- **Entity Framework Core** (For Dependency Injection)
- **JWT (JSON Web Token)** (For Authentication)
- **Swagger UI** (For API Documentation)

## Prerequisites
Ensure you have the following installed:
- **.NET 6 SDK**
- **MongoDB** (Installed & running)
- **Postman or Swagger UI** (For testing API endpoints)

## Getting Started

### Clone the Repository
```sh
git clone https://github.com/Yared3214/Elective-Project.git
cd Elective-Project
```

### Configure MongoDB Connection
Update the `appsettings.json` file with your MongoDB credentials:

```json
"DatabaseSettings": {
  "ConnectionString": "mongodb://localhost:27017",
  "DatabaseName": "EducationalDB"
}
```

### Install Dependencies
```sh
dotnet restore
```

### Run the Application
```sh
dotnet run
```

The API will be available at `http://localhost:5000` or `https://localhost:5001`.

## API Endpoints

### Authentication Endpoints
| Method | Endpoint           | Description             |
|--------|-------------------|-------------------------|
| POST   | `/api/auth/register` | Register a new user    |
| POST   | `/api/auth/login`    | Authenticate a user    |

### Educational Resource Endpoints
| Method | Endpoint                  | Description                       |
|--------|--------------------------|-----------------------------------|
| GET    | `/api/resources`         | Get all resources                |
| GET    | `/api/resources/{id}`    | Get a specific resource by ID    |
| POST   | `/api/resources`         | Create a new resource            |
| PUT    | `/api/resources/{id}`    | Update an existing resource      |
| DELETE | `/api/resources/{id}`    | Delete a resource                |

## Authentication (JWT)
This API uses JWT for authentication. After logging in, include the generated token in your request headers:

```
Authorization: Bearer YOUR_ACCESS_TOKEN
```

## Swagger API Documentation
To explore and test endpoints using Swagger UI, open:

```
http://localhost:5000/swagger
```

## Error Handling
The API follows a structured error handling approach, returning meaningful messages for issues such as:
- **Invalid input** (400 Bad Request)
- **Unauthorized access** (401 Unauthorized)
- **Resource not found** (404 Not Found)

## Contribution
Feel free to fork the repository and contribute by submitting pull requests.

## License
This project is licensed under the MIT License.

---

### Contact
For any queries or support, reach out to **yaredbitewlign@gmail.com**.

