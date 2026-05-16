

using OficinaApp.Domain.Entities;

namespace OficinaApp.Domain.Interfaces.Repositories {
    public interface IVeiculoRepository : IBaseRepository<Veiculo> {

        Task<Veiculo?> ExibirPorPlacaAsync(string placa);

        Task<bool> ExistePlacaAsync(string placa);

        Task<IEnumerable<Veiculo>> ExibirPorClienteIdAsync(Guid clienteId, int pageNumber, int pageSize);

        
    }
}
