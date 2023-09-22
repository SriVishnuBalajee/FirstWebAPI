
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebAPIproject.Model;
using WebAPIproject.Models;

namespace WebAPIproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeCntroller : ControllerBase
    {


        public static List<Employee> employeeList = new List<Employee>();
        static RepositoryEmployee repositoryEmployee = new RepositoryEmployee();

        [HttpGet]
        public IEnumerable<EmpViewModel> Get()
        {

            // StringBuilder sb = new StringBuilder();

            List<Employee> employees = repositoryEmployee.Employees1();
            List<EmpViewModel> empViewModels = new List<EmpViewModel>();

            foreach (Employee emp in employees)
            {
                EmpViewModel empViewModel = new EmpViewModel();

                empViewModel.EmpId = emp.EmployeeId;

                empViewModel.FirstName = emp.FirstName;

                empViewModel.LastName = emp.LastName;

                empViewModel.BirthDate = (DateTime)emp.BirthDate;

                empViewModel.HireDate = (DateTime)emp.HireDate;

                empViewModel.Title = emp.Title;

                empViewModel.City = emp.City;

                empViewModel.ReportTo = emp.ReportsTo;
            }
            return empViewModels ;
        }

        

        [HttpDelete("/Delete")]
        public int Delete(int id)
        {
            Employee employee = repositoryEmployee.GetEmployee(id);
            repositoryEmployee.DeleteId(employee);
            return 1;
        }



        [HttpPost("/Add")]



        public int Post(EmpViewModel emp)
        {
            Employee employee = new Employee();
            // employee.EmployeeId =10;
            employee.FirstName = emp.FirstName;
            employee.LastName = emp.LastName;
            repositoryEmployee.AddEmployee(employee);
            return 1;
        }



        [HttpPut("/Modify")]
        public int Put(EmpViewModel emp)
        {
            Employee employee = new Employee();
            employee.EmployeeId = emp.EmpId;
            employee.FirstName = emp.FirstName;
            employee.LastName = emp.LastName;



            repositoryEmployee.UpdateEmployee(employee);



            return 1;



        }

    }
}
