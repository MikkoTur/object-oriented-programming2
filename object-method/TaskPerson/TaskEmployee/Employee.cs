using System;
using System.Collections.Generic;
using System.Text;

namespace TaskEmployee
{
    class Employee
    {
        public string Name;
        public int Id;
        public string Position;
        public double Salary;

        //Constructor

        public Employee(string name, int id, string position, double salary)
        {
            Name = name;
            Id = id;
            Position = position;
            Salary = salary;
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Työntekijän nimi: {Name}\n" +
                $"Id-numero: {Id}\n" +
                $"Asema: {Position}\n" +
                $"Palkka: {Salary}\n");
        }

        //Methods
        public void CompareSalary(Employee employee)
        {
            if (Salary < employee.Salary)
            {
                Console.WriteLine($"\n{employee.Name} palkka on isompi kuin henkilön {Name} palkka");
            }
            else
            {
                Console.WriteLine($"\n{Name} palkka on isompi kuin henkilön {employee.Name} palkka");
            }
        }
    }
}
