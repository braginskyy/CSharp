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
        }
        void view_FightClick(object sender, EventArgs e)
        {
            controller.Base(view, player, bot);
            controller.Fight(view, player, bot);
            controller.View(view, player, bot);
        }        
    }
}
