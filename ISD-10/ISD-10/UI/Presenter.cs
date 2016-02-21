using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using GameCore;

namespace Combats
{
    public class Presenter
    {
        private readonly IPlayer player;
        private readonly IBot bot;
        private readonly IMainForm view;
        private readonly IGameController controller;
        private readonly IMessanger messange;
        private readonly IScore rating;
        private readonly ILog log;
        public Presenter(IMainForm view)
        {
            this.log = new Log(); 
            this.rating = new Score();            
            rating.ShowTableStat(log.ReadFile());            
            rating.StartWindow();            
            this.player = new Player(rating.NamePlayer);
            this.bot = new Bot();
            this.view = view;
            this.controller = new GameController(player, bot);
            this.messange = new Messanger(player, bot, view);
            view.LabelStat = view.LabelStat = "У вас осталось " + player.Bonus + " свободных статов";
            controller.SetBotStat();
            messange.Message();
            View();            
            view.Fight += view_Fight;
            view.NextBatle += view_NextBatle;
            view.PlayerStrengthAdd += view_PlayerStrengthAdd;
            view.PlayerArmorAdd += view_PlayerArmorAdd;
        }
        void view_PlayerArmorAdd(object sender, EventArgs e)
        {
            if (view.PlayerArmorProgress < view.PlayerArmorMaxProgress)
            {
                if (player.Bonus > 0)
                {
                    controller.PlayerArmorAdd();
                    controller.PlayerBonussSub();
                    view.PlayerArmorProgress = player.Armor;
                    view.LabelStat = "У вас осталось " + player.Bonus + " свободных статов";
                }
                else
                {
                    controller.PlayerStrengthSub();
                    controller.PlayerArmorAdd();                   
                    view.PlayerStrengthProgress = player.Strength;
                    view.PlayerArmorProgress = player.Armor;
                }
            }
        }
        void view_PlayerStrengthAdd(object sender, EventArgs e)
        {
            if (view.PlayerStrengthProgress < view.PlayerStrengthMaxProgress)
            {
                if (player.Bonus > 0)
                {
                    controller.PlayerStrengthAdd();
                    controller.PlayerBonussSub();                    
                    view.PlayerStrengthProgress = player.Strength;
                    view.LabelStat = "У вас осталось " + player.Bonus + " свободных статов";
                }
                else
                {
                    controller.PlayerArmorSub();
                    controller.PlayerStrengthAdd();                    
                    view.PlayerStrengthProgress = player.Strength;
                    view.PlayerArmorProgress = player.Armor;
                }
            }
        }
        void view_NextBatle(object sender, EventArgs e)
        {
            controller.SetHp(view.PlayerHpMaxProgress, view.BotHpMaxProgress);
            controller.NextBatle();
            view.PlayerHpMaxProgress = player.Hp;
            view.BotHpMaxProgress = bot.Hp;
            view.PlayerStrengthMaxProgress = player.Strength + player.Armor + player.Bonus;
            view.PlayerArmorMaxProgress = player.Strength + player.Armor + player.Bonus;
            view.BotStrengthMaxProgress = bot.Strength + bot.Armor;
            view.BotArmorMaxProgress = bot.Strength + bot.Armor;
            View();
            view.LabelStat = "У вас осталось " + player.Bonus + " свободных статов";
            log.AddChampion(view.PlayerName, view.PlayerHpMaxProgress);
        }
        void view_Fight(object sender, EventArgs e)
        {
            controller.Fight(view.Hit, view.Block);            
            View();
            if (bot.Hp <= 0)
            {
                log.AddChampion(view.PlayerName, view.PlayerHpMaxProgress);
            }
        }
        public void View()
        {
            view.PlayerName = player.Name;
            view.BotName = bot.Name;
            view.PlayerHp = player.Hp;
            view.BotHp = bot.Hp;
            view.PlayerStrengthProgress = player.Strength;
            view.PlayerArmorProgress = player.Armor;
            view.BotStrengthProgress = bot.Strength;
            view.BotArmorProgress = bot.Armor;
        }
    }
}
