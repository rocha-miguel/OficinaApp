using OficinaApp.Domain.Entities;

namespace OficinaApp.Domain.Interfaces.Services {
    public interface IVeiculoService : IBaseService<Veiculo> {
        Task<Veiculo?> ExibirPorPlacaAsync(string placa);

        Task<IEnumerable<Veiculo>> ExibirPorClienteIdAsync(Guid clienteId, int pageNumber, int pageSize);

        Task ValidarPlacaUnicaAsync(string placa);

        Task ValidarClienteExisteAsync(Guid clienteId);
    }
}