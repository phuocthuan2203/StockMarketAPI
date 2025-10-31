# Task 01: Project Setup and Configuration

## Objective
Set up the ASP.NET Core project structure with proper configuration, dependencies, and database context for the Stock Market API.

## What We Will Achieve
- Configure project dependencies and NuGet packages
- Set up database connection (SQLite for development)
- Configure API to run on port 5001 (avoiding port 5000 conflict)
- Configure CORS for Angular frontend
- Set up proper JSON serialization settings

## What We Will Do

### 1. Install Required NuGet Packages
```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

### 2. Create Project Structure
```
StockMarketAPI/
├── Models/
│   └── Stock.cs
├── Data/
│   └── StockDbContext.cs
├── Controllers/
│   └── StocksController.cs
├── appsettings.json
└── Program.cs
```

### 3. Configure appsettings.json
- Set connection string for SQLite database
- Configure Kestrel to listen on port 5001 (0.0.0.0:5001)
- Set up logging levels

### 4. Update Program.cs
- Add DbContext with SQLite
- Configure CORS policy for Angular (http://localhost:4200)
- Configure JSON serialization (preserve property names)
- Add Swagger for API documentation
- Enable proper middleware pipeline

### 5. Create Stock Model
- Define Stock entity with proper data annotations
- Match frontend TypeScript interface exactly
- Use string for Id, decimal for prices
- Add validation attributes

### 6. Create Database Context
- Set up DbContext with Stocks DbSet
- Configure model relationships
- Add seed data (8 initial stocks from specification)

## Success Criteria
- Project builds without errors
- All dependencies installed correctly
- Configuration files properly set up
- Port 5001 configured and available
- CORS policy allows Angular frontend
- Database context ready for migrations

## Files to Create/Modify
- `Models/Stock.cs` (new)
- `Data/StockDbContext.cs` (new)
- `appsettings.json` (modify)
- `Program.cs` (modify)
- `StockMarketAPI.csproj` (modify via dotnet add)

## Testing Steps
1. Run `dotnet restore` - should complete without errors
2. Run `dotnet build` - should build successfully
3. Verify port 5001 is not in use: `ss -tuln | grep 5001`
4. Check all required packages are installed: `dotnet list package`

## Notes
- Using SQLite for simplicity in development
- Port 5001 chosen because port 5000 is already occupied on server
- CORS must allow localhost:4200 for Angular development
- JSON serialization must preserve PascalCase property names
