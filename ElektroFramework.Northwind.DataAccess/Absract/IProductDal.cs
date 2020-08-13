using DevFramework.Northwind.Entities.Concrete;
using ElektroFramework.Core.DataAccess;

namespace ElektroFramework.Northwind.DataAccess.Absract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}