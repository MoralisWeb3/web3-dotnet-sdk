using Moralis.Platform.Objects;

namespace Moralis.Platform.Integrated.Tests
{
    internal class Hero : MoralisObject
    {
        public Hero() : base("Hero")
        {
            Name = String.Empty;
            Warcry = String.Empty;
            Bag = new List<string>();
        }

        public int Strength { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public string Warcry { get; set; }
        public DateTime BirthDay { get; set; }
        public List<string> Bag { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
}
