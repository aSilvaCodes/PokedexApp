using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexApp.Model
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Num { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string[] Type { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string[] Weaknesses { get; set; }
        public Next_Evolution[] Next_evolution { get; set; }
        public Prev_Evolution[] Prev_evolution { get; set; }
    }

    public class Next_Evolution
    {
        public string Num { get; set; }
        public string Name { get; set; }
    }

    public class Prev_Evolution
    {
        public string Num { get; set; }
        public string Name { get; set; }
    }
}