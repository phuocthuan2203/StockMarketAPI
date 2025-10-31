using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StockMarketAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Code = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PreviousPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Exchange = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Favorite = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "Code", "Exchange", "Favorite", "Name", "PreviousPrice", "Price" },
                values: new object[,]
                {
                    { "10", "V", "NYSE", true, "Visa Inc.", 272.4m, 275.9m },
                    { "2", "MSFT", "NASDAQ", true, "Microsoft Corporation", 380.1m, 382.75m },
                    { "4", "AMZN", "NASDAQ", true, "Amazon.com Inc.", 142.9m, 145.25m },
                    { "5", "GOOGL", "NASDAQ", false, "Alphabet Inc.", 140.2m, 138.65m },
                    { "6", "META", "NASDAQ", false, "Meta Platforms Inc.", 318.75m, 325.4m },
                    { "7", "NVDA", "NASDAQ", true, "NVIDIA Corporation", 478.9m, 485.2m },
                    { "8", "JPM", "NYSE", false, "JPMorgan Chase & Co.", 160.45m, 158.3m },
                    { "9", "JNJ", "NYSE", false, "Johnson & Johnson", 161.2m, 162.85m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks");
        }
    }
}
