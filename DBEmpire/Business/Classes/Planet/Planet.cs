using DBEmpire.Business.Classes.Units;

namespace DBEmpire.Business.Classes.Planet
{
    public class Planet
    {
        public ulong PlanetID { get; set; }
        public string PlanetName { get; set; }
        public PlanetPosition Position { get; set; }
        public Army Army { get; set; }
        public uint SienceLevel {get;set;}
        public uint CultureLevel {get;set;}

        
    }

    public class PlanetPosition
    {
        public long X { get; set; }
        public long Y { get; set; }
        public long Z { get; set; }
    }
}
