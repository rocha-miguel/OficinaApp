

using OficinaApp.Domain.Enums;

namespace OficinaApp.Domain.Entities {
    public class OrdemServico : BaseEntity{

        public Guid OrcamentoId { get; set; }

        public Guid ClienteId { get; set; }

        public Guid VeiculoId { get; set; }

        public StatusOrdemServico StatusOrdemServico { get; set; } = StatusOrdemServico.Aberta;

        public string Observacao { get; set; } = string.Empty;

        public DateTime? DataInicio { get; set; }

        public DateTime? DataConclusao { get; set; }

        public decimal ValorTotal { get; set; } = 0;


    }
}
