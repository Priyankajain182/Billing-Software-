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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string pr = @"datasource=localhost;user=root;password=jain8844;port=3306";
            MySqlConnection con = new MySqlConnection(pr);
            con.Open();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pr = @"datasource=localhost;user=root;password=jain8844;database=mahaveer;port=3306";
            MySqlConnection con = new MySqlConnection(pr);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            Form7 fm7 = new Form7();
            fm7.Show();


        }
    }
}
