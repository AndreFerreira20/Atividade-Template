using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Template
{
    internal class OrdenaUltimaLetra : ComparadorAbstrato
    {
        protected override int CompararString(string x, string y)
        {
            if (x == "" && y != "") return -1;
            if (x == "" && y == "") return 0;
            if (x != "" && y == "") return 1;

            if (x[x.Length - 1] < y[y.Length - 1]) return -1;
            if (x[x.Length - 1] == y[y.Length - 1]) return 0;
            return 1;
        }
    }
}
