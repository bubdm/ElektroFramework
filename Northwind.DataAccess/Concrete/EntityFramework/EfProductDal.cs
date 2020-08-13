using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DevFramework.Northwind.Entities.Concrete;
using ElektroFramework.Core.DataAccess.EntityFramework;
using ElektroFramework.Northwind.DataAccess.Absract;

namespace ElektroFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
        
    }
}