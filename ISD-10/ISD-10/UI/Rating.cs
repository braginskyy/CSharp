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
        void Start();
    }
    public partial class Rating : Form, IRating
    {
        string name;
        string logFile = @".\log.json";
        Result[] table = new Result[10];
        DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Result[]));
        public Rating()
        {
            InitializeComponent();
            Result();
        }
        public void Start()
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
        private void Result()
        {
            if (File.Exists(logFile))
            {
                ReadFile();
            }
            else
            {
                WriteFile();
            }
        }
        public void WriteFile()
        {
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = new Result("Empty", 0);
            }
            using (FileStream fs = new FileStream(logFile, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, table);
            }
        }
        public void ReadFile()
        {
            using (FileStream fs = new FileStream(logFile, FileMode.Open))
            {
                table = (Result[])jsonFormatter.ReadObject(fs);
                for (int i = 0; i < table.Length; i++)
                {
                    resultDataGtid.Rows.Add(table[i].Name, table[i].Hp);
                    resultDataGtid.Sort(resultDataGtid.Columns[1], ListSortDirection.Descending);
                }
            }
        }
    }
}
