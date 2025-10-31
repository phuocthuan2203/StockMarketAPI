# Docker Deployment Guide

## Quick Start

### Local Development
```bash
docker compose up -d --build
```

API will be available at: `http://localhost:5001/api/stocks`

### Stop Container
```bash
docker compose down
```

## Server Deployment

### Prerequisites
- Docker and Docker Compose installed
- Git installed
- Firewall configured

### Installation Steps

#### 1. Install Docker (Fedora)
```bash
sudo dnf install docker docker-compose-plugin
sudo systemctl enable docker
sudo systemctl start docker
sudo usermod -aG docker $USER
```

#### 2. Clone Repository
```bash
cd /opt
sudo mkdir -p stockmarket-api
sudo chown $USER:$USER stockmarket-api
cd stockmarket-api
git clone https://github.com/your-username/StockMarketAPI.git .
```

#### 3. Build and Run
```bash
docker compose up -d --build
```

#### 4. Configure Firewall
```bash
sudo firewall-cmd --permanent --add-port=5001/tcp
sudo firewall-cmd --reload
```

#### 5. Verify
```bash
docker ps
docker logs stockmarket-api
curl http://localhost:5001/api/stocks
```

## Update Deployment

```bash
cd /opt/stockmarket-api
git pull origin main
docker compose down
docker compose up -d --build
```

## Useful Commands

### View Logs
```bash
docker logs stockmarket-api
docker logs -f stockmarket-api
```

### Check Status
```bash
docker ps
docker stats stockmarket-api
```

### Access Container
```bash
docker exec -it stockmarket-api /bin/bash
```

### Database Backup
```bash
docker exec stockmarket-api cat /app/data/stockmarket.db > backup.db
```

### Clean Up
```bash
docker compose down
docker system prune -a
```

## Configuration

### Environment Variables
Edit `docker-compose.yml` to add environment variables:
```yaml
environment:
  - ASPNETCORE_ENVIRONMENT=Production
  - ASPNETCORE_URLS=http://+:8080
```

### CORS Configuration
Edit `appsettings.Production.json`:
```json
{
  "AllowedOrigins": [
    "http://your-frontend-domain.com"
  ]
}
```

## Troubleshooting

### Container Won't Start
```bash
docker logs stockmarket-api
```

### Port Already in Use
```bash
sudo lsof -i :5001
docker compose down
```

### Database Issues
```bash
docker exec stockmarket-api ls -la /app/data/
docker volume inspect stockmarketapi_stockmarket-data
```

### Reset Everything
```bash
docker compose down -v
docker compose up -d --build
```
