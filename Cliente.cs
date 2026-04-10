using Jwt.ValueObjects;

namespace Billing.Domain.Entities
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public Carteira Carteira { get; set; }

        public void Deposit(decimal amount)
        {
            this.Carteira.Saldo += amount;
        }
    }
}
