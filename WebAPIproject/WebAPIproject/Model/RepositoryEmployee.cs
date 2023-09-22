using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Extensions;
using WebAPIproject.Models;

namespace WebAPIproject.Model
{
    public class RepositoryEmployee
    {
        public NorthwindContext Context = new NorthwindContext();


        public RepositoryEmployee() { }



        public int DeleteId(Employee emp)
        {


            
            EntityState es = Context.Entry(emp).State;

            Console.WriteLine($"EntityState B4 Delete:{es.GetDisplayName()}");

            Context.Employees.Remove(emp);

            es = Context.Entry(emp).State;

            Console.WriteLine($"EntityState After Delete:{es.GetDisplayName()}");

            int result = Context.SaveChanges();

            es = Context.Entry(emp).State;

            Console.WriteLine($"EntityState After SaveChanges:{es.GetDisplayName()}");
            return result;
           
           // return 1;
        }



        public int AddEmployee(Employee emp)
        {
           

           Employee? foundEmp = Context.Employees.Find(emp.EmployeeId);

            if (foundEmp != null)

            {

                throw new Exception("failed to add");

            }

            EntityState es = Context.Entry(emp).State;

            Console.WriteLine($"EntityState B4 Add:{es.GetDisplayName()}");

            Context.Employees.Add(emp);

            es = Context.Entry(emp).State;

            Console.WriteLine($"EntityState After Add:{es.GetDisplayName()}");

            int result = Context.SaveChanges();

            es = Context.Entry(emp).State;

            Console.WriteLine($"EntityState After SaveChanges:{es.GetDisplayName()}");
            return result;
        }

        public List<Employee> Employees1()
        {

            return Context.Employees.ToList();
        }
        public Employee GetEmployee(int id)
        {
            var Employee = Context.Employees.Find(id);
            return Employee;
        }
        public List<int> GetEmployeeIds()
        {
            List<int> EmployeeIds = new List<int>();
            foreach (var id in Context.Employees)
            {
                EmployeeIds.Add(id.EmployeeId);
            }
            return EmployeeIds;
        }



        public int UpdateEmployee(Employee emp1)
        {

            
            EntityState es = Context.Entry(emp1).State;

            Console.WriteLine($"EntityState B4Update:{es.GetDisplayName()}");

            Context.Employees.Add(emp1);

            es = Context.Entry(emp1).State;

            Console.WriteLine($"EntityState After Update:{es.GetDisplayName()}");

            int result = Context.SaveChanges();

            es = Context.Entry(emp1).State;

            Console.WriteLine($"EntityState After SaveChanges:{es.GetDisplayName()}");
            return result;
        }
    }
}
