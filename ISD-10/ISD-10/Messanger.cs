using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_10
{
    public interface IMessanger
    {
        void Message();
    }
    class Messanger : IMessanger
    {
        IPlayer player;
        IBot bot;
        IMainForm view;        
        public Messanger(IPlayer player, IBot bot, IMainForm view)
        {
            this.player = player;
            this.bot = bot;
            this.view = view;
        }
        public void Message()
        {
            player.Wound += player_Wound;
            player.Block += player_Block;
            player.Death += player_Death;
            bot.Wound += player_Wound;
            bot.Block += player_Block;
            bot.Death += player_Death;            
        }
        private void player_Wound(object sender, InfoEventArgs e)
        {
            view.Log = "Игрок " + e.Name.ToUpper() + " получил урон " + e.Damage + " хп. " + " Осталось " + e.Hp + " хп. ";
        }
        private void player_Block(object sender, InfoEventArgs e)
        {
            view.Log = "Игрок " + e.Name.ToUpper() + " заблокировал удар ";
        }
        private void player_Death(object sender, InfoEventArgs e)
        {
            view.Log = "Игрок " + e.Name.ToUpper() + " повержен " + e.Hp + "хп.";
        }       
    }
}
