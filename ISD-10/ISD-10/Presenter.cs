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

            view.PlayerName = player.PlayerName;
            view.BotName = bot.BotName;
            view.PlayerHp = player.PlayerHp;
            view.BotHp = bot.BotHp;

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
            player.SetBlock((Position)view.GetBlock);
            player.GetHit((Position)bot.RandomHit);
            bot.SetBlock((Position)bot.RandomBlock);
            bot.GetHit((Position)view.GetHit);

            view.BotHp = bot.BotHp;
            view.PlayerHp = player.PlayerHp;
        }
    }
}
