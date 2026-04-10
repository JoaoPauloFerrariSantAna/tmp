using ConsoleApp2.Entities;
using ConsoleApp2.Enums;

namespace Billing.Domain.Entities
{
    public class Transacao
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DestinatarioTipo Destinatario { get; set; }
        public MetodoPagamento? MetodoPagamento { get; set; }
        public ContaBancaria? ContaBancaria { get; set; }
        public bool Validacao { get; set; }
    }
}
