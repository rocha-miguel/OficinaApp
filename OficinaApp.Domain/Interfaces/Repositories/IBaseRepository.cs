

using OficinaApp.Domain.Entities;
using OficinaApp.Domain.Enums;

namespace OficinaApp.Domain.Interfaces.Repositories {
    public interface IBaseRepository<T> where T : BaseEntity {

        Task Criar(T obj);

        Task Atualizar(Guid id, T obj);

        Task Excluir(Guid id);

        Task<IEnumerable<T>> ExibirTodos(int pageNumber, int pageSize);

        Task<T?> ExibirPorId(Guid id);

        Task<IEnumerable<T>> ExibirPorStatus(int pageNumber, int pageSize, Status status);
    }
}
