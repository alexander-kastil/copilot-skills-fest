# Fitness API

## Service Overview

The Fitness API is a .NET 9 Web API that provides backend services for managing students and their exercises. It uses Entity Framework Core with SQLite for data persistence.

### Key Features

- Manage students and their details.
- Track exercises associated with students.
- RESTful endpoints for CRUD operations.

### Architecture Diagram

```
[Client] <--> [Fitness API] <--> [SQLite Database]
```

### Tech Stack

- .NET 9
- Entity Framework Core
- SQLite

## Development Guide

### Prerequisites

- .NET 9 SDK
- SQLite

### Build and Execution Instructions

1. Clone the repository.
2. Navigate to the `fitness-api` directory.
3. Run `dotnet build` to build the project.
4. Run `dotnet run` to start the API.

### Dependencies

- None (standalone service).

## Configuration Reference

| Config Key                            | Description                | Required | Default                  | Example                  |
| ------------------------------------- | -------------------------- | -------- | ------------------------ | ------------------------ |
| `ConnectionStrings:DefaultConnection` | Database connection string | Yes      | `Data Source=fitness.db` | `Data Source=fitness.db` |
