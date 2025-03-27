# Tasklist

- [ ] **Task 1**: Project Setup
- [ ] **Task 2**: Create a devcontainer.json file in the root of the project.
- [ ] **Task 3**: Create the base pages.

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
