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
        void PlayerBonussSub();
        void PlayerStrengthAdd();
        void PlayerStrengthSub();
        void PlayerArmorAdd();
        void PlayerArmorSub();
    }
    class GameController : IGameController 
    {
        Random ran = new Random();
        IPlayer player;
        IBot bot;
        int PlayerMaxHp = Setup.BaseHp;
        int BotMaxHp = Setup.BaseHp;        
        public GameController(IPlayer player, IBot bot)
        {
            this.player = player;
            this.bot = bot;
        }
        public void Fight(Position Hit, Position Block)
        {            
            bot.Rand = ran.Next(Setup.MinHit, Setup.MaxHit);
            player.Rand = ran.Next(Setup.MinHit, Setup.MaxHit);         
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
                bot.Hp = BotMaxHp + Setup.BonusHp*2;
                bot.Bonus += Setup.BonusStat*2;
            }
            if (bot.Hp == 0 && player.Hp != 0)
            {
                player.Hp = PlayerMaxHp + Setup.BonusHp;
                bot.Hp = BotMaxHp;
                player.Bonus += Setup.BonusStat;               
            }
            if (player.Hp == 0 && bot.Hp == 0)
            {
                player.Hp = PlayerMaxHp + Setup.BonusHp/2;
                bot.Hp = BotMaxHp + Setup.BonusHp / 2;                
            }
            SetBotStat();
        }
        public void PlayerBonussSub()
        {
            player.Bonus -= 1;
        }
        public void PlayerStrengthAdd()
        {
            player.Strength += 1;
        }
        public void PlayerStrengthSub()
        {
            player.Strength -=1;
        }
        public void PlayerArmorAdd()
        {
            player.Armor += 1;
        }
        public void PlayerArmorSub()
        {
            player.Armor -= 1;
        }
    }
}
