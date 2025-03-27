# Fitness App

![app](/tasks/assets/general/app.jpg)

This repository a guide to vibe coding for fitness application containing a [task list](tasks/readme.md) to full fill the [goals](goal/readme.md) of the [Microsoft Skill Fest](https://aiskillsfest.event.microsoft.com/)

## Project Overview

The Fitness App is a comprehensive solution for managing students and their exercise routines. It consists of a .NET 9 Web API backend and an Angular 19 frontend, providing a seamless experience for users.

### Project Purpose and Objectives

- Simplify the management of student data and exercise tracking.
- Provide a responsive and user-friendly interface.
- Ensure scalability and maintainability with modern technologies.

### High-Level Architecture Diagram

```
[Browser] <--> [Fitness UI (Angular)] <--> [Fitness API (.NET)] <--> [SQLite Database]
```

### Key Technologies and Frameworks

- Angular 19
- .NET 9
- SQLite

### Project Structure

```
.
├── .ado/          # Azure DevOps pipeline configurations
├── infra/         # Infrastructure as Code and deployment scripts
└── src/           # Source code and services
    ├── fitness-api/  # Backend API
    └── fitenss-ui/   # Frontend application
```

## Quick Start Guide

### Prerequisites

- Node.js 20.12.2 or higher
- Angular CLI
- .NET 9 SDK
- SQLite

### Development Setup Instructions

1. Clone the repository.
2. Navigate to the `src/fitness-api` directory and run `dotnet run` to start the backend.
3. Navigate to the `src/fitenss-ui` directory and run `ng serve` to start the frontend.
4. Open your browser and navigate to `http://localhost:4200/` to access the application.
