using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Units
{
    public abstract class BaseUnit
    {
        public ulong UnitID;
        public UnitType Type;
        public string Name;
        public uint Experience;
        public Race Race;

    }

    public enum UnitType
    {
        //Earth
        Earthling,
        EarthlingArmy,
        EarthlingKiControll,

        //Namek
        Namekian,
        NamekianMedic,
        NamekianWarrior,
        NamekianElite,
        
        //Kaio
        Kaioshin,
        KaioshinServant,

        //Chilled
        Soldier,
        EliteSoldier,
        EliteKiSoldier    

        //Custom

    }

    public enum Race
    {
        Namek,
        Earth,
        Kaio,
        Chilled,
        Custom
    }
}
