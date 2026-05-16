
using OficinaApp.Domain.Enums;

namespace OficinaApp.Domain.Entities {
    public class BaseEntity {

        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime DataCadastro { get; set; } = DateTime.UtcNow.AddHours(-3);

        public DateTime? DataExclusao { get; set; }

        public Status Status { get; set; } = Status.Ativo;
    }
}
