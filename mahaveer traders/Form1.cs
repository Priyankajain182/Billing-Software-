using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace mahaveer_traders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pr = @"datasource=localhost;user=root;password=jain8844;port=3306";
            MySqlConnection con = new MySqlConnection(pr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                MessageBox.Show("connected");

            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();

            string pr = @"datasource=localhost;user=root;password=jain8844;port=3306";
            MySqlConnection con = new MySqlConnection(pr);
            con.Open();

        }
    }
}
