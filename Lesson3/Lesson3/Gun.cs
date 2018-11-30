using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Gun
    {
        private int _AmmoCount;
        public Gun()
        {
            _AmmoCount = 5;
        }
        public Gun(int AmmoCount)
        {
            _AmmoCount = AmmoCount;
        }

        public void Shot()
        {
            if (_AmmoCount > 0)
            {
                Console.WriteLine("|");
                _AmmoCount--;
            }
            else
            {
                Console.WriteLine("Патроны кончились");
            }
        }
        public void Reload()
        {
            Console.WriteLine("Заряжает 5 патронов");
            _AmmoCount = 5;
        }
        public void Reload(int Ammo)
        {
            Console.WriteLine($"Заряжает {Ammo} патронов");
            _AmmoCount = Ammo;
        }
    }
}
