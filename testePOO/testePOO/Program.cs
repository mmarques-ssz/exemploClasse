using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            TesteClasse tc;
            tc = new TesteClasse();

            Console.Write("Informe o primeiro valor: ");
            tc.x = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            tc.y = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma: {0}", tc.somar());
            Console.WriteLine("Subtração: {0}", tc.subtrair());

            Console.ReadKey();

        }
    }
}
