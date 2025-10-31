# Task 02: API Implementation

## Objective
Implement the RESTful API endpoints that match the json-server behavior expected by the Angular frontend.

## What We Will Achieve
- Complete CRUD operations for stocks
- Proper HTTP status codes and responses
- Async/await pattern for all operations
- Error handling and validation
- API route matching frontend expectations

## What We Will Do

### 1. Create StocksController
Implement four endpoints:

#### GET /api/stocks
- Retrieve all stocks from database
- Return 200 OK with array of stocks
- Async operation using ToListAsync()

#### GET /api/stocks/{id}
- Retrieve single stock by ID
- Return 200 OK with stock object
- Return 404 Not Found if stock doesn't exist
- Accept string ID parameter

#### POST /api/stocks
- Create new stock
- Generate GUID for ID if not provided
- Return 201 Created with created stock
- Include Location header with new resource URL
- Validate required fields

#### DELETE /api/stocks/{id}
- Delete stock by ID
- Return 204 No Content on success
- Return 404 Not Found if stock doesn't exist
- Remove stock from database

### 2. Implement Error Handling
- Handle database exceptions
- Return appropriate error responses
- Log errors for debugging
- Validate input data

### 3. Add Data Validation
- Ensure required fields are present
- Validate price values are positive
- Validate stock code format
- Check for duplicate stock codes

### 4. Configure Route Attributes
- Use [Route("api/[controller]")] for base route
- Use [ApiController] for automatic model validation
- Use proper HTTP method attributes

## Success Criteria
- All four endpoints implemented correctly
- Proper async/await usage throughout
- Correct HTTP status codes returned
- Error handling in place
- Routes match frontend expectations (lowercase "stocks")
- Controller builds without errors

## Files to Create/Modify
- `Controllers/StocksController.cs` (new)

## Testing Steps
1. Build project: `dotnet build`
2. Verify controller compiles without errors
3. Check route attributes are correct
4. Verify async methods return proper Task types
5. Confirm error handling covers edge cases

## API Endpoint Summary
```
GET    /api/stocks      -> Get all stocks
GET    /api/stocks/{id} -> Get single stock
POST   /api/stocks      -> Create new stock
DELETE /api/stocks/{id} -> Delete stock
```

## Notes
- Route must be lowercase "stocks" to match frontend
- ID parameter must be string type
- Use FindAsync() for single record retrieval
- Use ToListAsync() for collection retrieval
- Generate GUID for new stock IDs
- Return CreatedAtAction for POST responses
