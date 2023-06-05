using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDZ
{
    class TextView
    {
        public int[,] Area { get; set; }
        public int N { get; set; }
        public int Count { get; set; }
        public TextView(int n=4)
        {
            N = n;
            Area = new int[N, N];
        }
        public void LoadFromFile(string FileName)
        {
            TextMemento textMemento = new TextAdapterFromFile(FileName);
            N = textMemento.N;
            Count = textMemento.Count;
            Area = textMemento.Area;
        }
    }
}
