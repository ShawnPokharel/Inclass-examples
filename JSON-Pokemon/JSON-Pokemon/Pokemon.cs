using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Pokemon
{
    class Pokemon
    {
       // public AllPokemonAPI info { get; set; }

       // public List<ResultObject> results { get; set; }

    }

    public class AllPokemonResult
    {
        internal string image;

        public string name { get; set; }
    
        public string url { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

    public class AllPokemonAPI
    {
        public int count { get; set; }
        public string next { get; set; }
        public string prev { get; set; }
        public List<AllPokemonResult> results { get; set; }
    }
}
