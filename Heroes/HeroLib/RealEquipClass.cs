using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroLib
{
    public class YourEquip : Equip
    {
        public override void saveEquipment(int w, int a)
        {
            weapon = w;
            armor = a;
        }
        public override void randomEquipment()
        {
            Random r = new Random();
            weapon = r.Next(0, 3);
            armor = r.Next(0, 4);
        }
    }

    public class EnemyEquip : Equip
    {
        public override void saveEquipment(int w, int a)
        {
            weapon = w;
            armor = a;
        }

        public override void randomEquipment()
        {
            Random r = new Random();
            weapon = r.Next(0, 3);
            armor = r.Next(0, 6);
        }
    }
}
