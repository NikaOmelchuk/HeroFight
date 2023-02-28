using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroLib
{
    public class EHeroTourneyMode : EHero
    {
        public override void createHero(int a)
        {
            Random r = new Random();
            if (a == 3)
                weapon = r.Next(0, 4);
            else
                weapon = r.Next(0, 3);
            armor = r.Next(0, 5);
        }
    }

    public class EHeroBossFightMode : EHero
    {
        public override void createHero(int a)
        {
            if(a == 1)
            {
                weapon = 0;
                armor = 2;
            }
            else if(a == 2)
            {
                weapon = 1;
                armor = 3;
            }
            else if (a == 3)
            {
                weapon = 2;
                armor = 4;
            }
        }
    }

    public class EHeroRandomMode : EHero
    {
        public override void createHero(int a)
        {
            Random r = new Random();
            weapon = r.Next(0, 3);
            armor = r.Next(0, 5);
        }
    }
}
