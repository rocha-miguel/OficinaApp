using OficinaApp.Domain.Entities;
using OficinaApp.Domain.Enums;

namespace OficinaApp.Domain.Interfaces.Repositories {
    public interface IOrdemServicoRepository : IBaseRepository<OrdemServico> {
        Task<OrdemServico?> ExibirPorOrcamentoIdAsync(Guid idOrcamento);

        Task<IEnumerable<OrdemServico>> ExibirPorVeiculoIdAsync(Guid idVeiculo);

        Task<IEnumerable<OrdemServico>> ExibirPorClienteIdAsync(Guid idCliente);

        Task<IEnumerable<OrdemServico>> ExibirPorStatusOrdemServicoAsync(StatusOrdemServico statusOrdemServico, int pageNumber, int pageSize);

        Task<bool> ExisteOrdemParaOrcamentoAsync(Guid idOrcamento);
    }
}