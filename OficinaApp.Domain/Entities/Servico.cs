

namespace OficinaApp.Domain.Entities {
    public class Servico : BaseEntity{

        public string Nome { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;

        public decimal ValorBase { get; set; } = 0;

    }
}
