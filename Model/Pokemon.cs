using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexApp.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class NextEvolution
    {
        public string num { get; set; }
        public string name { get; set; }
    }

    public class Pokemon
    {
        public int id { get; set; }
        public string num { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public List<string> type { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public List<string> weaknesses { get; set; }
        public List<NextEvolution> next_evolution { get; set; }
        public List<PrevEvolution> prev_evolution { get; set; }
    }

    public class PrevEvolution
    {
        public string num { get; set; }
        public string name { get; set; }
    }

    public class Root
    {
        public List<Pokemon> pokemon { get; set; }
    }


}
