# Backend Advanced

## Uke 1 TDD

Sett opp en .NET API via Test Dreven Utvikling.

### Setup Test project

```sh
# Initialize solution
dotnet new sln -n TddIntro
# Add new test project
dotnet new xunit -n TddIntro.Tests
# Add test project to solution
dotnet sln add TddIntro.Tests
```

### Add new project and connect them

```sh
# Add new project (class)
dotnet new classlib --name Calculator
# Add class as dependency of Test project
dotnet add TddIntro.Tests reference Calculator
```

### Run all tests

```sh
dotnet test
```

**Reference in test module**:
```csharp
// Poor naming, but shows how you reference <Namespace>.<ClassName>.
var calc = new Calculator.Calculator();
```

```csharp
// Using statements "strips" the need for namespace specifiers.
using Calculator;

var calc = new Calculator();
```

## Game Platform Services

![Inital sketch of Game Platform](/docs/sketches/game-platform.excalidraw.png)

### Setting up Web Server Tests

1. Setup Commands

    ```sh
    # Create web API project
    dotnet new web --name PlayerScoreApi
    dotnet add PlayerScoreApi reference PlayerScoreService
    # Create dedicated E2E tests
    dotnet new xunit --name PlayerScoreService.E2E
    dotnet add PlayerScoreService.E2E reference PlayerScoreApi
    # Add everything to the solution
    dotnet sln add PlayerScoreApi
    dotnet sln add PlayerScoreService.E2E
    ```

2. Vi trenger en liten ekstra pakke fra [nuget.org](https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Testing) som hjelper å teste REST/MVC APIer

    ```sh
    dotnet add PlayerScoreService.E2E package Microsoft.AspNetCore.Mvc.Testing
    ```

### Sketches

![Sketch from first lecture](/docs/sketches/tdd-scientific-method-for-engineers.excalidraw.png)
![Sketch from contract lecture](/docs/sketches/testing-av-kontrakter.excalidraw.png)

## Uke 2 SOA

Pakke ned APIen i en container og sett den opp i et Docker Compose system, med ingress og database.

> [!NOTE]
>
> Run the local Docker Tutorial
>
> ```sh
> docker run -p 80:80 docker/getting-started
> ```

### Hvordan sette sammen ett .NET prosjekt

> [!NOTE]
>
> Mange av disse kommandoen har en hel rekke med flag som du kan sende inn. De fleste er for mer komplekse scenarior og ikke noe vi trenger å tenke på her. Viss du er usikker på noen av disse, så husk at du kan få en kort oversikt ved hjelp av:
>
> ```sh
> dotnet <sub-command> --help
> ```

- Regenerer `obj` mappen og de midlertidige filene som er der

    ```sh
    dotnet restore
    ```

- Bygg/Kompiler kildekoden til et prosjekt via den optimaliserte Release konfigurasjonen.

    ```sh
    dotnet build --configuration Release
    ```

- Sett sammen alle filen og putt de i en mappe

    ```sh
    dotnet publish <project> --configuration Release --output <output-sti>
    ```

### [Microsoft - Containerize a .NET API](https://learn.microsoft.com/en-us/dotnet/core/docker/build-container?tabs=windows&pivots=dotnet-9-0)

### Docker commands cheat sheet

- Build a local Dockerfile

    ```sh
    docker build --tag <app-identifier> .
    ```

- Run a local container, exposing the ports

    ```sh
    docker run --publish 8080:8080 <app-identifier>
    ```

## Uke 3 IaC

Sett opp en server Hetzner og konfigurer den så den kjører Docker Compose manifestet.
