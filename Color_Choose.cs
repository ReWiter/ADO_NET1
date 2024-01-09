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
    public partial class Color_Choose : Form
    {
        public Color_Choose()
        {
            InitializeComponent();
        }

        private void Color_Choose_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataBank.text=textBox1.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string co = "\'";
            string connString = "Host=localhost;Username=postgres;Password=aA1aA1aA1;Database=postgres";
            string commandString = "select count(color) from market.vegetables_fruits where color="+ co+DataBank.text+co;
            DbDataAdapter dbDataAdapter = new NpgsqlDataAdapter(commandString, connString);
            try
            {
                DataTable dataTable = new DataTable();
                dbDataAdapter.Fill(dataTable);
                MessageBox.Show(dataTable.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
