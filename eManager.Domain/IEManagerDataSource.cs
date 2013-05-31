using System.Linq;

namespace eManager.Domain
{
    public interface IEManagerDataSource
    {
       IQueryable<Employee>  Employees { get; }
       IQueryable<Department>  Departments { get; }
    }
}