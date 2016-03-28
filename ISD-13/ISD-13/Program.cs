using ISD_13.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISD_13
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var db = new Context())
            {
               // //List<HitLog> combatLog = new List<HitLog>();
               // //List<Combat> c1 = new List<Combat>();
               // //List<Transaction> t1 = new List<Transaction>();
               // //var player1 = new Player() { Login = "TestPlayer1", EMail = "testPlayer1@mail.ru", EMailValid = true, };
               // var player1 = new Player() { Login = "RichPlayer",Password = "123456" , EMail = "testPlayer2@mail.ru", EMailValid = true};
               // db.Players.Add(player1);
               // //db.Players.Add(player2);
               // //db.SaveChanges();               
               // //var profile1 = new Profile() { Id = player1.Id, Date = DateTime.Now, Combats = c1, Transactions = t1 };
               // //var profile2 = new Profile() { Id = player2.Id, Date = DateTime.Now, Combats = c1, Transactions = t1 };

               // var transaction1 = new Transaction() { Date = DateTime.Now, Player = player1, Sum = 500 };
               // var transaction2 = new Transaction() { Date = DateTime.Now, Player = player1, Sum = 700 };
               // var transaction3 = new Transaction() { Date = DateTime.Now, Player = player1, Sum = 700 };
               // //var transaction2 = new Transaction() { Date = DateTime.Now, Player = player2, Sum = 30 };
               // //var transaction3 = new Transaction() { Date = DateTime.Now, Player = player1, Sum = 34 };
               // //var transaction4 = new Transaction() { Date = DateTime.Now, Player = player1, Sum = 12 };
               // //var transaction5 = new Transaction() { Date = DateTime.Now, Player = player2, Sum = 78 };
               // //var transaction6 = new Transaction() { Date = DateTime.Now, Player = player1, Sum = 567 };
               // db.Transactions.Add(transaction1);
               // db.Transactions.Add(transaction2);
               // db.Transactions.Add(transaction3);
               // //db.Transactions.Add(transaction4);
               // //db.Transactions.Add(transaction5);
               // //db.Transactions.Add(transaction6);

               // //db.Profiles.Add(profile1);
               // //db.Profiles.Add(profile2);
               // db.SaveChanges();
                
               // //var hitLog1 = new HitLog() { HitValue = 8, Part = BodyPart.Body, Result = -8 };
               // //var hitLog2 = new HitLog() { HitValue = 10, Part = BodyPart.Head, Result = -10 };
               // //var hitLog3 = new HitLog() { HitValue = 11, Part = BodyPart.Body, Result = 0 };
                
               // //combatLog.Add(hitLog1);
               // //combatLog.Add(hitLog2);
               // //combatLog.Add(hitLog3);
               //// var combat = new Combat() { CombatTypePVP = true, FirstPlayer = player1, SecondPlayer = player2, Experience = 15, Winner = player1, CombatLog = combatLog };
               // //var transaction1 = new Transaction() { Player = player1, Sum = 99 };
               // //var profile = new Profile() { Date = DateTime.Now, Combats = c1, Transactions = t1};
                
               
               // //db.HitLogs.Add(hitLog1);
               // //db.HitLogs.Add(hitLog2);
               // //db.HitLogs.Add(hitLog3);
               // //db.Combat.Add(combat);
               // //db.Transactions.Add(transaction1);
               // //db.SaveChanges();

            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
    }
}
