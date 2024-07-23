using System.Text.Json.Serialization;

namespace PokedexApp.Model
{
    public class Pokemon
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Description {get; set;}
        public string Img { get; set; }
        public string[] Type { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string[] Weaknesses { get; set; }
    }
}
[JsonSerializable(typeof(List<Pokemon>))]
internal sealed partial class PokeContext : JsonSerializerContext
{

}