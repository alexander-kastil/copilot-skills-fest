# Fitness App

![app](/tasks/assets/general/app.jpg)

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

# Build applications with GitHub Copilot agent mode

## Session Abstract

Build applications with GitHub Copilot agent mode. GitHub has significantly enhanced its Copilot offering with the preview release of agent mode. This feature aim to streamline and automate code editing workflows, allowing developers to iterate on code changes more efficiently using natural language prompts. agent mode takes GitHub Copilot even further by enabling Copilot to autonomously plan and execute tasks, including suggesting and running terminal commands, and iterating to resolve issues. These advancements signify a move towards a more "agentic AI" that proactively assists developers throughout the development lifecycle.

## Session level

Intermediate (200), technical

## Duration

1 hour

## Speaker Expectation/Skills

Speakers be familar with the GitHub platform, be able to develop code, understand a programming language, a framework,
GitHub Copilot fundamentals

The presentation is designed to be delivered by three presenters, but can also be presented by one.

## Session overview

The session will cover the following topics:

- GitHub Copilot inline suggestions
- GitHub Copilot Chat
- GitHub Copilot edits
- GitHub Copilot agent mode
- Chat participants, variables, and slash commands

## Key Audience Takeaways

By the end of this session, participants will understand:

- Understand how to develop with VS Code IDE in a GitHub Codespace
- Prompt GitHub Copilot agent mode to create an application
- Leverage documentation files to instruct GitHub Copilot agent mode
- GitHub Copilot agent mode features:​
  - Autonomous operation
  - Multi-Step tasks
  - Tools for task completion
  - Iteration and self-healing
  - User control and review
  - Context management
  - Undo and redo
  - Interrupting requests
  - Limitations

## Session Key technologies

- GitHub
- Github Pull requests
- GitHub Copilot
  - Inline suggestions
  - Chat
  - Edits
  - Pull request summaries/outlines
  - Agent mode
- Angular
- NET
- SQLite
