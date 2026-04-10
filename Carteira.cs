using ConsoleApp2.Entities;

namespace Billing.Domain.Entities
{
    public class Carteira
    {
        public decimal Saldo { get; set; }
        public List<ContaBancaria> ContaBancarias { get; set; }
    }
}
