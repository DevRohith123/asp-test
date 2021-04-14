using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.IService
{
    public interface IEmployee
    {
        public IEnumerable<Employee> GetEmployees();
    }
}
