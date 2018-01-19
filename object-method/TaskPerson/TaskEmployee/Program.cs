using System;

namespace TaskEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Seppo Taalasmaa", 1234, "Toimitusjohtaja", 5500);
            employees[1] = new Employee("Ismo Laitela", 6666, "Sihteeri", 2200);
            employees[2] = new Employee("Jörgen Balls", 4321, "Omistaja", 15000);

            for (int i = 0; i < 3; i++)
            {
                employees[i].PrintEmployeeInfo();
            }
            employees[1].CompareSalary(employees[2]);
            employees[0].CompareSalary(employees[1]);
            employees[2].CompareSalary(employees[1]);

            Console.ReadKey();
        }
    }
}
