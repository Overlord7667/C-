using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test3
{
    class Size
    {
        public int[,] Area { get;private set; }
        public int N { get;private set; }
        public int Block { get; private set; }

        public Size()
        {
            N = 10;
            Block = 10;
            Area = new int[N,N];
            GenerateArea();
        }
        public Size(int N,int Block)
        {
            this.N = Math.Abs(N);
            this.Block = Math.Abs(Block);
            if (Block >= N * N)
                this.Block = N;
            Area = new int[N, N];
            GenerateArea();
        }
        public void GridToArea(DataGridView grid, int n)
        {
            N = n;
            Area = new int[n, n];

            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    if (grid[col, row].Style.BackColor == Color.Black)
                        Area[row, col] = 1;
                    else
                        Area[row, col] = 0;

                    if (grid[col, row].Style.BackColor == Color.Red)
                        Area[row, col] = 2;
                    else
                        Area[row, col] = 0;

                    if (grid[col, row].Style.BackColor == Color.Blue)
                        Area[row, col] = 3;
                    else
                        Area[row, col] = 0;
                }
            }

        }
        public void AreaToGrid(DataGridView grid)
        {
            for (int col = 0; col < N; col++)
            {
                for (int row = 0; row < N; row++)
                {
                    if (Area[row, col] == 1)
                        grid[col, row].Style.BackColor = Color.Black;

                    else if (Area[row, col] == 2)
                        grid[col, row].Style.BackColor = Color.Red;
                    
                    else if (Area[row, col] == 3)
                        grid[col, row].Style.BackColor = Color.Green;

                    else if (Area[row, col] == 3)
                        grid[col, row].Style.BackColor = Color.Blue;

                    else
                        grid[row, col].Style.BackColor = Color.White;
                }
            }
        }

        private void GenerateArea()
        {
            Random randon = new Random();
            for (int i = 0; i < Block;)
            {
                int x = randon.Next(N);
                int y = randon.Next(N);
                if (Area[x, y] < 10)
                {
                    Area[x, y] = 50;
                    i++;

                    if (x > 0) Area[x - 1, y]++;
                    if (x < N - 1) Area[x + 1, y]++;

                    if (x > 0 && y > 0) Area[x - 1, y - 1]++;
                    if (y > 0 && x < N - 1) Area[x + 1, y - 1]++;
                    if (y > 0) Area[x, y - 1]++;

                    if (x > 0 && y < N - 1) Area[x - 1, y + 1]++;
                    if (x < N - 1 && y < N - 1) Area[x + 1, y + 1]++;
                    if (y < N - 1) Area[x, y + 1]++;
                }
            }
        }
    }
}
