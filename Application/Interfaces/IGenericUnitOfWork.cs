using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    public interface IGenericUnitOfWork : IDisposable
    {
        Task<int> Commit(CancellationToken cancellationToken);
        Task Rollback();
    }
}
