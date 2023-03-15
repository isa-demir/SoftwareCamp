using A101.Absract;
using A101.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace A101.Concreate
{
    public class EmployeeManager :BaseManager, IEmployeeService
    {
        public EmployeeManager(IPersonCheckService personCheckService) : base(personCheckService)
        {
        }

        public void CalculateSalary(Employee employee)
        {
            Console.WriteLine(employee.Name+"'ın maaşı hesaplandı.");
        }

        public void Fire(Employee employee)
        {
            Console.WriteLine(employee.Id + "-" + employee.Name + "'ın işine son verildi!");
        }

        public void Hire(Employee employee)
        {
            if (CheckIfRealPerson(employee) == true)
            {
                Console.WriteLine(employee.Id + "-" + employee.Name + " işe alım başarılı!");
            }
            else
            {
                Console.WriteLine("Kullanıcı doğrulaması başarısız.");
            }
            
        }

        public void Update(Employee employee, String name)
        {
            Console.WriteLine(employee.Name + " -> " + name + " olarak değiştirildi.");
            employee.Name= name;
        }
    }
}
