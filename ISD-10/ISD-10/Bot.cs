using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_10
{
    public interface IBot : IPlayer
    {
        int RandomBlock { get; }
        int RandomHit { get; }
    }
    class Bot : Player, IBot
    {
        Random r = new Random();
        public Bot()
        {
            this.name = "Bot";
            this.hp = 100;
            this.armor = r.Next(11);
            this.strength = 10 - this.armor;
        }
        public int RandomBlock
        {
            get { return r.Next(1, 4); }
        }
        public int RandomHit
        {
            get { return r.Next(1, 4); }
        }
    }
}
