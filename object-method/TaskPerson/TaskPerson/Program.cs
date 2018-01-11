using System;

namespace TaskPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Person personMikko = new Person();
            personMikko.Name = "Mikko T";
            personMikko.GrowOld();
            personMikko.PrintPersonInfo();

            Person newPerson = new Person("Lil Pump", 18);
            newPerson.PrintPersonInfo();
            newPerson.GrowOld();
            newPerson.PrintPersonInfo();
            Console.ReadKey();


        }
    }
}
