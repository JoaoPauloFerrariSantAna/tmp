using ConsoleApp2.Enums;

namespace Billing.Domain.Entities
{
    public class Cartao : Carteira
    {
        public TipoCartao Tipo { get; set; }
        public string Numero { get; set; }
        public string CVV { get; set; }
        public DateOnly Validade { get; set; }
        public string NomeTitular { get; set; }

    }
}
