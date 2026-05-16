

using OficinaApp.Domain.Enums;

namespace OficinaApp.Domain.Entities {
    public class Orcamento : BaseEntity{

        public Guid ClienteId { get; set; }

        public Guid VeiculoId { get; set; }

        public StatusOrcamento StatusOrcamento { get; set; } = StatusOrcamento.Pendente;

        public decimal ValorTotal { get; set; } = 0;

        public string? Observacao { get; set; }

        public DateOnly DataValidade { get; set; }

        public DateTime? DataAprovacao { get; set; }

        public List<OrcamentoItem> Servicos { get; set; }

    }
}
