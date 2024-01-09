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
    public partial class Color : Form
    {
        public Color()
        {
            InitializeComponent();
        }

        private void Color_Load(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Username=postgres;Password=aA1aA1aA1;Database=postgres";
            string comandString = "select count(color),color from market.vegetables_fruits group by color";
            using (DbDataAdapter dbDataAdapter = new NpgsqlDataAdapter(comandString, connString))
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
