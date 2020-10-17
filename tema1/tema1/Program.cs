using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace tema1
{
    class Program
    {
        static void Main()
        {
            int ptpc;
            Console.Write("Introduceti puterea de calcul dorita:");
            ptpc=Int32.Parse(Console.ReadLine());
          
           float timp=new Single();
            timp= 1.5f * (float)Math.Log(ptpc,2);


            Console.WriteLine($"Puterea calculatorului va fi de {ptpc} ori mai mare peste {timp} ani .");

        }
    }
}
