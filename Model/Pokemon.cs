using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexApp.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    /*public class NextEvolution
    {
        public string num { get; set; }
        public string name { get; set; }
    }*/

    public class Pokemon
    {
        public int ID { get; set; }
        public string Num { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public List<string> Type { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public List<string> Weaknesses { get; set; }
        //public List<NextEvolution> next_evolution { get; set; }
        //public List<PrevEvolution> prev_evolution { get; set; }
    }

    /*public class PrevEvolution
    {
        public string num { get; set; }
        public string name { get; set; }
    }*/

    /*public class Root
    {
        public List<Pokemon> pokemon { get; set; }
    }*/
}
