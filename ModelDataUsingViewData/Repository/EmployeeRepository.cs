using ModelDataUsingViewData.Models;

namespace ModelDataUsingViewData.Repository
{
    public class EmployeeRepository : IEmployee
    {
        public List<Employee> getAllEmployee()
        {
            var empData = new List<Employee>()
            {
                new Employee {EmpId=10001,EmpName="Hamza",Designation="8",Salary=0000 },
                new Employee {EmpId=10001,EmpName="Mujahid",Designation="Manager",Salary=25000},
                new Employee {EmpId=10001,EmpName="Haris",Designation="Developer",Salary=25000 },
                new Employee {EmpId=10001,EmpName="Khalid",Designation="Programmer",Salary=25000 },
            };
            return empData;
        }
    }
}
