using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_10
{

    public class Presenter
    {
        private readonly IPlayer player;        
        private readonly IBot bot;
        private readonly IMainForm view;


        public Presenter(IMainForm view)
        {
            Player player = new Player();
            Bot bot = new Bot();  

            this.player = player;
            this.bot = bot;           
            this.view = view;
            view.PlayerName = player.Name;
            view.BotName = bot.Name;
            view.PlayerHp = player.Hp;
            view.BotHp = bot.Hp; 
            view.FightClick += view_FightClick;
            player.Wound += player_Wound;
            player.Block += player_Block;
            player.Death += player_Death;
            bot.Wound += player_Wound;
            bot.Block += player_Block;
            bot.Death += player_Death;            
        }
        void player_Death(object sender, InfoEventArgs e)
        {
            
            view.Log = "Игрок " + e.Name.ToUpper() + " повержен " + e.Hp + "хп.";
        }

        void player_Block(object sender, InfoEventArgs e)
        {
            view.Log = "Игрок " + e.Name.ToUpper() + " заблокировал удар ";
        }

        void player_Wound(object sender, InfoEventArgs e)
        {
            view.Log = "Игрок " + e.Name.ToUpper() + " получил урон " + e.Damage + " хп. " + " Осталось " + e.Hp + " хп. ";
        }
        
        void view_FightClick(object sender, EventArgs e)
        {
            Random r = new Random();
            bot.Rand = r.Next(16);
            player.Rand = r.Next(16);
            player.Strength = view.PlayerStrength;
            player.Armor = view.PlayerArmor;
            FightControl();
            ViewControl();            
        }
        private void ViewControl()
        {
            view.BotHp = bot.Hp;
            view.PlayerHp = player.Hp;
            view.BotStrength = bot.Strength;
            view.BotArmor = bot.Armor;
        }
        private void FightControl()
        {
            player.SetBlock((Position)view.GetBlock);
            player.GetHit((Position)bot.RandomHit, bot.Damage);
            bot.SetBlock((Position)bot.RandomBlock);
            bot.GetHit((Position)view.GetHit, player.Damage); 
        }
    }
}
