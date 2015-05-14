using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moody
{
    class User
    {
        public string name { set; get; }
        public string portrait { set; get; }

        public User(string name, string portrait)
        {
            this.name = name;
            this.portrait = portrait;
        }
    }
}
