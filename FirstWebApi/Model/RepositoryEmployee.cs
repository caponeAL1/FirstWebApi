using FirstWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Extensions;

namespace FirstWebApi.Model
{
    public class RepositoryEmployee
    {
        private NorthwindContext _context;
        public RepositoryEmployee(NorthwindContext context)
        {
            _context = context;
        }
        public List<Employee> AllEmployees()
        {
            return _context.Employees.ToList();
        }
        public Employee FindEmpoyeeById(int id)
        {
            Employee employeeId = _context.Employees.Find(id);
            return employeeId;
        }
        public int AddEmployee(Employee newEmployee)
        {
            Employee? foundEmp = _context.Employees.Find(newEmployee.EmployeeId);
            if (foundEmp != null)
            {
                throw new Exception("Failed to add Employee.Duplicated Id");
            }
            EntityState es = _context.Entry(newEmployee).State;
            Console.WriteLine($"EntityState B4Add: {es.GetDisplayName()}");
            _context.Employees.Add(newEmployee);
            es= _context.Entry(newEmployee).State;
            Console.WriteLine($"EntityState After Add:{es.GetDisplayName()}");
            int result = _context.SaveChanges();
            es= _context.Entry(newEmployee).State;
            Console.WriteLine($"EntityState After SaveChanges:{es.GetDisplayName()}");
            return result;
        }

        public int UpdateEmployee(Employee updatedEmployee)
        {
            EntityState es = _context.Entry(updatedEmployee).State;
            Console.WriteLine($"EntityState B4update:{es.GetDisplayName()}");
            _context.Employees.Update(updatedEmployee);
            es = _context.Entry(updatedEmployee).State;
            Console.WriteLine($"EntityState After Update:{es.GetDisplayName()}");
            int result = _context.SaveChanges();
            es = _context.Entry(updatedEmployee).State;
            Console.WriteLine($"EntityState After saveChanges:{es.GetDisplayName()}");
            return result;



        }
        public int DeleteEmployee(int id)
        {
            Employee? EmpToDelete = _context.Employees.Find(id);
            EntityState es = EntityState.Detached;
            int result = 0;
            if(EmpToDelete != null)
            {
                es= _context.Entry(EmpToDelete).State;
                Console.WriteLine($"EntityState B4Update : {es.GetDisplayName()}");
                _context.Employees.Remove(EmpToDelete);
                es = _context.Entry(EmpToDelete).State;
                Console.WriteLine($"EntityState AfterUpdate : {es.GetDisplayName()}");
                result = _context.SaveChanges();
                es = _context.Entry(EmpToDelete).State;
                Console.WriteLine($"EntityState After saveChanges:{es.GetDisplayName()}");
            }
            return result;

        }
    }
}

