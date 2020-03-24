# MovieServer

API with ASP.NET Core 3 and EF Core 3 using DDD, SOLID, Clean Code and CQRS principles.

## About this Project

API for listing movies using good Object Orientation practices.

## Why?

DDD is a software development approach that consists of designing the domain-oriented application. It is about creating rich domains where they have the application's business rules. This development paradigm is based on the principles of SOLID.

This approach is indicated in applications with complex business rules where it is necessary to build a scalable architecture that allows easy extension and testability.

Therefore, presented the concept of DDD and in which scenario it applies, this project aims to show how the creation of an application is made using this architecture.

## Features

- Architectural
  - Division into layers
  - Principles of SOLID and Clean Code

- Database
  - Repository Pattern
  - Migrations

- Account
  - Authentication
  - Authorization
  - JWT (JSON Web Token)
  
- Tests
  - Unitary Tests
  
## Getting Started

### Prerequisites

To run this project in the development mode, you'll need to have a basic environment to run a .NET Core Application. You can get it [here](https://dotnet.microsoft.com/download).

### Installing

**Cloning the Repository**

```
$ git clone https://github.com/brunoalves9698/movieserver.git

$ cd movieserver
```
### Configuring the Server

Go to the [/src/movieservice.api/appsettings.development.json](https://github.com/brunoalves9698/MovieServer/blob/master/src/MovieService.Api/appsettings.Development.json) file and edit the 'Server' value into 'connectionString' key for the SqlServer of your machine.

It should looks like this:

"connectionString": "Server=YOUR_SQL_SERVER_PROVIDER\SQLEXPRESS;DataBase=MovieCine;Trusted_Connection=true;"

### Creating the Datadase using Migrations

1 - Add EF Core migration CLI

```
$ dotnet tool install --global dotnet-ef
```
2 - Create database

```
$ cd src/movieservice.infra

$ dotnet ef database update
```

### Running

With all dependencies installed and the environment properly configured, you can now run the app:

```
$ dotnet run
```

## Built With

- [.NET Core 3](https://docs.microsoft.com/pt-br/dotnet/core/)
- [EF Core 3](https://docs.microsoft.com/pt-br/ef/core/get-started/?tabs=netcore-cli)


