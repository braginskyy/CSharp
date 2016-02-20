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

namespace ISD_10
{
    public interface IRating
    {
        string NamePlayer { get; }
        void StartWindow();
        void ShowTableStat(Result[] table);        
    }
    public partial class Rating : Form, IRating
    {        
        string name;        
        public Rating()
        {              
            InitializeComponent();
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
            name = InsertNameTxt.Text;
            if (InsertNameTxt.Text != "Введите ваше имя" && InsertNameTxt.Text != "")
            {
                this.Hide();
            }
        }
        private void InsertNameTxt_Click(object sender, EventArgs e)
        {
            InsertNameTxt.Text = "";
        } 
        public void ShowTableStat(Result[] table)
        {
            for (int i = 0; i < table.Length; i++)
            {
                resultDataGtid.Rows.Add(table[i].Name, table[i].Hp);
                resultDataGtid.Sort(resultDataGtid.Columns[1], ListSortDirection.Descending);
            }
        }
    }
}
