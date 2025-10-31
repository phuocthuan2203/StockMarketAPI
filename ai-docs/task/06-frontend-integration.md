# Task 06: Frontend Integration

## Objective
Update the Angular frontend to connect to the new ASP.NET Core backend API and verify full end-to-end functionality.

## What We Will Achieve
- Angular app connected to new backend
- All CRUD operations working from UI
- Proper error handling in frontend
- Seamless user experience
- Production-ready integration

## What We Will Do

### 1. Update API URL in Angular Service

Modify `src/app/services/stock-service.ts`:

Change from:
```typescript
private apiUrl = 'http://localhost:3000/stocks';
```

To (for local testing):
```typescript
private apiUrl = 'http://localhost:5001/api/stocks';
```

Or (for production):
```typescript
private apiUrl = 'http://your-server-ip:5001/api/stocks';
```

### 2. Test Frontend Operations

#### View Stock List
- Navigate to stock list page
- Verify all stocks load correctly
- Check stock details display properly
- Verify favorite indicators work

#### View Stock Details
- Click on a stock to view details
- Verify all fields display correctly
- Check price change calculations
- Verify navigation works

#### Create New Stock
- Navigate to create stock page
- Fill in all required fields
- Submit form
- Verify stock appears in list
- Check success message

#### Delete Stock
- Select a stock to delete
- Confirm deletion
- Verify stock removed from list
- Check database updated

### 3. Test Error Scenarios

#### Network Errors
- Stop backend server
- Try to load stocks
- Verify error message displays
- Check graceful degradation

#### Validation Errors
- Try to create stock with missing fields
- Verify validation messages
- Check form validation works

#### Not Found Errors
- Try to access non-existent stock
- Verify 404 handling
- Check redirect behavior

### 4. Verify CORS Configuration
- Open browser DevTools
- Check Network tab
- Verify no CORS errors
- Confirm requests succeed

### 5. Test Cross-Browser Compatibility
- Test in Chrome
- Test in Firefox
- Test in Safari (if available)
- Test in Edge
- Verify consistent behavior

### 6. Performance Testing
- Load large stock list
- Check page load times
- Verify smooth scrolling
- Test rapid CRUD operations
- Monitor network requests

### 7. Update Environment Configuration

Create environment files if needed:

`src/environments/environment.ts` (development):
```typescript
export const environment = {
  production: false,
  apiUrl: 'http://localhost:5001/api/stocks'
};
```

`src/environments/environment.prod.ts` (production):
```typescript
export const environment = {
  production: true,
  apiUrl: 'http://your-server-ip:5001/api/stocks'
};
```

Update service to use environment:
```typescript
private apiUrl = environment.apiUrl;
```

## Success Criteria
- Angular app connects to backend successfully
- All CRUD operations work from UI
- No CORS errors in console
- Error messages display properly
- Loading states work correctly
- Data persists across page refreshes
- No console errors or warnings
- Smooth user experience

## Testing Checklist
- [ ] Stock list loads and displays correctly
- [ ] Stock details page shows all information
- [ ] Create stock form works and validates
- [ ] Delete stock removes from list and database
- [ ] Favorite toggle works (if implemented)
- [ ] Error messages display for failures
- [ ] Loading indicators show during requests
- [ ] No CORS errors in browser console
- [ ] Network requests use correct URLs
- [ ] Data persists after page refresh
- [ ] All HTTP status codes handled properly

## Files to Modify
- `src/app/services/stock-service.ts` (update apiUrl)
- `src/environments/environment.ts` (optional)
- `src/environments/environment.prod.ts` (optional)

## Testing Steps
1. Start backend: `dotnet run` (in API project)
2. Start frontend: `ng serve` (in Angular project)
3. Open browser: http://localhost:4200
4. Test all CRUD operations
5. Check browser console for errors
6. Verify Network tab shows successful requests
7. Test error scenarios
8. Verify data persistence

## Common Issues and Solutions

### CORS Errors
- Verify backend CORS policy includes http://localhost:4200
- Check backend is running on correct port
- Verify no typos in URLs

### 404 Errors
- Verify API URL is correct (includes /api/stocks)
- Check backend routes match frontend requests
- Verify port number is correct (5001 not 5000)

### Data Not Persisting
- Check backend database is writable
- Verify POST/DELETE requests complete successfully
- Check database file exists and is not locked

### Slow Performance
- Check network latency
- Verify database queries are optimized
- Check for unnecessary API calls
- Monitor backend logs for slow queries

## Notes
- Only one line needs to change in frontend (apiUrl)
- Test locally before deploying to production
- Update CORS policy for production domain
- Consider using environment variables for API URL
- Test with real network conditions (not just localhost)
- Verify mobile responsiveness if applicable
