using A101.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace A101.Absract
{
    public interface IEmployeeService
    {
        void Fire(Employee employee);

        void Hire(Employee employee);
        void Update(Employee employee, String name);
        void CalculateSalary(Employee employee);
    }
}
