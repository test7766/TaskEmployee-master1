using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data
{
    public class EmployeeSeed
    {
        public static ObservableCollection<Employee> LoadEmployees()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

            // Здесь можно выполнить чтение данных из файла или другого источника данных
            // и заполнить коллекцию employees.

            employees.Add(new Employee
            {
                Id = 1,
                Name = "John Doe",
                Adress = "Kiev",
                DateOfBirth = DateTime.Now,
                Phone = "+38(099)999-99-99",
                Position = "Director",
                Status = "Уволен",
                Salary = 34000,
                Date_of_employment = DateTime.Now,
                Date_of_dismissal = new DateTime(2023, 01, 01)
            });

            employees.Add(new Employee
            {
                Id = 2,
                Name = "Jane Smith",
                Adress = "Lviv",
                DateOfBirth = DateTime.Now,
                Phone = "+38(099)888-88-88",
                Position = "HR Manager",
                Status = "Работает",
                Salary = 24000,
                Date_of_employment = DateTime.Now,
                Date_of_dismissal = new DateTime()
            });

            employees.Add(new Employee
            {
                Id = 3,
                Name = "Bob Smith",
                Adress = "Odessa",
                DateOfBirth = DateTime.Now,
                Phone = "+38(099)888-88-88",
                Position = "HR Manager",
                Status = "Уволен",
                Salary = 24000,
                Date_of_employment = DateTime.Now,
                Date_of_dismissal = new DateTime(2023, 02, 02)
            });

            return employees;
        }


    }
}
