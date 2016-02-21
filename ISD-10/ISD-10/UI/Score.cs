using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using GameCore;

namespace Combats
{
    public partial class Score : Form, IScore
    {
        string name;
        public Score()
        {
            InitializeComponent();
            rulesBox.Text += "Победа: игрок получает + 5 статов + 10 хп" + Environment.NewLine;
            rulesBox.Text += "Ничья: игрок и бот получают + 5 хп" + Environment.NewLine;
            rulesBox.Text += "Поражение: бот получает + 10 статов + 20 хп" + Environment.NewLine;
        }
        public void StartWindow()
        {
            ShowDialog();
        }
        public string NamePlayer
        {
            get { return name; }
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            name = insertNameTxt.Text;
            if (insertNameTxt.Text != "Введите ваше имя" && insertNameTxt.Text != "")
            {
                this.Hide();
            }
        }
        private void InsertNameTxt_Click(object sender, EventArgs e)
        {
            insertNameTxt.Text = "";
        }
        public void ShowTableStat(Result[] table)
        {
            for (int i = 0; i < table.Length; i++)
            {
                resultDataGtid.Rows.Add(i + 1, table[i].Name, table[i].Hp);
                resultDataGtid.Sort(resultDataGtid.Columns[2], ListSortDirection.Descending);
            }
        }
    }
}
