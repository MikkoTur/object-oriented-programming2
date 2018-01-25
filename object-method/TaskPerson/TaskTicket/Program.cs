using System;

namespace TaskTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Ticket newTicket = new Ticket();
            newTicket.AskPersonInfo();
            newTicket.ShowPersonInfo();
            newTicket.Discount();


            Console.ReadLine();
        }
    }
}
