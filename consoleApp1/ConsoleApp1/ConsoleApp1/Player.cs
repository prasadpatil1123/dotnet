using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Player
    {
        public String Name { get; set; }
        private int Health { get; set; }
       public Player()
        {
            Name = "Kashi";
            Health = 18;
        }
        public void SetName(String n)
        {
            Name = n;
        }
        public void SetHealth(int h)
        {
            Health = h;
        }

        public String GetName()
        {
            return Name;
        }
        public int GetHealth()
        {
            return Health;
        }
    }
}
