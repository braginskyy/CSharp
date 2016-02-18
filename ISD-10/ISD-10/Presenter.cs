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
        public Presenter(IMainForm view)
        {
            this.rating = new Rating();
            rating.Start();
            this.player = new Player(rating.NamePlayer);
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
