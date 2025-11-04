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
dotnet new class --name Calculator
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

### Sketches

![Sketch from lecture](/docs/sketches/tdd-scientific-method-for-engineers.excalidraw.png)

## Uke 2 SOA

Pakke ned APIen i en container og sett den opp i et Docker Compose system, med ingress og database.

## Uke 3 IaC

Sett opp en server Hetzner og konfigurer den så den kjører Docker Compose manifestet.
