

using OficinaApp.Domain.Entities;
using OficinaApp.Domain.Enums;

namespace OficinaApp.Domain.Interfaces.Services {
    public interface IOrcamentoService : IBaseService<Orcamento> {
        Task<IEnumerable<Orcamento>> ExibirPorStatusOrcamentoAsync(
            int pageNumber,
            int pageSize,
            StatusOrcamento statusOrcamento
        );

        Task<Orcamento?> ExibirComItensPorIdAsync(Guid id);

        Task<IEnumerable<Orcamento>> ExibirPorClienteIdAsync(Guid clienteId);

        Task<IEnumerable<Orcamento>> ExibirPorVeiculoIdAsync(Guid veiculoId);

        Task AprovarAsync(Guid id);

        Task ReprovarAsync(Guid id);

        Task CancelarAsync(Guid id);

        Task ExpirarAsync(Guid id);
    }
}
