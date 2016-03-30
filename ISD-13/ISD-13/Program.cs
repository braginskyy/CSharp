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
                var player1 = new Player() { Login = "FirstPlayer", Password = "123456", EMail = "testPlayer1@mail.ru", EMailValid = true };
                var player2 = new Player() { Login = "SecondPlayer", Password = "000000", EMail = "Player2@mail.ru", EMailValid = true };
                db.Players.AddRange(new List<Player> { player1, player2 });
                db.SaveChanges();


                var hit1 = new HitLog() { HitValue = 10, Part = BodyPart.Head, Result = 8, Date = DateTime.Now };
                var hit2 = new HitLog() { HitValue = 12, Part = BodyPart.Body, Result = 0, Date = DateTime.Now };
                var hit3 = new HitLog() { HitValue = 17, Part = BodyPart.Head, Result = 2, Date = DateTime.Now };
                var hit4 = new HitLog() { HitValue = 11, Part = BodyPart.Legs, Result = 8, Date = DateTime.Now };
                var hit5 = new HitLog() { HitValue = 7, Part = BodyPart.Legs, Result = 0, Date = DateTime.Now };
                var hit6 = new HitLog() { HitValue = 15, Part = BodyPart.Head, Result = 8, Date = DateTime.Now };
                db.HitLogs.AddRange(new List<HitLog> { hit1, hit2, hit3, hit4, hit5, hit6 });

                var transaction1 = new Transaction() { Date = DateTime.Now, Player = player1, Sum = 100 };
                var transaction2 = new Transaction() { Date = DateTime.Now, Player = player1, Sum = 200 };
                var transaction3 = new Transaction() { Date = DateTime.Now, Player = player1, Sum = 150 };
                var transaction4 = new Transaction() { Date = DateTime.Now, Player = player2, Sum = 70 };
                var transaction5 = new Transaction() { Date = DateTime.Now, Player = player2, Sum = 40 };
                var transaction6 = new Transaction() { Date = DateTime.Now, Player = player2, Sum = 120 };
                db.Transactions.AddRange(new List<Transaction> { transaction1, transaction2, transaction3, transaction4, transaction5, transaction6 });

                var profile1 = new Profile() { Id = player1.Id, Date = DateTime.Now, Transactions = new List<Transaction>() { transaction1, transaction2, transaction3 } };
                var profile2 = new Profile() { Id = player2.Id, Date = DateTime.Now, Transactions = new List<Transaction>() { transaction4, transaction5, transaction6 } };

                Combat combat1 = new Combat { CombatTypePVP = true, FirstPlayer = player1, SecondPlayer = player2, Date = DateTime.Now, Winner = player1, Experience = 15, CombatLog = new List<HitLog>() { hit1, hit2 } };
                combat1.Profiles.Add(profile1);
                combat1.Profiles.Add(profile2);
                Combat combat2 = new Combat { CombatTypePVP = true, FirstPlayer = player1, SecondPlayer = player2, Date = DateTime.Now, Winner = player2, Experience = 15, CombatLog = new List<HitLog>() { hit3, hit4 } };
                combat2.Profiles.Add(profile1);
                combat2.Profiles.Add(profile2);
                db.Combats.Add(combat1);
                db.Combats.Add(combat2);
                db.SaveChanges();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
    }
}
