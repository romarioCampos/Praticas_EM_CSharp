using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneseUmProgramador
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 2;

            string teste = (a == 1 ? "O valor de a" : "Mais um");

            Console.WriteLine("Olá Pessoal!" + teste);
            Console.Read();
        }
    }
}
