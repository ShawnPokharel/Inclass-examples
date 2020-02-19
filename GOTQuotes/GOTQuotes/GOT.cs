using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOTQuotes
{
    class GOT
    {
        public string character { get; set; }

        public string quote { get; set; }

        public override string ToString()
        {
            return $"{character}: {quote}";
        }
    }
}
