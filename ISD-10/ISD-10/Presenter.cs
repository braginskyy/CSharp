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
        private readonly IGameController controller;
        private readonly IMessanger messange;
        int i = 10;
        public Presenter(IMainForm view)
        {
            Player player = new Player();
            Bot bot = new Bot();
            GameController controller = new GameController();
            Messanger message = new Messanger();
            this.player = player;
            this.bot = bot;
            this.view = view;
            this.controller = controller;
            this.messange = message;
            controller.View(view, player, bot);
            messange.Message(view, player, bot);
            view.FightClick += view_FightClick;
            view.butNextBat += view_butNextBatl;           
        }
        void view_butNextBatl(object sender, EventArgs e)
        {
            Random ran = new Random();
            if (player.Hp == 0 && bot.Hp != 0)
            {
                i += 5;
                view.PBBotMax = view.PBBotMax + 10;
                player.Hp = view.PBPlayerMax;
                bot.Hp = view.PBBotMax;
                controller.Base(view, player, bot);
                controller.View(view, player, bot);
                view.PBStrengthBotMax = view.PBStrengthBotMax + 50;
                view.PBArmorBotMax = view.PBArmorBotMax + 50;                
                bot.Strength = ran.Next(i+1);
                bot.Armor = i-bot.Strength;                               
            }
            if (bot.Hp == 0 && player.Hp != 0)
            {
                view.PBPlayerMax = view.PBPlayerMax + 10;
                player.Hp = view.PBPlayerMax;
                bot.Hp = view.PBBotMax;
                controller.Base(view, player, bot);
                controller.View(view, player, bot);
                view.PBStrengthPlayerMax = view.PBStrengthPlayerMax + 50;
                view.PBArmorPlayerMax = view.PBArmorPlayerMax + 50;
            }
            if (player.Hp == 0 && bot.Hp == 0)
            {
                view.PBPlayerMax = view.PBPlayerMax + 5;
                view.PBBotMax = view.PBBotMax + 5;
                player.Hp = view.PBPlayerMax;
                bot.Hp = view.PBBotMax;
                controller.Base(view, player, bot);
                controller.View(view, player, bot);
                bot.Strength = ran.Next(i + 1);
                bot.Armor = i - bot.Strength;
            }
        }
        void view_FightClick(object sender, EventArgs e)
        {
            controller.Base(view, player, bot);
            controller.Fight(view, player, bot);
            controller.View(view, player, bot);
        }
    }
}
