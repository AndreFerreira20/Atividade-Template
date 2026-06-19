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
            string[] teste1 = { "GRANDE GIGANTE NOME", "Pele", "Amir", "", "aaai", "paulinho" };
            string[] teste2 = { "tenis", "Puma", "Abibas", "telefone", "", "nice", "aaaaaaaaaaaaaaa", "oi" };

            Array.Sort(teste1, new OrdenaUltimaLetra());
            Array.Sort(teste2, new OrdenaTamanho());

            Console.WriteLine("[TESTE - ORDENAÇÃO PELA ÚLTIMA LETRA]");
            foreach (string a in teste1) Console.Write("-" + a + "-");

            Console.Write("\n\n");

            Console.WriteLine("[TESTE - ORDENAÇÃO PELO TAMANHO]");
            foreach (string a in teste2) Console.Write("-" + a + "-");

            Console.Write("\n");
        }
    }
}
