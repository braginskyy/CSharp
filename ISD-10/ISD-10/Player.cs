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
        Position PlayerBlock { get; set; }
        Position PlayerHit { get; set; }
        int Strength { get; set; }
        int Armor { get; set; }
        int Rand { set; }
        int Damage { get; }
        int GetHit(Position p, int damage);
        void SetBlock(Position p);
        event EventHandler<InfoEventArgs> Wound;
        event EventHandler<InfoEventArgs> Block;
        event EventHandler<InfoEventArgs> Death;
    }
    class Player : IPlayer
    {
        public Player()
        {

        }
        public Player(string name)
        {
            this.name = name;
        }
        protected int rand = 0;
        protected string name = "Player";
        protected int hp = 100;
        protected int strength = 0;
        protected int armor = 0;
        protected Position block = Position.Legs;
        protected Position hit = Position.Legs;
        public void SetBlock(Position block)
        {
            this.block = block;
        }
        public int GetHit(Position hit, int damage)
        {
            this.hit = hit;
            if (block != hit)
            {
                if (hp - (damage - (armor/2)) > 0)
                {
                    if (damage - (armor / 2) > 0)
                    {
                        hp = hp - (damage - (armor / 2));
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
            else if (block == hit)
            {
                if (Block != null)
                {
                    Block(this, new InfoEventArgs(damage, hp, name));
                }
            }
            return hp;
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
        public Position PlayerBlock
        {
            get { return block; }
            set { block = value; }
        }
        public Position PlayerHit
        {
            get { return hit; }
            set { hit = value; }
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
