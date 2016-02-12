using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_10
{
    public class InfoEventArgs : EventArgs
    {
        public InfoEventArgs(int damage,int hp,string name)
        {
            Damage = damage;
            Hp = hp;
            Name = name;
        }
        public int Damage { get; private set; }
        public int Hp { get; private set; }
        public string Name { get; private set; }
    }
}
