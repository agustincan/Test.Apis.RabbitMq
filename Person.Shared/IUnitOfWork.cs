using Repository.Core;

namespace Repository.Core
{
    public interface IUnitOfWork: IDisposable
    {
        IRepositoryAsync<T> Repository<T>() where T : class;

        Task<int> Commit(CancellationToken cancellationToken);

        Task Rollback();
    }    
}