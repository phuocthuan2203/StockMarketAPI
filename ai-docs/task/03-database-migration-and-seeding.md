# Task 03: Database Migration and Seeding

## Objective
Create and apply Entity Framework Core migrations to set up the database schema and seed initial stock data.

## What We Will Achieve
- Database schema created from Stock model
- Initial migration generated
- Database created with proper tables
- 8 sample stocks seeded into database
- Database ready for API operations

## What We Will Do

### 1. Create Initial Migration
```bash
dotnet ef migrations add InitialCreate
```

This will:
- Analyze Stock model and DbContext
- Generate migration files in Migrations folder
- Create Up() and Down() methods for schema changes
- Include seed data from OnModelCreating

### 2. Review Migration Files
Check generated migration:
- Verify Stocks table structure
- Confirm column types (Id as string, Price as decimal)
- Verify seed data is included
- Check constraints and indexes

### 3. Apply Migration to Database
```bash
dotnet ef database update
```

This will:
- Create stockmarket.db file (SQLite)
- Execute migration Up() method
- Create Stocks table
- Insert 8 seed records
- Update __EFMigrationsHistory table

### 4. Verify Database Creation
- Check stockmarket.db file exists in project root
- Verify database schema using SQLite browser or CLI
- Confirm 8 stock records are present
- Validate data types and constraints

### 5. Test Database Connectivity
- Run application briefly to test connection
- Verify DbContext can connect
- Check no connection errors in logs

## Success Criteria
- Migration files created successfully
- Database file (stockmarket.db) exists
- Stocks table created with correct schema
- 8 seed records inserted
- No migration errors
- Database accessible by application

## Files Created
- `Migrations/{timestamp}_InitialCreate.cs`
- `Migrations/{timestamp}_InitialCreate.Designer.cs`
- `Migrations/StockDbContextModelSnapshot.cs`
- `stockmarket.db` (SQLite database file)

## Seed Data Records
1. Microsoft Corporation (MSFT) - $382.75
2. Amazon.com Inc. (AMZN) - $145.25
3. Alphabet Inc. (GOOGL) - $138.65
4. Meta Platforms Inc. (META) - $325.40
5. NVIDIA Corporation (NVDA) - $485.20
6. JPMorgan Chase & Co. (JPM) - $158.30
7. Johnson & Johnson (JNJ) - $162.85
8. Visa Inc. (V) - $275.90

## Testing Steps
1. Run migration: `dotnet ef migrations add InitialCreate`
2. Check Migrations folder created
3. Apply migration: `dotnet ef database update`
4. Verify database file: `ls -la stockmarket.db`
5. Query database: `sqlite3 stockmarket.db "SELECT COUNT(*) FROM Stocks;"`
6. Should return: 8

## Troubleshooting
- If migration fails, check DbContext configuration
- If seed data missing, verify OnModelCreating method
- If database locked, ensure no other process is using it
- If connection fails, check connection string in appsettings.json

## Notes
- SQLite database file will be in project root
- Add stockmarket.db to .gitignore
- Seed data IDs are strings ("2", "4", "5", etc.) to match frontend
- Decimal type used for prices to ensure precision
- Migration can be rolled back with: `dotnet ef database update 0`
