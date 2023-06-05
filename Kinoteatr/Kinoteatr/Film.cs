using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoteatr
{
    class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string View { get; set; }
        public decimal Price { get; set; }
        public decimal Revenue { get; set; }
        public DateTime Session { get; set; }
    }
}
