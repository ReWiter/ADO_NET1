using System;
using Npgsql;
using System.Windows.Forms;
using System.Data.Common;
using System.Data;
using System.Data.Odbc;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Color_Choose col;
        Color coll;
        kkal_ch kk;
        string connString = "Host=localhost;Username=postgres;Password=aA1aA1aA1;Database=postgres";
        public string Press(DbDataAdapter e)
        {
            DataTable dataTable = new DataTable();
            e.Fill(dataTable);
           return dataTable.Rows[0][0].ToString();
        }
        public void Quary(string connString,string comandString)
        {
            using (DbDataAdapter dbDataAdapter = new NpgsqlDataAdapter(comandString, connString))
            {
                try
                {
                    MessageBox.Show(Press(dbDataAdapter));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR");
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            string comandString = "select * from market.vegetables_fruits";
            using(DbDataAdapter dbDataAdapter= new NpgsqlDataAdapter(comandString, connString))
            {
                try
                {
                    dbDataAdapter.Fill(dataSet1);
                    dataGridView1.DataSource = dataSet1.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BMX_Click(object sender, EventArgs e)
        {
            string comandString = "select max(kkal_100g) from market.vegetables_fruits";
            Quary(connString,comandString);
        }

        private void BMN_Click(object sender, EventArgs e)
        {
            string comandString = "select min(kkal_100g) from market.vegetables_fruits";
            Quary(connString, comandString);
        }

        private void BA_Click(object sender, EventArgs e)
        {
            string comandString = "select avg(kkal_100g) from market.vegetables_fruits";
            Quary(connString, comandString);
        }

        private void Bvegetale_Click(object sender, EventArgs e)
        {
            string comandString = "select count(type) from market.vegetables_fruits where type='vegetable'";
            Quary(connString, comandString);
        }

        private void Bfruit_Click(object sender, EventArgs e)
        {
            string comandString = "select count(type) from market.vegetables_fruits where type='fruit'";
            Quary(connString, comandString);
        }

        private void Color_CH_Click(object sender, EventArgs e)
        {
            col = new Color_Choose();
            col.Show();
        }

        private void Color_Click(object sender, EventArgs e)
        {
            coll = new Color();
            coll.Show();
        }

        private void kkal_ch_Click(object sender, EventArgs e)
        {
            kk=new kkal_ch();
            kk.Show();
        }

        private void color_fin_Click(object sender, EventArgs e)
        {
            int rowsCount = dataGridView1.Rows.Count;
            for (int i = 0; i < rowsCount - 1; i++)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
            }
            string connString = "Host=localhost;Username=postgres;Password=aA1aA1aA1;Database=postgres";
            string commandString = "select * from market.vegetables_fruits where color='green' or color='red' ";
            using (DbDataAdapter dbDataAdapter = new NpgsqlDataAdapter(commandString, connString))
            {
                try
                {
                    dbDataAdapter.Fill(dataSet1);
                    dataGridView1.DataSource = dataSet1.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR");
                }
            }
        }
    }
}
