# Tasklist

- [ ] **Task 1**: Project Setup including a devcontainer.json
- [ ] **Task 2**: Configure the Web Api

# Task 1: Project Setup

```prompt
I want to create a project that uses the following services on a Windows host. The requirements are already installed on the machine, so Do not use && to chain commands
. The projects should be created in the src directory.

- .NET 9.0 Web API that uses Entity Framework Core and SQLit.
- Angular 19 App that acts as a frontend.

The .NET 9.0 Web API project should be created with the dotnet new webapi -n fitness-api command.

Create the .NET 9.0 Web API project (fitness-api) and the Angular 19 App project (fitness-ui). When creating the Angular Front use the angular cli with the ng new fitenss-ui --routing --style=scss --ssr=false command. After creating the Angular project, create angular environments using 'ng g environments' and add apiUrl to both environments. The apiUrl should be set to apiUrl="http://localhost:5000/"
```

- Add gitignore to the two projects reflecting their stack

- Add a .github/copilot-instructions.md file:

```markdown
# Code Instructions

## General

We write our code on a Windows Machine. Never use `&&` to chain commands. Always use separate commands.

## Angular

We are using Angular 19. Always use functional implementation where possible

## .NET

```

- Run and commit to the main branch.

- Explain Context. Mention that we will recycle the context soon. But before we will create a devcontainer.json file:

```prompt
to finalize the initial setup create a devcontainer.json that is capable of running Angular 19 with min node 20.12.2 and the .net 9 sdk. Please look at my installed extensions and add the Angular and .NET related extensions to the devcontainer. Include the GitHub CLI and make sure the post-create script to ensure appropriate permissions are set during container startup
```

- Run the devcontainer locally and using GitHub CodeSpaces

# Task 2: Configure the Web Api

```prompt
Set the http port to 5000 and the https port to 5001 in the launchSettings.json file. Make sure to set the environment variable ASPNETCORE_ENVIRONMENT to Development.
```

```prompt
Add support for entity framework and Sqlite. Create a FitnessDBContext and register it in Program.cs
```

```prompt
Next lets create a model for the fitness app:

Lets add a Student model with the following properties:

- Id (int, primary key)
- FirstName (string, required)
- LastName (string, required)
- DateOfBirth (DateTime, required)

Lets add an Exercise model with the following properties:

- Id (int, primary key)
- StudentId (int, foreign key to Student)
- Date (DateTime, required)
- Duration (int, required, in minutes)
- Comments (string, optional)

Register the models in the FitnessDBContext. Seed it with 3 sample students and 3 sample exercises for each student.
```

```prompt
Add an ExerciseController to the fitness-api project. The controller should have the following endpoints:

- Get /Students: Get all students
- GET /Students/{id}: Get a student by id
- GET /api/exercises: Get all exercises
- POST /api/exercises: Create a new exercise

Register the Controller in Program.cs to ensure it is available for dependency injection and routing. Inject the FitnessDBContext into the controller.
Make sure a Swagger UI is available for the API. In the Development environment the Swagger UI should be available at /.
```

```prompt
Add a REST Client test-controller.http to test the different methods of the controller
```
