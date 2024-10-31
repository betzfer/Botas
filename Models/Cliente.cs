using System.ComponentModel.DataAnnotations;

namespace Botas.Models
{
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string CPF { get;set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public bool ClientStatus { get; set; }
        public List<Venda> PurchaseHistory { get; set; } = new List<Venda>();
    }
}