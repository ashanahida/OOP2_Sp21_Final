using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
                Account a1 = new Account("Nahida Asha", "134", 100000);
                Account a2 = new Account("Kiron", "135", 100000);

                a1.Withdraw(10000);
                a1.Deposit(20000);
                a1.Transfer(a2, 40000);
                a2.Transfer(a1, 25000);

                Console.WriteLine("\n---------------\n");
                a1.ShowInfo();
                Console.WriteLine("----------------\n");
                a2.ShowInfo();
                Console.ReadLine();
            }
    }
}
