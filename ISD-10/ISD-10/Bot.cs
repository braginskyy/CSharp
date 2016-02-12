using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_10
{
    public interface IBot
    {
        string BotName { get; }
        int BotHp { get; }
        int RandomBlock { get; }
        int RandomHit { get; }
        int GetHit(Position b);
        void SetBlock(Position b);
        event EventHandler<InfoEventArgs> Wound;
        event EventHandler<InfoEventArgs> Block;
        event EventHandler<InfoEventArgs> Death;
    }    
    public class Bot : IBot
    {
        public event EventHandler<InfoEventArgs> Wound;
        public event EventHandler<InfoEventArgs> Block;
        public event EventHandler<InfoEventArgs> Death;
        

        private string name = "Bot";
        private int xp = 100;
        private int block;
        private int damage = 5;        
        Random r = new Random();

        public string BotName
        {
            get { return name; }
        }
        public int BotHp
        {
            get { return xp; }
            set { xp = value; }
        }
        public int RandomBlock
        {
            get { return r.Next(1, 4); }
        }
        public int RandomHit
        {
            get { return r.Next(1, 4); }
        }
        public int GetHit(Position b)
        {            
            if (block != (int)b)
            {
                if (xp - damage > 0)
                {
                    xp = xp - damage;
                    if (Wound != null)
                    {
                        Wound(this, new InfoEventArgs(damage, xp, name));
                    }
                }
                else
                {
                    xp = 0;
                    if (Death != null)
                    {
                        Death(this, new InfoEventArgs(damage, xp, name));
                    }
                }
            }
            else if (block == (int)b)
            {
                if (Block != null)
                {
                    Block(this, new InfoEventArgs(damage, xp, name));
                }
            }

            return xp;
        }
        public void SetBlock(Position b)
        {
            block = (int)b;
        }
    }
}
