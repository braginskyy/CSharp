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
        public Presenter(IMainForm view)
        {
            this.player = new Player();
            this.bot = new Bot();
            this.view = view;
            this.controller = new GameController(player, bot);
            this.messange = new Messanger(player, bot, view);
            Setup();
            View();
            messange.Message();
            view.FightClick += view_FightClick;            
        }       
        void view_FightClick(object sender, EventArgs e)
        {
            Setup();
            controller.Fight();
            View();
        }        
        public void Setup()
        {
            player.Strength = view.PlayerStrength;
            player.Armor = view.PlayerArmor;
            player.PlayerBlock = view.Block;
            player.PlayerHit = view.Hit;
        }
        public void View()
        {
            view.PlayerName = player.Name;
            view.BotName = bot.Name;
            view.BotHp = bot.Hp;
            view.PlayerHp = player.Hp;
            view.BotStrength = bot.Strength;
            view.BotArmor = bot.Armor;
        }
        public void BotRandomStat(int BonusStat)
        {
            controller.BotRandomStat(BonusStat);
            view.BotStrength = bot.Strength;
            view.BotArmor = bot.Armor;
        }
        public void SetHp()
        {
            player.Hp = view.PBPlayerMax;
            bot.Hp = view.PBBotMax;
        }            
    }
}
