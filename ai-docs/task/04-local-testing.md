# Task 04: Local Testing

## Objective
Thoroughly test all API endpoints locally to ensure they work correctly before deployment.

## What We Will Achieve
- All endpoints tested and working
- Proper response formats verified
- Error cases handled correctly
- CORS configuration validated
- API ready for integration with Angular frontend

## What We Will Do

### 1. Start the API Server
```bash
dotnet run
```

Expected output:
- API listening on http://0.0.0.0:5001
- Swagger UI available at http://localhost:5001/swagger
- No startup errors

### 2. Test with Swagger UI
Navigate to http://localhost:5001/swagger

Test each endpoint:
- GET /api/stocks - View all stocks
- GET /api/stocks/{id} - Get single stock (try ID "2")
- POST /api/stocks - Create new stock
- DELETE /api/stocks/{id} - Delete a stock

### 3. Test with curl Commands

#### Get All Stocks
```bash
curl -X GET http://localhost:5001/api/stocks \
  -H "Content-Type: application/json"
```

Expected: 200 OK, array of 8 stocks

#### Get Single Stock
```bash
curl -X GET http://localhost:5001/api/stocks/2 \
  -H "Content-Type: application/json"
```

Expected: 200 OK, Microsoft stock object

#### Create New Stock
```bash
curl -X POST http://localhost:5001/api/stocks \
  -H "Content-Type: application/json" \
  -d '{
    "name": "Tesla Inc.",
    "code": "TSLA",
    "price": 242.50,
    "previousPrice": 238.75,
    "exchange": "NASDAQ",
    "favorite": false
  }'
```

Expected: 201 Created, stock object with generated ID

#### Delete Stock
```bash
curl -X DELETE http://localhost:5001/api/stocks/2 \
  -H "Content-Type: application/json"
```

Expected: 204 No Content

### 4. Test Error Cases

#### Get Non-existent Stock
```bash
curl -X GET http://localhost:5001/api/stocks/999
```

Expected: 404 Not Found

#### Delete Non-existent Stock
```bash
curl -X DELETE http://localhost:5001/api/stocks/999
```

Expected: 404 Not Found

#### Create Invalid Stock (missing required fields)
```bash
curl -X POST http://localhost:5001/api/stocks \
  -H "Content-Type: application/json" \
  -d '{"name": "Invalid Stock"}'
```

Expected: 400 Bad Request with validation errors

### 5. Test CORS Configuration
```bash
curl -X OPTIONS http://localhost:5001/api/stocks \
  -H "Origin: http://localhost:4200" \
  -H "Access-Control-Request-Method: GET" \
  -v
```

Expected: CORS headers present in response

### 6. Verify Response Format
Check that responses match frontend expectations:
- Property names are correct (name, code, price, etc.)
- Data types are correct (string for id, number for price)
- Boolean values for favorite field
- Decimal precision for prices

### 7. Performance Testing
- Test with multiple concurrent requests
- Verify response times are acceptable
- Check database connection pooling works
- Monitor memory usage

## Success Criteria
- All endpoints return correct status codes
- Response JSON matches frontend expectations
- Error cases handled properly
- CORS allows Angular frontend
- No server errors or exceptions
- Database operations complete successfully
- Swagger UI works correctly

## Test Checklist
- [ ] GET /api/stocks returns 8 stocks
- [ ] GET /api/stocks/2 returns Microsoft stock
- [ ] POST /api/stocks creates new stock with ID
- [ ] DELETE /api/stocks/{id} removes stock
- [ ] GET /api/stocks/999 returns 404
- [ ] DELETE /api/stocks/999 returns 404
- [ ] Invalid POST returns 400
- [ ] CORS headers present for localhost:4200
- [ ] Swagger UI accessible and functional
- [ ] No errors in console logs

## Testing Tools
- Swagger UI: http://localhost:5001/swagger
- curl: Command-line HTTP client
- Postman: Optional GUI testing tool
- Browser DevTools: Network tab inspection

## Notes
- Test on port 5001 (not 5000 which is occupied)
- Keep server running during tests
- Check logs for any warnings or errors
- Verify database file updates after POST/DELETE
- Test from different terminal windows for concurrent requests
