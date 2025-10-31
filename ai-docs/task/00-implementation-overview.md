# Stock Market API - Implementation Overview

## Project Summary
Build an ASP.NET Core backend API to replace json-server for the Angular Stock Market application.

## Key Decisions

### Port Configuration
- **Selected Port**: 5001
- **Reason**: Port 5000 is already occupied on the server (confirmed in server-port.md)
- **Impact**: Angular frontend will connect to `http://server:5001/api/stocks`

### Database Choice
- **Selected**: SQLite
- **Reason**: Simple development setup, file-based, no separate server needed
- **Location**: `stockmarket.db` in project root

### Technology Stack
- ASP.NET Core 8.0
- Entity Framework Core
- SQLite Database
- Swagger/OpenAPI for documentation

## Task Breakdown

### Task 01: Project Setup and Configuration
**Duration**: ~30 minutes  
**Focus**: Dependencies, configuration, models, database context  
**Key Files**: Models/Stock.cs, Data/StockDbContext.cs, appsettings.json, Program.cs

### Task 02: API Implementation
**Duration**: ~45 minutes  
**Focus**: RESTful endpoints, CRUD operations, error handling  
**Key Files**: Controllers/StocksController.cs

### Task 03: Database Migration and Seeding
**Duration**: ~20 minutes  
**Focus**: EF migrations, database creation, seed data  
**Key Files**: Migrations folder, stockmarket.db

### Task 04: Local Testing
**Duration**: ~30 minutes  
**Focus**: Endpoint testing, Swagger UI, curl commands, validation  
**Key Tools**: Swagger, curl, browser DevTools

### Task 05: Deployment Configuration
**Duration**: ~45 minutes  
**Focus**: Production config, systemd service, firewall, security  
**Key Files**: appsettings.Production.json, systemd service file

### Task 06: Frontend Integration
**Duration**: ~30 minutes  
**Focus**: Connect Angular app, end-to-end testing, verification  
**Key Files**: Angular stock-service.ts

## Total Estimated Time
~3.5 hours for complete implementation and testing

## API Endpoints
```
GET    /api/stocks      - Get all stocks
GET    /api/stocks/{id} - Get single stock by ID
POST   /api/stocks      - Create new stock
DELETE /api/stocks/{id} - Delete stock by ID
```

## Success Criteria
- All endpoints working correctly
- Database persisting data
- CORS configured for Angular
- Deployed on Fedora server
- Angular frontend integrated
- No port conflicts

## Dependencies Between Tasks
1. Task 01 must complete before Task 02
2. Task 02 must complete before Task 03
3. Task 03 must complete before Task 04
4. Task 04 should complete before Task 05
5. Task 05 must complete before Task 06

## Critical Notes
- Port 5001 used (5000 is occupied)
- CORS must allow http://localhost:4200
- JSON property names must match frontend exactly
- String type for ID field
- Decimal type for price fields
- Async/await for all database operations

## Next Steps
Start with Task 01: Project Setup and Configuration
