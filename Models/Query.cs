using Demo.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Query
    {
        private readonly IEmployee employee;
        public Query(IEmployee employee)
        {
            this.employee = employee;
        }
        public IEnumerable<Employee> Employees => employee.GetEmployees();
    }
}
