# Fitness App

This repository a guide to Vibe Coding using GitHub Copilot for a fitness application. It contains a [task list](tasks/readme.md) to full fill the [goals](goal/readme.md) of the [Microsoft Skill Fest](https://aiskillsfest.event.microsoft.com/)

- [ ] **Task 1**: Project Setup including a devcontainer.json
- [ ] **Task 2**: Implement the Web Api
- [ ] **Task 3**: Implement the Angular App
- [ ] **Task 4**: Add project documentation

## Project Overview

The Fitness App is a comprehensive solution for managing students and their exercise routines. It consists of a .NET 9 Web API backend and an Angular 19 frontend, providing a seamless experience for users.

![app](/tasks/assets/general/app.jpg)

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
- Angular CLI 19
- .NET 9 SDK
- SQLite

### Development Setup Instructions

1. Clone the repository.
2. Navigate to the `src/fitness-api` directory and run `dotnet run` to start the backend.
3. Navigate to the `src/fitenss-ui` directory and run `ng serve` to start the frontend.
4. Open your browser and navigate to `http://localhost:4200/` to access the application.

## Contributing

Feel free to contribute. When contribute implement your changes / additions on a feature branch in your fork and issue a pull request after completion. An introduction video into forks and pull requests can be found [here](https://www.youtube.com/watch?v=nT8KGYVurIU)

## License & Re-Use

This work is licensed under a Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License

Permission is hereby granted to to use, modify, and distribute the workshop materials provided under the following conditions:

- Personal Use: Users may use the materials for personal learning and educational purposes.
- Modification: Users may modify the materials to suit their needs.
- Non-Commercial Use: Commercial use by other trainers or organizations is strictly prohibited.
- Attribution: Users must give appropriate credit to the author and include a link to the original materials.
- Share-Alike: Any derivative works based on these materials must be shared under the same license terms.

For commercial use please contact the author via [LinkedIn](https://www.linkedin.com/in/alexander-kastil-3bb26511a/) or [email](mailto:alexander.kastil@integrations.at)
