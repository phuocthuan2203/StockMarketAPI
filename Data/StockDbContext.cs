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
                Id = "4",
                Name = "Amazon.com Inc.",
                Code = "AMZN",
                Price = 145.25m,
                PreviousPrice = 142.9m,
                Exchange = "NASDAQ",
                Favorite = true
            },
            new Stock
            {
                Id = "5",
                Name = "Alphabet Inc.",
                Code = "GOOGL",
                Price = 138.65m,
                PreviousPrice = 140.2m,
                Exchange = "NASDAQ",
                Favorite = false
            },
            new Stock
            {
                Id = "6",
                Name = "Meta Platforms Inc.",
                Code = "META",
                Price = 325.4m,
                PreviousPrice = 318.75m,
                Exchange = "NASDAQ",
                Favorite = false
            },
            new Stock
            {
                Id = "7",
                Name = "NVIDIA Corporation",
                Code = "NVDA",
                Price = 485.2m,
                PreviousPrice = 478.9m,
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
            }
        );
    }
}
