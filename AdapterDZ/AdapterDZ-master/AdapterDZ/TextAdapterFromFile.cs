using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDZ
{
    class TextAdapterFromFile:TextMemento
    {
        public TextAdapterFromFile(string path) : base(null, 0, 0)
        {
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(fileStream);
            Count = Convert.ToInt32(reader.ReadLine());
            N = Convert.ToInt32(reader.ReadLine());
            Area = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                string line = reader.ReadLine();
                string[] buffer = line.Split(' ');
                for (int j = 0; j < N; j++)
                {
                    Area[i, j] = Convert.ToInt32(buffer[j]);
                }
            }
            fileStream.Close();
        }
    }
}
