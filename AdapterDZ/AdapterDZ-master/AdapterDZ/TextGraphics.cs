using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDZ
{
    class TextGraphics
    {
        Graphics _graphics;
        TextView _textView;//Подключен IO
        public TextGraphics(Graphics graphics, TextView textView)
        {
            _textView = textView;
            _graphics = graphics;
        }
    }
}
