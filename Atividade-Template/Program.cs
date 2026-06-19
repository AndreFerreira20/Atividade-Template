using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] aa = { "GRANDE GIGANTE NOME", "Pele", "Amir", "" };

            Array.Sort(aa, new OrdenaTamanho());

            foreach (string a in aa) Console.WriteLine(a);
        }
    }
}
