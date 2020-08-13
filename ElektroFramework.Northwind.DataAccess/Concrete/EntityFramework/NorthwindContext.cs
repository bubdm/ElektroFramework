using System.Data.Entity;
using DevFramework.Northwind.Entities.Concrete;
using ElektroFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings;

namespace ElektroFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext: DbContext
    {
        
        public NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);
        }
        public Microsoft.EntityFrameworkCore.DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }
        
        
    }
        
    
}