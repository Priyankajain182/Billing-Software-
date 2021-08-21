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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string pr = @"datasource=localhost;user=root;password=jain8844;port=3306";
            MySqlConnection con = new MySqlConnection(pr);
            con.Open();
            con.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string r1 = textBox1.Text;
            string r2 = textBox2.Text;

            if (r1==""&&r2=="")
            {
                MessageBox.Show("Enter Valid Input");
            }
            else
            {
                string pr = @"datasource=localhost;user=root;password=jain8844;database=mahaveer;port=3306";
                MySqlConnection con = new MySqlConnection(pr);
                string r = "select *from register";
                MySqlCommand com1 = new MySqlCommand(r, con);
                con.Open();
                MySqlDataReader DR1 = com1.ExecuteReader();
                while (DR1.Read())
                {
                    string s1 = DR1.GetValue(0).ToString();
                    string s3 = DR1.GetValue(3).ToString();
                    if (r1 == s1 && r2 == s3)
                    {
                        Form4 fm4 = new Form4();
                        fm4.Show();
                    }
                   
                }
                con.Close();

            }
            



        }
    }
}
