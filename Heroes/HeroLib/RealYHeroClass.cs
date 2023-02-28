using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroLib
{
    public class YHeroTourneyMode : YHero
    {
        public override void createHero(int w, int a)
        {
            weapon = w;
            armor = a;
        }
    }

    public class YHeroBossFightMode : YHero
    {
        public override void createHero(int w, int a)
        {
            weapon = w;
            armor = a;
        }
    }

    public class YHeroRandomMode : YHero
    {
        public override void createHero(int w, int a)
        {
            Random r = new Random();
            weapon = r.Next(0,3);
            armor = r.Next(0, 4);
        }
    }
}
