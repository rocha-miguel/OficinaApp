using OficinaApp.Domain.Entities;
using OficinaApp.Domain.Enums;

namespace OficinaApp.Domain.Interfaces.Services {
    public interface IOrdemServicoService : IBaseService<OrdemServico> {
        Task<OrdemServico?> ExibirPorOrcamentoIdAsync(Guid idOrcamento);

        Task<IEnumerable<OrdemServico>> ExibirPorVeiculoIdAsync(Guid idVeiculo);

        Task<IEnumerable<OrdemServico>> ExibirPorClienteIdAsync(Guid idCliente);

        Task<IEnumerable<OrdemServico>> ExibirPorStatusOrdemServicoAsync(
            StatusOrdemServico statusOrdemServico,
            int pageNumber,
            int pageSize
        );

        Task GerarPorOrcamentoAsync(Guid idOrcamento);

        Task IniciarAsync(Guid id);

        Task ConcluirAsync(Guid id);

        Task CancelarAsync(Guid id);
    }
}