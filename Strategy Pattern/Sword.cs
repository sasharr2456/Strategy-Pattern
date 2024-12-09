using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class Sword : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Swinging the sword!");
        }
    }

    public class Bow : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Shooting an arrow!");
        }
    }

    public class Axe : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Chopping with the axe!");
        }
    }
}
