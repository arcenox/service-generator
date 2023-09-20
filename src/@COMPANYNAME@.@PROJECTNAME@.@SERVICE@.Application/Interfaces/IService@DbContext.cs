using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Threading;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Application.Interfaces
{
    public interface I_SERVICE_DbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
