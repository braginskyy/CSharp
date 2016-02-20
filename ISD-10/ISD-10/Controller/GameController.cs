using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ISD_10
{
    public interface IGameController 
    {
        void Fight(Position Hit, Position Block);
        void SetBotStat();
        void SetHp(int PlayerMaxProsress, int BotMaxProgress);
        void NextBatle();        
    }
    class GameController : IGameController 
    {
        Random ran = new Random();
        IPlayer player;
        IBot bot;
        int PlayerMaxHp = 100;
        int BotMaxHp = 100;        
        public GameController(IPlayer player, IBot bot)
        {
            this.player = player;
            this.bot = bot;
        }
        public void Fight(Position Hit, Position Block)
        {            
            bot.Rand = ran.Next(50, 61);
            player.Rand = ran.Next(150, 161);         
            player.GetHit(bot.RandomHit, bot.Damage);
            bot.SetBlock(bot.RandomBlock);
            player.SetBlock(Block);
            bot.GetHit(Hit, player.Damage);            
        }
        public void SetBotStat()
        {
            bot.Strength = ran.Next(bot.Bonus+1);
            bot.Armor = bot.Bonus - bot.Strength;
        }
        public void SetHp(int PlayerMaxProsress, int BotMaxProgress)
        {
            PlayerMaxHp = PlayerMaxProsress;
            BotMaxHp = BotMaxProgress;
        }
        public void NextBatle()
        {
            if (player.Hp == 0 && bot.Hp != 0)
            {
                player.Hp = PlayerMaxHp;
                bot.Hp = BotMaxHp + 20;
                bot.Bonus += 10;
            }
            if (bot.Hp == 0 && player.Hp != 0)
            {
                player.Hp = PlayerMaxHp + 10;
                bot.Hp = BotMaxHp;
                player.Bonus += 5;               
            }
            if (player.Hp == 0 && bot.Hp == 0)
            {
                player.Hp = PlayerMaxHp + 5;
                bot.Hp = BotMaxHp + 5;                
            }
            SetBotStat();
        } 
    }
}
