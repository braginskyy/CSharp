using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_10
{
    public interface IPlayer
    {
        string PlayerName { get; }
        int PlayerHp { get; }
        int GetHit(Position b);
        void SetBlock(Position b);
        event EventHandler<InfoEventArgs> Wound;
        event EventHandler<InfoEventArgs> Block;
        event EventHandler<InfoEventArgs> Death;
    }
    public enum Position { Head = 1, Body, Legs }
    public class Player : IPlayer
    {
        public event EventHandler<InfoEventArgs> Wound;
        public event EventHandler<InfoEventArgs> Block;
        public event EventHandler<InfoEventArgs> Death;

        private string name = "Player";
        private int xp = 100;
        private int block;
        private int damage = 5;

        public string PlayerName
        {
            get { return name; }
        }
        public int PlayerHp
        {
            get { return xp; }
            set { xp = value; }
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
