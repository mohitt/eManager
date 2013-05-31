using System.Data.Entity;
using eManager.Domain;

namespace eManager.Web.InfraStructure
{
    public class EManagerDb : DbContext, IEManagerDataSource
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public EManagerDb() : base("DefaultConnection") {
            
        }

        System.Linq.IQueryable<Employee> IEManagerDataSource.Employees
        {
            get { return Employees; }
        }

        System.Linq.IQueryable<Department> IEManagerDataSource.Departments
        {
            get { return Departments; }
        }
    }
}