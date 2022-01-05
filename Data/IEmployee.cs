using SampleCRUD.Model;

namespace SampleCRUD.Data
{
    public interface IEmployee
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);

        Employee AddEmployee(Employee employee);

        void DeleteEmployee(Employee employee);

        Employee Employee(Employee employee);
        
    }
}
