using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ISD_10
{
    public class Presenter
    {
        private readonly IPlayer player;
        private readonly IBot bot;
        private readonly IMainForm view;
        private readonly IGameController controller;
        private readonly IMessanger messange;
        private readonly IRating rating;
        private readonly ILog log;
        public Presenter(IMainForm view)
        {
            this.log = new Log(); 
            this.rating = new Rating();            
            rating.ShowTableStat(log.ReadFile());         
            rating.StartWindow();            
            this.player = new Player(rating.NamePlayer);
            this.bot = new Bot();
            this.view = view;
            this.controller = new GameController(player, bot);
            this.messange = new Messanger(player, bot, view);
            controller.SetBotStat();
            View();
            messange.Message();
            view.FightClick += view_FightClick;
            view.NextBatle += view_NextBatle;
            view.PlayerStrengthAdd += view_PlayerStrengthAdd;
            view.PlayerArmorAdd += view_PlayerArmorAdd;
        }
        void view_PlayerArmorAdd(object sender, EventArgs e)
        {
            if (view.PBArmorPlayer < view.PBArmorPlayerMax)
            {
                if (player.Bonus > 0)
                {
                    player.Armor = player.Armor + 1;
                    player.Bonus = player.Bonus - 1;
                    view.PBArmorPlayer = player.Armor;
                    view.LabelStat = "У вас осталось " + player.Bonus + " свободных статов";
                }
                else
                {
                    player.Strength = player.Strength - 1;
                    player.Armor = player.Armor + 1;
                    view.PBStrengthPlayer = player.Strength;
                    view.PBArmorPlayer = player.Armor;
                }
            }
        }
        void view_PlayerStrengthAdd(object sender, EventArgs e)
        {
            if (view.PBStrengthPlayer < view.PBStrengthPlayerMax)
            {
                if (player.Bonus > 0)
                {
                    player.Strength = player.Strength + 1;
                    player.Bonus = player.Bonus - 1;
                    view.PBStrengthPlayer = player.Strength;
                    view.LabelStat = "У вас осталось " + player.Bonus + " свободных статов";
                }
                else
                {
                    player.Armor = player.Armor - 1;
                    player.Strength = player.Strength + 1;
                    view.PBStrengthPlayer = player.Strength;
                    view.PBArmorPlayer = player.Armor;
                }
            }
        }
        void view_NextBatle(object sender, EventArgs e)
        {
            controller.SetHp(view.PBPlayerMax, view.PBBotMax);
            controller.NextBatle();
            view.PBPlayerMax = player.Hp;
            view.PBBotMax = bot.Hp;
            view.PBStrengthPlayerMax = player.Strength + player.Armor + player.Bonus;
            view.PBArmorPlayerMax = player.Strength + player.Armor + player.Bonus;
            view.PBStrengthBotMax = bot.Strength + bot.Armor;
            view.PBArmorBotMax = bot.Strength + bot.Armor;
            View();
            view.LabelStat = "У вас осталось " + player.Bonus + " свободных статов";
            log.AddChampion(view.PlayerName, view.PBPlayerMax);
        }
        void view_FightClick(object sender, EventArgs e)
        {
            controller.Fight(view.Hit, view.Block);
            View();
            if (bot.Hp <= 0)
            {
                log.AddChampion(view.PlayerName, view.PBPlayerMax);
            }
        }
        public void View()
        {
            view.PlayerName = player.Name;
            view.BotName = bot.Name;
            view.PlayerHp = player.Hp;
            view.BotHp = bot.Hp;
            view.PBStrengthPlayer = player.Strength;
            view.PBArmorPlayer = player.Armor;
            view.PBStrengthBot = bot.Strength;
            view.PBArmorBot = bot.Armor;
        }
    }
}
