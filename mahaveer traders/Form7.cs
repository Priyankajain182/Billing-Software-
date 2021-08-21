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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            string pr = @"datasource=localhost;user=root;password=jain8844;port=3306";
            MySqlConnection con = new MySqlConnection(pr);
            con.Open();
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string r1 = textBox1.Text;
            int ch = 0;

           
                string pr = @"datasource=localhost;user=root;password=jain8844;database=mahaveer;port=3306";
                MySqlConnection con = new MySqlConnection(pr);
                string r = "select *from shop1";
                MySqlCommand com1 = new MySqlCommand(r, con);
                con.Open();
                MySqlDataReader DR1 = com1.ExecuteReader();
                while (DR1.Read())
                {
                    string s1 = DR1.GetValue(3).ToString();
                    
                    if (r1 == s1 )
                    {
                    ch = 1;
                    break;
                   
                    }
                    else
                    {
                    ch = -1;
                    }
                }
            if (ch == 1)
            {
                Form8 f8 = new Form8();
                f8.Show();


            }
            else
            {
                MessageBox.Show("Enter Valid contact Number");


            }



            
        }
        
    }
}