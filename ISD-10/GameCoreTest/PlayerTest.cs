using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCore;

namespace GameCoreTest
{
    [TestFixture]
    public class PlayerTest
    {
        IPlayer player;
        const int Hp = 100;
        const int MaxDamage = 10000;
        [SetUp]
        public void Init()
        {
            player = new Player();
        }
        //[Test]
        //public void GetHit_BlockEqualHit_SubstractionHp()
        //{
        //    for (int damage = -MaxDamage; damage <= MaxDamage; damage++)
        //    {
        //        for (Position p = Position.Legs; p <= Position.Head; p++)
        //        {
        //            player.SetBlock(p);
        //            Position position = p;

        //            player.GetHit(position, damage);

        //            Assert.That(player.Hp, Is.EqualTo(Hp));
        //        }
        //    }            
        //}
        //[Test]
        //public void GetHit_BlockNotEqualHit_SubstractionHp()
        //{
        //    for (int damage = -MaxDamage; damage <= MaxDamage; damage++)
        //    {
        //        for (Position pBlock = Position.Legs; pBlock <= Position.Head; pBlock++)
        //        {
        //            for (Position pHit = Position.Legs; pHit <= Position.Head; pHit++)
        //            {
        //                player.SetBlock(pBlock);
        //                Position position = pHit;
        //                player.Hp = Hp;

        //                player.GetHit(position, damage);

        //                Assert.That(player.Hp, Is.EqualTo(Hp - (damage - player.Armor / 2)).Or.EqualTo(0));
        //            }
        //        }
        //    }
        //}
        [Test]
        public void GetHit_BlockEqualHitDamageMin_SubstractionHp()
        {
            player.SetBlock(Position.Legs);
            int damage = 0;
            Position position = Position.Legs;

            player.GetHit(position, damage);

            Assert.That(player.Hp, Is.EqualTo(Hp));
        }
        [Test]
        public void GetHit_BlockEqualHitDamageMax_SubstractionHp()
        {
            player.SetBlock(Position.Legs);
            int damage = int.MaxValue;
            Position position = Position.Legs;

            player.GetHit(position, damage);

            Assert.That(player.Hp, Is.EqualTo(Hp));
        }
        [Test]
        public void GetHit_BlockNotEqualHitDamageMin_SubstractionHp()
        {
            player.SetBlock(Position.Legs);
            int damage = 0;
            Position position = Position.Head;

            player.GetHit(position, damage);

            Assert.That(player.Hp, Is.EqualTo(Hp));
        }
        [Test]
        public void GetHit_BlockNotEqualHitDamageMax_SubstractionHp()
        {
            player.SetBlock(Position.Legs);
            int damage = int.MaxValue;
            Position position = Position.Head;

            player.GetHit(position, damage);

            Assert.That(player.Hp, Is.EqualTo(Hp - (damage - player.Armor / 2)).Or.EqualTo(0));
        }
    }
}
