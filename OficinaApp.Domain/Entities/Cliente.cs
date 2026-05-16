
using OficinaApp.Domain.Enums;

namespace OficinaApp.Domain.Entities {
    public class Cliente : BaseEntity{

        public string Nome { get; set; } = string.Empty;

        public string Documento { get; set; } = string.Empty;

        public string Telefone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public TipoCliente TipoCliente { get; set; }

        public List<Veiculo> Veiculos { get; set; } = [];

    }
}
