using System.Collections.Concurrent;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the number of small carbets");

            int small = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the of large carbets");

            int large = Convert.ToInt32(Console.ReadLine());

            int Smallcost = small * 25;
            int Largecost = large * 35;

            int cost = Smallcost + Largecost;
            double Taxamount = cost * 0.06;

            Console.WriteLine($"Tax (6%){Taxamount}");
            Console.WriteLine($"Total amount{cost + Taxamount}");












        }
    }
}

 