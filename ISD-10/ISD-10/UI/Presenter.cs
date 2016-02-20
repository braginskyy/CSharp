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
        //int BonusStat = 10;
        public Presenter(IMainForm view)
        {
            this.rating = new Rating();
            rating.Start();
            this.player = new Player(rating.NamePlayer);
            this.bot = new Bot();
            this.view = view;
            this.controller = new GameController(player, bot);
            this.messange = new Messanger(player, bot, view);
            controller.BotRandomStat();
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
                    player.Bonus = player.Bonus-1;
                    view.PBStrengthPlayer = player.Strength;
                    view.LabelStat = "У вас осталось " + player.Bonus +" свободных статов";
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
            View();            
            view.LabelStat = "У вас осталось " + player.Bonus + " свободных статов"; 
            ReadWrite();
                       
        }
        void view_FightClick(object sender, EventArgs e)
        {
            controller.BotRandomStat();
            controller.Fight(view.Hit, view.Block);
            View();
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
        //public void BotRandomStat(int BonusStat)
        //{
        //    controller.BotRandomStat(BonusStat);
        //    view.BotStrength = bot.Strength;
        //    view.BotArmor = bot.Armor;
        //}       
        public void ReadWrite()
        {
            if (bot.Hp == 0 || player.Hp == 0)
            {
                FileInfo log = new FileInfo(@".\log.json");
                Result[] table = new Result[10];
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Result[]));
                using (FileStream fs = new FileStream(@".\log.json", FileMode.OpenOrCreate))
                {
                    table = (Result[])jsonFormatter.ReadObject(fs);
                }
                int k = 0;                
                for (int i = 0; i < table.Length; i++)
                {
                    if (table[i].Name == player.Name)
                    {
                        k = 1;
                        if (table[i].Hp < view.PBPlayerMax)
                        {
                            table[i].Name = player.Name;
                            table[i].Hp = view.PBPlayerMax; 
                        }
                    } 
                }                
                if (k==0) 
                {
                    table[9].Name = player.Name;
                    table[9].Hp = view.PBPlayerMax;
                }
                log.Delete();
                Array.Sort(table);
                using (FileStream fs = new FileStream(@".\log.json", FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(fs, table);
                }
            }
        }
    }
}
