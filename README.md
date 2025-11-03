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

### Run all tests

```sh
dotnet test
```

## Uke 2 SOA

Pakke ned APIen i en container og sett den opp i et Docker Compose system, med ingress og database.

## Uke 3 IaC

Sett opp en server Hetzner og konfigurer den så den kjører Docker Compose manifestet.
