

using OficinaApp.Domain.Entities;
using OficinaApp.Domain.Enums;

namespace OficinaApp.Domain.Interfaces.Repositories {
    public interface IOrcamentoRepository : IBaseRepository<Orcamento> {

        Task<IEnumerable<Orcamento>> ExibirPorStatusOrcamentoAsync(int pageNumber, int pageSize, StatusOrcamento statusOrcamento);

        Task<Orcamento?> ExibirComItensPorIdAsync(Guid id);

        Task<IEnumerable<Orcamento>> ExibirPorClienteIdAsync(Guid clienteId);

        Task<IEnumerable<Orcamento>> ExibirPorVeiculoIdAsync(Guid veiculoId);
    }
}
