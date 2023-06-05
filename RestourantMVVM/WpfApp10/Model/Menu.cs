using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp10.Model
{
    class Menu
    {
        public int Id { get; set; }
        public Category category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Photo { get; set; }
    }
}
