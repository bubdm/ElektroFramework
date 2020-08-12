using System.Linq;
using ElektroFramework.Core.Entities;

namespace ElektroFramework.Core.DataAccess
{
    public interface IQueryableRepository<T> where T:class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}