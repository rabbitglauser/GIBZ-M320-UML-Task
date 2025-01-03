namespace PirateApp
{
    public class Gang
    {
        public string Name { get; set; }
        public int MemberCount { get; set; }
        public string Territory { get; set; }

        public Gang(string name, int memberCount, string territory)
        {
            Name = name;
            MemberCount = memberCount;
            Territory = territory;
        }
    }
}