# Copilot Instructions for AI Coding Agents

## Project Overview
This is a .NET console application for managing technical information and digital products, structured as a simple C# project. The main files are:
- `Program.cs`: Entry point, orchestrates application logic.
- `InformacaoTecnica.cs`: Defines technical information model/class.
- `ProdutoDigital.cs`: Defines digital product model/class.
- `LojaInfo.csproj`: Project configuration and dependencies.

## Architecture & Data Flow
- The application is monolithic, with all logic in a single project.
- Data models (`InformacaoTecnica`, `ProdutoDigital`) are plain C# classes, used directly in `Program.cs`.
- There are no external service boundaries or complex data flows; all operations are in-memory.

## Developer Workflows
- **Build:** Use `dotnet build` in the project root (`LojaInfo/`).
- **Run:** Use `dotnet run` in the project root.
- **Debug:** Standard .NET debugging tools apply; no custom launch configurations.
- **Test:** No test files detected. If adding tests, follow standard .NET conventions (e.g., create a `Tests/` folder and use xUnit or NUnit).

## Project-Specific Conventions
- All source files are in the project root (`LojaInfo/`).
- No custom code generation, build scripts, or non-standard conventions detected.
- Naming follows C# PascalCase for classes and methods.

## Integration Points & Dependencies
- No external dependencies beyond those specified in `LojaInfo.csproj`.
- No database, web API, or third-party integrations.
- No configuration files beyond `.csproj`.

## Patterns & Examples
- Models are simple POCOs (Plain Old CLR Objects).
- Main logic is in `Program.cs`, which instantiates and manipulates model objects.
- Example usage:
  ```csharp
  var produto = new ProdutoDigital(...);
  var info = new InformacaoTecnica(...);
  // ... use these objects in Program.cs
  ```

## Key Files
- `Program.cs`: Main logic and entry point.
- `InformacaoTecnica.cs`, `ProdutoDigital.cs`: Data models.
- `LojaInfo.csproj`: Project configuration.

## How to Extend
- Add new models as separate `.cs` files in the project root.
- Add new logic to `Program.cs` or refactor into new classes as needed.
- If introducing tests, create a `Tests/` directory and use standard .NET test frameworks.

---

For questions about project structure or conventions, review the above files or ask for clarification.
