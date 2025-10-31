using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarketAPI.Models;

public class Stock
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = string.Empty;
    
    [Required]
    [StringLength(200)]
    public string Name { get; set; } = string.Empty;
    
    [Required]
    [StringLength(10)]
    public string Code { get; set; } = string.Empty;
    
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
    
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal PreviousPrice { get; set; }
    
    [Required]
    [StringLength(50)]
    public string Exchange { get; set; } = string.Empty;
    
    [Required]
    public bool Favorite { get; set; }
}
