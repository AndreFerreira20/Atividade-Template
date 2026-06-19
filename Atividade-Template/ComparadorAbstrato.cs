using System.Collections.Generic;

namespace Atividade_Template
{
    abstract class ComparadorAbstrato : IComparer<string>
    {
        public int Compare(string x, string y) 
        {
            if (x == null && y != null) return -1;
            if (x == null && y == null) return 0;
            if (x != null && y == null) return 1;

            return CompararString(x,y); 
        }
        protected abstract int CompararString(string x, string y);
    }
}
