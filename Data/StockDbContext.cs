using Microsoft.EntityFrameworkCore;
using StockMarketAPI.Models;

namespace StockMarketAPI.Data;

public class StockDbContext : DbContext
{
    public StockDbContext(DbContextOptions<StockDbContext> options)
        : base(options)
    {
    }

    public DbSet<Stock> Stocks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Stock>().HasData(
            new Stock
            {
                Id = "1",
                Name = "Apple Inc.",
                Code = "AAPL",
                Price = 178.50m,
                PreviousPrice = 175.20m,
                Exchange = "NASDAQ",
                Favorite = true
            },
            new Stock
            {
                Id = "2",
                Name = "Microsoft Corporation",
                Code = "MSFT",
                Price = 382.75m,
                PreviousPrice = 380.1m,
                Exchange = "NASDAQ",
                Favorite = true
            },
            new Stock
            {
                Id = "3",
                Name = "Amazon.com Inc.",
                Code = "AMZN",
                Price = 145.25m,
                PreviousPrice = 142.9m,
                Exchange = "NASDAQ",
                Favorite = true
            },
            new Stock
            {
                Id = "4",
                Name = "Alphabet Inc.",
                Code = "GOOGL",
                Price = 138.65m,
                PreviousPrice = 140.2m,
                Exchange = "NASDAQ",
                Favorite = false
            },
            new Stock
            {
                Id = "5",
                Name = "Meta Platforms Inc.",
                Code = "META",
                Price = 325.4m,
                PreviousPrice = 318.75m,
                Exchange = "NASDAQ",
                Favorite = false
            },
            new Stock
            {
                Id = "6",
                Name = "NVIDIA Corporation",
                Code = "NVDA",
                Price = 485.2m,
                PreviousPrice = 478.9m,
                Exchange = "NASDAQ",
                Favorite = true
            },
            new Stock
            {
                Id = "7",
                Name = "Tesla Inc.",
                Code = "TSLA",
                Price = 242.50m,
                PreviousPrice = 238.75m,
                Exchange = "NASDAQ",
                Favorite = true
            },
            new Stock
            {
                Id = "8",
                Name = "JPMorgan Chase & Co.",
                Code = "JPM",
                Price = 158.3m,
                PreviousPrice = 160.45m,
                Exchange = "NYSE",
                Favorite = false
            },
            new Stock
            {
                Id = "9",
                Name = "Johnson & Johnson",
                Code = "JNJ",
                Price = 162.85m,
                PreviousPrice = 161.2m,
                Exchange = "NYSE",
                Favorite = false
            },
            new Stock
            {
                Id = "10",
                Name = "Visa Inc.",
                Code = "V",
                Price = 275.9m,
                PreviousPrice = 272.4m,
                Exchange = "NYSE",
                Favorite = true
            },
            new Stock
            {
                Id = "11",
                Name = "Walmart Inc.",
                Code = "WMT",
                Price = 165.30m,
                PreviousPrice = 163.80m,
                Exchange = "NYSE",
                Favorite = false
            },
            new Stock
            {
                Id = "12",
                Name = "Procter & Gamble Co.",
                Code = "PG",
                Price = 152.40m,
                PreviousPrice = 151.20m,
                Exchange = "NYSE",
                Favorite = false
            },
            new Stock
            {
                Id = "13",
                Name = "UnitedHealth Group Inc.",
                Code = "UNH",
                Price = 528.90m,
                PreviousPrice = 525.30m,
                Exchange = "NYSE",
                Favorite = false
            },
            new Stock
            {
                Id = "14",
                Name = "Bank of America Corp.",
                Code = "BAC",
                Price = 34.85m,
                PreviousPrice = 34.20m,
                Exchange = "NYSE",
                Favorite = false
            },
            new Stock
            {
                Id = "15",
                Name = "Coca-Cola Company",
                Code = "KO",
                Price = 62.75m,
                PreviousPrice = 62.10m,
                Exchange = "NYSE",
                Favorite = false
            },
            new Stock
            {
                Id = "16",
                Name = "Intel Corporation",
                Code = "INTC",
                Price = 45.20m,
                PreviousPrice = 44.80m,
                Exchange = "NASDAQ",
                Favorite = false
            },
            new Stock
            {
                Id = "17",
                Name = "Netflix Inc.",
                Code = "NFLX",
                Price = 485.60m,
                PreviousPrice = 478.30m,
                Exchange = "NASDAQ",
                Favorite = true
            },
            new Stock
            {
                Id = "18",
                Name = "Adobe Inc.",
                Code = "ADBE",
                Price = 562.40m,
                PreviousPrice = 558.90m,
                Exchange = "NASDAQ",
                Favorite = false
            },
            new Stock
            {
                Id = "19",
                Name = "Salesforce Inc.",
                Code = "CRM",
                Price = 285.70m,
                PreviousPrice = 282.40m,
                Exchange = "NYSE",
                Favorite = false
            },
            new Stock
            {
                Id = "20",
                Name = "PayPal Holdings Inc.",
                Code = "PYPL",
                Price = 68.90m,
                PreviousPrice = 67.50m,
                Exchange = "NASDAQ",
                Favorite = false
            }
        );
    }
}
