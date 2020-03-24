# MovieServer

API with ASP.NET Core 3 and EF Core 3 using DDD, SOLID, Clean Code and CQRS principles.

## About this Project

API for listing movies using good Object Orientation practices.

## Why?

DDD is a software development approach that consists of modeling the domain-oriented application. It is about creating rich domains where they have the application's business rules. This development paradigm is based on the principles of SOLID.

This approach is indicated in applications with complex business rules where it is necessary to build a scalable architecture that allows easy extension and testability.

Therefore, presented the concept of DDD and in which scenario it applies, this project aims to show how the creation of an application is made using this architecture.

## Features

- Architectural
  - Division into layers
  - Principles of SOLID and Clean Code

- CRUD
  - Repository Pattern
  - Migrations
  - API 

- Account
  - Authentication
  - Authorization with JWT (JSON Web Token)
  
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

### Creating DataBase using Migrations

```
$ dotnet ef database update
```

### Running

```
$ dotnet run
```

## Built With

- [.NET Core 3](https://docs.microsoft.com/pt-br/dotnet/core/)
- [EF Core 3](https://docs.microsoft.com/pt-br/ef/core/get-started/?tabs=netcore-cli)


