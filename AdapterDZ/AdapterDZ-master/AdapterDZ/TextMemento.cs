using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDZ
{
    class TextMemento
    {
        public int[,] Area { get; set; }
        public int N { get; set; }
        public int Count { get; set; }
        public TextMemento(int[,]area,int n,int count)
        {
            Area = area;
            N = n;
            Count = count;
        }
    }
}
