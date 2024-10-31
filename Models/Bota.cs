using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Botas.Models
{
    public class Bota
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public ICollection<Bota>? StockQuantity { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }

        [ForeignKey("FornecedorId")]
        public Guid FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }
    }
}