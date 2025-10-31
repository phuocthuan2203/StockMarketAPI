using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockMarketAPI.Data;
using StockMarketAPI.Models;

namespace StockMarketAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StocksController : ControllerBase
{
    private readonly StockDbContext _context;

    public StocksController(StockDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Stock>>> GetStocks()
    {
        return await _context.Stocks.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Stock>> GetStock(string id)
    {
        var stock = await _context.Stocks.FindAsync(id);

        if (stock == null)
        {
            return NotFound();
        }

        return stock;
    }

    [HttpPost]
    public async Task<ActionResult<Stock>> PostStock(Stock stock)
    {
        if (string.IsNullOrEmpty(stock.Id))
        {
            stock.Id = Guid.NewGuid().ToString();
        }

        _context.Stocks.Add(stock);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetStock), new { id = stock.Id }, stock);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStock(string id)
    {
        var stock = await _context.Stocks.FindAsync(id);
        if (stock == null)
        {
            return NotFound();
        }

        _context.Stocks.Remove(stock);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
