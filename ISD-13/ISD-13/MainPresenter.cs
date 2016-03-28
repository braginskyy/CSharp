using ISD_13.Data;
using ISD_13.Interfaces;
using ISD_13.Repository;
using ISD_13.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13
{
    public class MainPresenter
    {
        private readonly IMainForm view;
        private readonly IUnitOfWork unitOfWork;        
        public MainPresenter(MainForm view)
        {
            this.view = view;
            this.unitOfWork = new UnitOfWork(new Context());
            view.LoadTable += view_LoadTable;
            view.TopTenUsersBySum += view_TopTenUsersBySum;
            view.ValidEMail += view_ValidEMail;
            view.LoadTransaction += view_LoadTransaction;
        }

        void view_LoadTransaction(object sender, EventArgs e)
        {
            view.TransactionTable = unitOfWork.Transaction.FindAllTransactionByUserId(view.CurrentUserId);
        }

        void view_ValidEMail(object sender, EventArgs e)
        {
            view.MainTable = unitOfWork.Player.FindUsersByValidEmail();            
        }

        void view_TopTenUsersBySum(object sender, EventArgs e)
        {           
            view.MainTable = unitOfWork.Transaction.TopTenUsersBySum();           
        }

        void view_LoadTable(object sender, EventArgs e)
        {
            view.MainTable = unitOfWork.Player.GetAll().ToList();
            //var player1 = new Player() { Login = "TestPlayer1", EMail = "testPlayer1@mail.ru", EMailValid = true, Date = 222 };
            //unitOfWork.Player.Create(player1);
            //unitOfWork.Save();
        }
    }
}
