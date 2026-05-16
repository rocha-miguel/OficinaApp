

using OficinaApp.Domain.Entities;

namespace OficinaApp.Domain.Interfaces.Repositories {
    public interface IServicoRepository : IBaseRepository<Servico> {

        Task<Servico?> ExibirPorNome(string nome);

        Task<bool> ExisteNome(string nome);
    }
}
