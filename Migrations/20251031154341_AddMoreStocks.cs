using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StockMarketAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreStocks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "Code", "Favorite", "Name", "PreviousPrice", "Price" },
                values: new object[] { "GOOGL", false, "Alphabet Inc.", 140.2m, 138.65m });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "Code", "Name", "PreviousPrice", "Price" },
                values: new object[] { "META", "Meta Platforms Inc.", 318.75m, 325.4m });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "Code", "Favorite", "Name", "PreviousPrice", "Price" },
                values: new object[] { "NVDA", true, "NVIDIA Corporation", 478.9m, 485.2m });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "Code", "Name", "PreviousPrice", "Price" },
                values: new object[] { "TSLA", "Tesla Inc.", 238.75m, 242.50m });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "Code", "Exchange", "Favorite", "Name", "PreviousPrice", "Price" },
                values: new object[,]
                {
                    { "1", "AAPL", "NASDAQ", true, "Apple Inc.", 175.20m, 178.50m },
                    { "11", "WMT", "NYSE", false, "Walmart Inc.", 163.80m, 165.30m },
                    { "12", "PG", "NYSE", false, "Procter & Gamble Co.", 151.20m, 152.40m },
                    { "13", "UNH", "NYSE", false, "UnitedHealth Group Inc.", 525.30m, 528.90m },
                    { "14", "BAC", "NYSE", false, "Bank of America Corp.", 34.20m, 34.85m },
                    { "15", "KO", "NYSE", false, "Coca-Cola Company", 62.10m, 62.75m },
                    { "16", "INTC", "NASDAQ", false, "Intel Corporation", 44.80m, 45.20m },
                    { "17", "NFLX", "NASDAQ", true, "Netflix Inc.", 478.30m, 485.60m },
                    { "18", "ADBE", "NASDAQ", false, "Adobe Inc.", 558.90m, 562.40m },
                    { "19", "CRM", "NYSE", false, "Salesforce Inc.", 282.40m, 285.70m },
                    { "20", "PYPL", "NASDAQ", false, "PayPal Holdings Inc.", 67.50m, 68.90m },
                    { "3", "AMZN", "NASDAQ", true, "Amazon.com Inc.", 142.9m, 145.25m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "Code", "Favorite", "Name", "PreviousPrice", "Price" },
                values: new object[] { "AMZN", true, "Amazon.com Inc.", 142.9m, 145.25m });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "Code", "Name", "PreviousPrice", "Price" },
                values: new object[] { "GOOGL", "Alphabet Inc.", 140.2m, 138.65m });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "Code", "Favorite", "Name", "PreviousPrice", "Price" },
                values: new object[] { "META", false, "Meta Platforms Inc.", 318.75m, 325.4m });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "Code", "Name", "PreviousPrice", "Price" },
                values: new object[] { "NVDA", "NVIDIA Corporation", 478.9m, 485.2m });
        }
    }
}
