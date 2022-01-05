using SampleCRUD.Model;

namespace SampleCRUD.Data
{
    public class MockEmployee : IEmployee
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                id = 1,
                name = "sample"
            },
             new Employee()
            {
                id = 2,
                name = "emp"
            },
              new Employee()
            {
                id = 1,
                name = "emp"
            }
        };
        public Employee AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee Employee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(Guid id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
           // var query = employees.Where(n => n.name == "emp").ToList();
         
            return employees;
        }
    }
}
