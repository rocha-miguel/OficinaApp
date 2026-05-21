using OficinaApp.Domain.Entities;
using OficinaApp.Domain.Enums;


namespace OficinaApp.Domain.Interfaces.Services {
    public interface IBaseService<T> where T : BaseEntity{

        Task CriarAsync(T obj);

        Task AtualizarAsync(Guid id, T obj);

        Task ExcluirAsync(Guid id);

        Task<IEnumerable<T>> ExibirTodosAsync(int pageNumber, int pageSize);

        Task<T?> ExibirPorIdAsync(Guid id);

        Task<IEnumerable<T>> ExibirPorStatusAsync(int pageNumber, int pageSize, Status status);
    }
}
