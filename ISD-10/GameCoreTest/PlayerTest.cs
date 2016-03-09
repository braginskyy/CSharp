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
        [TestFixture]
        public class GetHit
        {            
            IPlayer player;
            const int Hp = 100;
            [SetUp]
            public void Init()
            {
                player = new Player();
                player.Hp = 100;
                player.Armor = 10;
            }
            [Test]
            public void GetHit_BlockEqualHit_SubstractionHp()
            {
                for (int damage = 0; damage <= 10000; damage++)
                {
                    player.SetBlock(Position.Legs);
                    Position position = Position.Legs;

                    player.GetHit(position, damage);

                    Assert.That(player.Hp, Is.EqualTo(Hp));
                }
            }
            [Test]
            public void GetHit_BlockNotEqualHit_SubstractionHp()
            {
                for (int damage = 0; damage <= 10000; damage++)
                {
                    player.SetBlock(Position.Legs);
                    Position position = Position.Head;
                    player.Hp = 100;

                    player.GetHit(position, damage);

                    Assert.That(player.Hp, Is.EqualTo(Hp - (damage - player.Armor / 2)).Or.EqualTo(player.Hp).Or.EqualTo(0));
                }
            }
        } 
    }
}
