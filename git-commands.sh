#!/bin/bash

echo "=== Git Commands to Save Changes and Push to Remote ==="
echo ""
echo "Step 1: Check current status"
git status
echo ""

echo "Step 2: Add all changes to staging"
git add .
echo ""

echo "Step 3: Commit changes with descriptive message"
git commit -m "Complete Task 03 & 04: Database migration and local testing

- Database migration created and applied successfully
- 8 stocks seeded into database
- All API endpoints tested and verified
- GET, POST, DELETE operations working correctly
- Error handling validated (404, 400 status codes)
- CORS configuration verified
- Created comprehensive test completion report
- All tests passed (7/7 - 100% success rate)"
echo ""

echo "Step 4: Push to remote repository"
echo "Note: Replace 'origin' and 'master' if your remote/branch names differ"
echo ""
echo "If remote is already configured:"
git push origin master
echo ""

echo "If remote is NOT configured yet, run these commands first:"
echo "git remote add origin <your-remote-repository-url>"
echo "git push -u origin master"
echo ""

echo "=== Alternative: Manual Commands ==="
echo ""
echo "# Check status"
echo "git status"
echo ""
echo "# Stage all changes"
echo "git add ."
echo ""
echo "# Commit with message"
echo "git commit -m \"Complete Task 03 & 04: Database migration and local testing\""
echo ""
echo "# Configure remote (if not already done)"
echo "git remote add origin <your-remote-repository-url>"
echo ""
echo "# Push to remote"
echo "git push -u origin master"
echo ""
echo "=== End of Git Commands ==="
