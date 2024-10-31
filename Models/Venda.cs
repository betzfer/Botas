using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Botas.Models
{
    public class Venda
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime SaleDate { get; set; }
        public int Quantity { get; set; }
        

        [ForeignKey ("ClienteId")]
        public Guid ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("BotaId")]
        public Guid BotaId { get; set; }
        public required Bota Bota { get; set; }
        public decimal TotalPrice => Quantity * (Bota?.Price ?? 0);
    }
}
