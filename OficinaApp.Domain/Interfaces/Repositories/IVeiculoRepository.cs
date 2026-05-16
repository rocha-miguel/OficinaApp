

using OficinaApp.Domain.Entities;

namespace OficinaApp.Domain.Interfaces.Repositories {
    public interface IVeiculoRepository : IBaseRepository<Veiculo> {

        Task<Veiculo?> ExibirPorPlaca(string placa);

        Task<bool> ExistePlaca(string placa);

        Task<IEnumerable<Veiculo>> ExibirPorClienteId(Guid clienteId, int pageNumber, int pageSize);

        
    }
}
