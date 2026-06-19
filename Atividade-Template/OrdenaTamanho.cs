using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Template
{
    internal class OrdenaTamanho : ComparadorAbstrato
    {
        protected override int CompararString(string x, string y)
        {
            if (x == "" && y != "") return -1;
            if (x == "" && y == "") return 0;
            if (x != "" && y == "") return 1;

            if (x.Length < y.Length) return -1;
            if (x.Length == y.Length) return 0;
            return 1;
        }
    }
}
