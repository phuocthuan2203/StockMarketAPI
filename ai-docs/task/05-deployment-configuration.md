# Task 05: Deployment Configuration

## Objective
Configure the application for production deployment on Fedora server with proper security, service management, and monitoring.

## What We Will Achieve
- Production-ready configuration
- Systemd service for auto-start
- Firewall configuration
- Environment-specific settings
- Logging and monitoring setup
- Security hardening

## What We Will Do

### 1. Create Production Configuration

#### Update appsettings.Production.json
Create new file with production settings:
- Disable detailed error messages
- Configure production logging
- Set production CORS policy
- Configure connection string from environment

### 2. Publish Application
```bash
dotnet publish -c Release -o ./publish
```

This creates:
- Optimized binaries
- Trimmed dependencies
- Production-ready DLL
- All required files in publish folder

### 3. Create Systemd Service File

Create `/etc/systemd/system/stockmarket-api.service`:
- Set working directory
- Configure auto-restart
- Set environment variables
- Configure user permissions
- Enable logging to journald

### 4. Configure Firewall
```bash
sudo firewall-cmd --permanent --add-port=5001/tcp
sudo firewall-cmd --reload
```

Allow external access to API port 5001

### 5. Set Up Application Directory
```bash
sudo mkdir -p /var/www/stockmarket-api
sudo chown -R $USER:$USER /var/www/stockmarket-api
```

Copy published files to deployment directory

### 6. Configure Environment Variables
Set production environment:
- ASPNETCORE_ENVIRONMENT=Production
- Database connection string
- CORS allowed origins
- Logging levels

### 7. Set Up Reverse Proxy (Optional)

Configure Nginx to proxy requests:
- Listen on port 80/443
- Forward to localhost:5001
- Add SSL/TLS if needed
- Configure request headers

### 8. Configure Logging
- Set up file logging
- Configure log rotation
- Set appropriate log levels
- Enable structured logging

## Success Criteria
- Application publishes without errors
- Systemd service starts successfully
- API accessible from external network
- Firewall allows traffic on port 5001
- Service auto-starts on server reboot
- Logs available in journald
- Production configuration active

## Files to Create/Modify
- `appsettings.Production.json` (new)
- `/etc/systemd/system/stockmarket-api.service` (new)
- Firewall rules (modify)
- `/var/www/stockmarket-api/` (new directory)

## Deployment Steps
1. Publish application locally
2. Transfer files to server
3. Create systemd service
4. Configure firewall
5. Start and enable service
6. Verify service status
7. Test API endpoints from external client

## Systemd Service Commands
```bash
sudo systemctl daemon-reload
sudo systemctl enable stockmarket-api
sudo systemctl start stockmarket-api
sudo systemctl status stockmarket-api
sudo journalctl -u stockmarket-api -f
```

## Security Considerations
- Run service as non-root user
- Restrict file permissions
- Configure CORS for specific origins only
- Use HTTPS in production (via reverse proxy)
- Implement rate limiting
- Enable request logging
- Set up monitoring and alerts

## Testing Steps
1. Verify service starts: `sudo systemctl status stockmarket-api`
2. Check logs: `sudo journalctl -u stockmarket-api -n 50`
3. Test API: `curl http://server-ip:5001/api/stocks`
4. Verify firewall: `sudo firewall-cmd --list-ports`
5. Test auto-restart: `sudo systemctl restart stockmarket-api`
6. Test from Angular app: Update apiUrl and test

## Monitoring
- Check service status regularly
- Monitor logs for errors
- Track API response times
- Monitor database size
- Check disk space usage
- Monitor memory and CPU usage

## Notes
- Port 5001 used instead of 5000 (occupied)
- SQLite database file must be writable by service user
- Consider database backups for production
- Update Angular frontend apiUrl to point to server:5001
- Test CORS from Angular app after deployment
- Keep systemd service file in version control
