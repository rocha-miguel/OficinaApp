

namespace OficinaApp.Domain.Entities {
    public class Veiculo : BaseEntity{

        public Guid ClienteId { get; set; }

        public string Placa { get; set; } = string.Empty;

        public string Marca { get; set; } = string.Empty;

        public string Modelo { get; set; } = string.Empty;

        public int Ano { get; set; } 

        public string Cor { get; set; } = string.Empty;

        public int Quilometragem { get; set; } = 0;


    }
}
