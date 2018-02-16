using System;

namespace Bban
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string machineFormat = "227720-35988";
            bool isMachineFormat = bban.Correctnumber(ref machineFormat);
            if (isMachineFormat)
            {
                Console.WriteLine($"{machineFormat} - {bban.IsValidAccount(machineFormat)}");
            }
            else
            {
                Console.WriteLine("Account number incorrect!");
            }

            Console.ReadKey();
        }
    }
}
