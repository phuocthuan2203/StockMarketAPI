# Task 05: Docker Deployment Configuration

## Objective
Containerize the Stock Market API using Docker and deploy to Fedora server via GitHub repository with proper security, container management, and monitoring.

## What We Will Achieve
- Dockerized application with multi-stage build
- Production-ready Docker configuration
- Docker Compose for container orchestration
- GitHub repository integration
- Server deployment via SSH and git clone
- Container auto-restart and health checks
- Logging and monitoring setup
- Security hardening

## Deployment Strategy
1. Containerize application with Docker
2. Push to GitHub repository
3. SSH to Fedora server
4. Clone repository on server
5. Build and run Docker containers
6. Configure firewall and networking
7. Set up monitoring and logging

## What We Will Do

### 1. Create Dockerfile (Multi-stage Build)

Create `Dockerfile` in project root:
- Stage 1: Build application
- Stage 2: Runtime container
- Optimize image size
- Configure ASP.NET Core for production
- Set up proper user permissions

### 2. Create Docker Compose Configuration

Create `docker-compose.yml`:
- Define API service
- Configure port mapping (5001:8080)
- Set environment variables
- Configure volumes for database persistence
- Set restart policy
- Configure health checks

### 3. Create .dockerignore

Create `.dockerignore`:
- Exclude build artifacts
- Exclude development files
- Exclude git files
- Reduce image size

### 4. Create Production Configuration

Create `appsettings.Production.json`:
- Disable detailed error messages
- Configure production logging
- Set production CORS policy
- Configure connection string from environment

### 5. Prepare GitHub Repository

```bash
git add .
git commit -m "Add Docker configuration for deployment"
git push origin main
```

Ensure repository contains:
- Dockerfile
- docker-compose.yml
- .dockerignore
- appsettings.Production.json
- All source code

### 6. Server Deployment Steps

#### 6.1 SSH to Server
```bash
ssh user@your-fedora-server
```

#### 6.2 Install Docker (if not installed)
```bash
sudo dnf install docker docker-compose
sudo systemctl enable docker
sudo systemctl start docker
sudo usermod -aG docker $USER
```

#### 6.3 Clone Repository
```bash
cd /opt
sudo mkdir -p stockmarket-api
sudo chown $USER:$USER stockmarket-api
cd stockmarket-api
git clone https://github.com/your-username/StockMarketAPI.git .
```

#### 6.4 Build Docker Image
```bash
docker build -t stockmarket-api:latest .
```

#### 6.5 Run with Docker Compose
```bash
docker-compose up -d
```

### 7. Configure Firewall
```bash
sudo firewall-cmd --permanent --add-port=5001/tcp
sudo firewall-cmd --reload
```

### 8. Set Up Container Auto-restart

Docker Compose restart policy ensures:
- Container restarts on failure
- Container starts on system boot
- Automatic recovery from crashes

### 9. Configure Logging

Docker logging:
- Container logs: `docker logs stockmarket-api`
- Follow logs: `docker logs -f stockmarket-api`
- Log rotation configured in docker-compose.yml

## Success Criteria
- Dockerfile builds without errors
- Docker image created successfully
- Container runs and API is accessible
- API accessible from external network on port 5001
- Container auto-restarts on failure
- Logs available via docker logs
- Production configuration active
- Database persists across container restarts

## Files to Create
- `Dockerfile` (new)
- `docker-compose.yml` (new)
- `.dockerignore` (new)
- `appsettings.Production.json` (new)

## Deployment Workflow

### Local Development
1. Create Docker configuration files
2. Test Docker build locally
3. Test container locally
4. Commit and push to GitHub

### Server Deployment
1. SSH to Fedora server
2. Clone repository from GitHub
3. Build Docker image
4. Run container with docker-compose
5. Configure firewall
6. Test API endpoints

### Updates and Redeployment
```bash
cd /opt/stockmarket-api
git pull origin main
docker-compose down
docker build -t stockmarket-api:latest .
docker-compose up -d
```

## Docker Commands Reference

### Build and Run
```bash
docker build -t stockmarket-api:latest .
docker-compose up -d
docker-compose down
docker-compose restart
```

### Monitoring
```bash
docker ps
docker stats stockmarket-api
docker logs stockmarket-api
docker logs -f stockmarket-api
docker inspect stockmarket-api
```

### Maintenance
```bash
docker exec -it stockmarket-api /bin/bash
docker-compose pull
docker system prune -a
```

## Security Considerations
- Run container as non-root user
- Use multi-stage build to minimize image size
- Configure CORS for specific origins only
- Use environment variables for sensitive data
- Implement rate limiting
- Enable request logging
- Set up monitoring and alerts
- Keep base images updated
- Scan images for vulnerabilities

## Testing Steps
1. Build image: `docker build -t stockmarket-api:latest .`
2. Run container: `docker-compose up -d`
3. Check status: `docker ps`
4. Check logs: `docker logs stockmarket-api`
5. Test API: `curl http://localhost:5001/api/stocks`
6. Test from external: `curl http://server-ip:5001/api/stocks`
7. Verify firewall: `sudo firewall-cmd --list-ports`
8. Test auto-restart: `docker restart stockmarket-api`
9. Test from Angular app: Update apiUrl and test

## Monitoring
- Container status: `docker ps`
- Container stats: `docker stats`
- Container logs: `docker logs -f stockmarket-api`
- Health checks via Docker
- Monitor API response times
- Monitor database size
- Check disk space usage
- Monitor memory and CPU usage

## Volume Management
- Database file persisted in Docker volume
- Volume survives container restarts
- Backup volume regularly
- Volume location: `/var/lib/docker/volumes/`

## Notes
- Port 5001 exposed for API access
- Container internal port: 8080
- SQLite database persisted in volume
- Environment variables in docker-compose.yml
- Update Angular frontend apiUrl to point to server:5001
- Test CORS from Angular app after deployment
- Keep Docker configuration in version control
- Use .env file for sensitive environment variables
