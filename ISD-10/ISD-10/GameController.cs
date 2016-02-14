using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_10
{
    public interface IGameController 
    {
        void View(IMainForm view, IPlayer player, IBot bot);
        void Fight(IMainForm view, IPlayer player, IBot bot);
        void Base(IMainForm view, IPlayer player, IBot bot);
    }
    class GameController : IGameController 
    {
        public void Base(IMainForm view, IPlayer player, IBot bot)
        {
            Random r = new Random();
            bot.Rand = r.Next(10,21);
            player.Rand = r.Next(10,21);
            player.Strength = view.PlayerStrength;
            player.Armor = view.PlayerArmor;
        }
        public void View(IMainForm view ,IPlayer player, IBot bot)
        {
            view.PlayerName = player.Name;
            view.BotName = bot.Name;
            view.BotHp = bot.Hp;
            view.PlayerHp = player.Hp;
            view.BotStrength = bot.Strength;
            view.BotArmor = bot.Armor;
        }
        public void Fight(IMainForm view, IPlayer player, IBot bot)
        {
            player.SetBlock((Position)view.GetBlock);
            player.GetHit((Position)bot.RandomHit, bot.Damage);
            bot.SetBlock((Position)bot.RandomBlock);
            bot.GetHit((Position)view.GetHit, player.Damage);
        }
    }
}
