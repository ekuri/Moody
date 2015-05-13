using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moody
{
    class Mood
    {
        public string text { set; get; }
        public string src { set; get; }

        public Mood(string text, string src)
        {
            this.text = text;
            this.src = src;
        }
    }
}
