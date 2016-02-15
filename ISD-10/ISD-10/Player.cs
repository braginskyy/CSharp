using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_10
{
    public enum Position { Head = 1, Body, Legs }
    public interface IPlayer
    {
        string Name { get; }
        int Hp { get; set; }
        int Strength { get; set; }
        int Armor { get; set; }
        int Rand { set; }
        int Damage { get; }
        int GetHit(Position p, int damage);
        void SetBlock(Position b);
        event EventHandler<InfoEventArgs> Wound;
        event EventHandler<InfoEventArgs> Block;
        event EventHandler<InfoEventArgs> Death;
    }
    class Player : IPlayer
    {
        protected int rand = 0;
        protected string name = "Player";
        protected int hp = 100;
        protected int strength = 0;
        protected int armor = 0;
        protected int block = 0;
        public int GetHit(Position p, int damage)
        {
            if (block != (int)p)
            {
                if (hp - (damage - armor) > 0)
                {
                    if (damage - armor > 0)
                    {
                        hp = hp - (damage - armor);
                    }
                    if (Wound != null)
                    {
                        Wound(this, new InfoEventArgs(damage - armor, hp, name));
                    }
                }
                else
                {
                    hp = 0;
                    if (Death != null)
                    {
                        Death(this, new InfoEventArgs(damage, hp, name));
                    }
                }
            }
            else if (block == (int)p)
            {
                if (Block != null)
                {
                    Block(this, new InfoEventArgs(damage, hp, name));
                }
            }
            return hp;
        }
        public void SetBlock(Position b)
        {
            block = (int)b;
        }
        public string Name
        {
            get { return name; }
        }
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        public int Armor
        {
            get { return armor; }
            set { armor = value; }
        }
        public int Rand
        {
            set { rand = value; }
        }
        public int Damage
        {
            get { return strength + rand; }
        }
        public event EventHandler<InfoEventArgs> Wound;
        public event EventHandler<InfoEventArgs> Block;
        public event EventHandler<InfoEventArgs> Death;
    }
}
