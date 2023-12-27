using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2v7
{
    class Composition
    {
        public string Artist { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return $"{Artist} - {Title}";
        }
    }
}
