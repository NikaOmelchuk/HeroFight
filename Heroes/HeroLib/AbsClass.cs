using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroLib
{
    public abstract class YHero
    {
        public int weapon;
        public int armor;
        public abstract void createHero(int w, int a);
    }

    public abstract class EHero
    {
        public int weapon;
        public int armor;
        public abstract void createHero(int a);
    }

    public abstract class Equip
    {
        public int weapon;
        public int armor;
        public abstract void saveEquipment(int w, int a);
        public abstract void randomEquipment();
    }

    public abstract class AbstractMode
    {
        public int countRounds;
        public abstract YHero createYourHero(int w, int a);
        public abstract EHero createEnemyHero(int a);
        public abstract Equip createEquipmentY(int w, int a);
        public abstract Equip createEquipmentE(int w, int a);
    }
}
