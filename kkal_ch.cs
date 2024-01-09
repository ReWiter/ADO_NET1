using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class kkal_ch : Form
    {
        public kkal_ch()
        {
            InitializeComponent();
        }

        private void kkal_ch_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataBank.text = textBox1.Text;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            string co = "\'";
            string connString = "Host=localhost;Username=postgres;Password=aA1aA1aA1;Database=postgres";
            string commandString = "select * from market.vegetables_fruits where kkal_100g < " + co + DataBank.text + co;
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

        private void MAX_Click(object sender, EventArgs e)
        {
            int rowsCount = dataGridView1.Rows.Count;
            for (int i = 0; i < rowsCount-1; i++)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
            }
            string co = "\'";
            string connString = "Host=localhost;Username=postgres;Password=aA1aA1aA1;Database=postgres";
            string commandString = "select * from market.vegetables_fruits where kkal_100g > " + co + DataBank.text + co;
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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataBank.text1 = textBox2.Text;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DataBank.text2 = textBox3.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string co = "\'";
            string connString = "Host=localhost;Username=postgres;Password=aA1aA1aA1;Database=postgres";
            string commandString = "select * from market.vegetables_fruits where kkal_100g>" + co + DataBank.text1 + co + " and kkal_100g<" + co + DataBank.text2 + co;
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
