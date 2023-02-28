using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroLib
{
    public class TourneyMode : AbstractMode
    {
        public override YHero createYourHero(int w, int a)
        {
            YHeroTourneyMode tm = new YHeroTourneyMode();
            tm.createHero(w,a);
            return tm;
        }
        public override EHero createEnemyHero(int a)
        {
            EHeroTourneyMode tm = new EHeroTourneyMode();
            tm.createHero(a);
            return tm;
        }
        public override Equip createEquipmentY(int w, int a)
        {
            YourEquip tm = new YourEquip();
            tm.saveEquipment(w, a);
            return tm;
        }
        public override Equip createEquipmentE(int w, int a)
        {
            EnemyEquip tm = new EnemyEquip();
            tm.randomEquipment();
            return tm;
        }
    }

    public class BossFightMode : AbstractMode
    {
        public override YHero createYourHero(int w, int a)
        {
            YHeroBossFightMode bm = new YHeroBossFightMode();
            bm.createHero(w, a);
            return bm;
        }
        public override EHero createEnemyHero(int a)
        {
            EHeroBossFightMode bm = new EHeroBossFightMode();
            bm.createHero(a);
            return bm;
        }
        public override Equip createEquipmentY(int w, int a)
        {
            YourEquip bm = new YourEquip();
            bm.saveEquipment(w, a);
            return bm;
        }
        public override Equip createEquipmentE(int w, int a)
        {
            YourEquip bm = new YourEquip();
            bm.saveEquipment(w, a);
            return bm;
        }
    }

    public class RandomMode : AbstractMode
    {
        public override YHero createYourHero(int w, int a)
        {
            YHeroRandomMode rm = new YHeroRandomMode();
            rm.createHero(w, a);
            return rm;
        }
        public override EHero createEnemyHero(int a)
        {
            EHeroRandomMode rm = new EHeroRandomMode();
            rm.createHero(a);
            return rm;
        }
        public override Equip createEquipmentY(int w, int a)
        {
            EnemyEquip rm = new EnemyEquip();
            rm.randomEquipment();
            return rm;
        }
        public override Equip createEquipmentE(int w, int a)
        {
            EnemyEquip rm = new EnemyEquip();
            rm.randomEquipment();
            return rm;
        }
    }
}
