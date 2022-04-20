using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.Fluent.FluentInterfaceDesignPattern
{
    public class FluentEmployee
    {
        private Employee employee = new Employee();

        public FluentEmployee EmployeeId(int id)
        {
            employee.Id = id;
            return this;
        }
        public FluentEmployee EmployeeName(string name)
        {
            employee.Name = name;
            return this;
        }
        public FluentEmployee EmployeeEmail(string email)
        {
            employee.Email = email;
            return this;
        }
        public FluentEmployee EmployeeSalary(int salary)
        {
            employee.Salary = salary;
            return this;
        }       
         
    }
}
