using Moralis.Platform.Objects;

namespace Moralis.Platform.Integrated.Tests
{
    class PlayerData : MoralisObject
    {
        public long TokenCount { get; set; }
        public string Name { get; set; }
        public PlayerData() : base("PlayerData") { }
    }
}
