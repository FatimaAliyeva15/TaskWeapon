using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Weapon
    {
        public int BulletCapacity { get; set; }

        public int BulletCount { get; set;}

        public bool FireMode { get; set; }

        public Weapon(int bulletcapacity, int bulletcount, bool firemode)
        {
            BulletCapacity = bulletcapacity;
            BulletCount = bulletcount;
            FireMode = firemode;
        }

        public  void Shoot()
        {
            if(BulletCount > 0)
            {
                BulletCount = BulletCount - 1;
                Console.WriteLine("Ates acildi");
            }
            else
            {
                Console.WriteLine("Gulle qalmadi");
            }
            
        }

        public void Fire()
        {
            if(BulletCount > 0)
            {
                BulletCount = BulletCount - BulletCount;
                Console.WriteLine("Gulleler ateslendi");
            }
            else 
            {
                Console.WriteLine("Gulle qalmadi");
            }
            
        }

        public int GetRemainBulletCount()
        {
            int n = BulletCapacity - BulletCount;
            return n;
        }

        public void Reload()
        {
            BulletCount += BulletCapacity - BulletCount;
            Console.WriteLine("Yeniden dolduruldu");
        }


        public void ChangeFireMode()
        {
            if(FireMode)
            {
                FireMode = false;
            }
            else { FireMode = true; }

            Console.WriteLine("Mode deyisdi");
        }
    }
}
