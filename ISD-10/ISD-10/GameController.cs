using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_10
{
    public interface IGameController 
    {
        void Fight();
        void BotRandomStat(int BonusStat);       
    }
    class GameController : IGameController 
    {
        Random ran = new Random();
        IPlayer player;
        IBot bot;
        public GameController(IPlayer player, IBot bot)
        {
            this.player = player;
            this.bot = bot;
        }
        public void Fight()
        {            
            bot.Rand = ran.Next(50, 61);
            player.Rand = ran.Next(50, 61);         
            player.GetHit(bot.RandomHit, bot.Damage);
            bot.SetBlock(bot.RandomBlock);
            player.SetBlock(player.PlayerBlock);
            bot.GetHit(player.PlayerHit, player.Damage);            
        }
        public void BotRandomStat(int BonusStat)
        {
            bot.Strength = ran.Next(BonusStat + 1);
            bot.Armor = BonusStat - bot.Strength; 
        }
    }
}
