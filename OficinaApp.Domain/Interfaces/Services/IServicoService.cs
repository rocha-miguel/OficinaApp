using OficinaApp.Domain.Entities;

namespace OficinaApp.Domain.Interfaces.Services {
    public interface IServicoService : IBaseService<Servico> {
        Task<Servico?> ExibirPorNomeAsync(string nome);

        Task ValidarNomeUnicoAsync(string nome);
    }
}