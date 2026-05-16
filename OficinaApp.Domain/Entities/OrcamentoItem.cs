

namespace OficinaApp.Domain.Entities {
    public class OrcamentoItem {

        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid OrcamentoId { get; set; }

        public Guid ServicoId { get; set; }

        public string Descricao { get; set; } = string.Empty;

        public int Quantidade { get; set; }

        public decimal ValorUnitario { get; set; } = 0;

        public decimal ValorTotal { get; set; }

        public void CalcularValorTotal() {

            ValorTotal = ValorUnitario * Quantidade;
        }
    }
}
