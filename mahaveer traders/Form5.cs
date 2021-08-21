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
    public partial class Form5 : Form
    {

        public Form5()
        {
            
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb2 = new StringBuilder();
            sb2.Append(checkBox1.Text);
            sb2.Append(checkBox2.Text);
            sb2.Append(checkBox3.Text);
            sb2.Append(checkBox4.Text);
            sb2.Append(checkBox5.Text);
            sb2.Append(checkBox6.Text);
            sb2.Append(checkBox7.Text);
            sb2.Append(checkBox8.Text);
            sb2.Append(checkBox9.Text);
            sb2.Append(checkBox10.Text);
            string sb3 = Convert.ToString(sb2);

           
            string r1 = comboBox3.Text;
            string pr = @"datasource=localhost;user=root;password=jain8844;database=mahaveer;port=3306";
            MySqlConnection con = new MySqlConnection(pr);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into shop1(name,address,gstno,contact,type,item,quantity,total,method)values('"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+comboBox1.Text+"','"+textBox1.Text+"','"+textBox7.Text+"','"+textBox8.Text+"','"+r1+"')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            
            if (r1 == "CARD")
            {
                Form6 fm6 = new Form6();
                fm6.Show();
            }
            else
            {
                Form7 fm7 = new Form7();
                fm7.Show();

            }
            con.Close();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string r = comboBox1.Text;

            if (r=="SPICES ")
            {
                checkBox1.Text=("Red Chilli ");
                checkBox2.Text=("Red Chilli Powder");
                checkBox3.Text=(" Turmuric Pieces ");
                checkBox4.Text=("Turmaric Powder ");
                checkBox5.Text=("Charoli ");
                checkBox6.Text=("Masala Cardamom ");
                checkBox7.Text=("Green Cardamom ");
                checkBox8.Text=("Black cardamom  ");
                checkBox9.Text=("Peppercorns ");
                checkBox10.Text=("Black Cumin ");
                
            }
            else
            {
                checkBox1.Text=("Almond ");
                checkBox2.Text=("Cashew");
                checkBox3.Text=(" Dates ");
                checkBox4.Text=("Anjeer ");
                checkBox5.Text=("Raisins ");
                checkBox6.Text=("Aam Papad ");
                checkBox7.Text=("Walnuts");
                checkBox8.Text=("Apricots  ");
                checkBox9.Text=("Peach ");
                checkBox10.Text=("Pistachio ");  
            }    
        }
        private void Form5_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("SPICES ");
            comboBox1.Items.Add("DRYF-FRUITS");
            comboBox3.Items.Add("CASH");
            comboBox3.Items.Add("CARD");
            string pr = @"datasource=localhost;user=root;password=jain8844;port=3306";
            MySqlConnection con = new MySqlConnection(pr);
            con.Open();
            con.Close();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string r1 = comboBox1.Text;

            StringBuilder sb = new StringBuilder();
            if (r1 == "SPICES")
            {
                if (checkBox1.Checked)
                {
                    sb.Append("Red Chilli ,");
                }
                if (checkBox2.Checked)
                {
                    sb.Append("Red Chilli Powder ,");
                }
                if (checkBox3.Checked)
                {
                    sb.Append("Turmuric Pieces ,");
                }
                if (checkBox4.Checked)
                {
                    sb.Append("Turmaric Powder ,");
                }
                if (checkBox5.Checked)
                {
                    sb.Append("Charoli ,");
                }
                if (checkBox6.Checked)
                {
                    sb.Append("Masala Cardamom ,");
                }
                if (checkBox7.Checked)
                {
                    sb.Append("Green Cardamom ,");
                }
                if (checkBox8.Checked)
                {
                    sb.Append("Black cardamom ,");
                }
                if (checkBox9.Checked)
                {
                    sb.Append("Peppercorns ,");
                }
                if (checkBox10.Checked)
                {
                    sb.Append("Black Cumin ,");
                }
            }
            else
            {
                if (checkBox1.Checked)
                {
                    sb.Append(" Almond,");
                }
                if (checkBox2.Checked)
                {
                    sb.Append(" Cashew ,");
                }
                if (checkBox3.Checked)
                {
                    sb.Append(" Dates ,");
                }
                if (checkBox4.Checked)
                {
                    sb.Append("Anjeer  ,");
                }
                if (checkBox5.Checked)
                {
                    sb.Append(" Raisins ,");
                }
                if (checkBox6.Checked)
                {
                    sb.Append(" Aam Papad ,");
                }
                if (checkBox7.Checked)
                {
                    sb.Append("Walnuts  ,");
                }
                if (checkBox8.Checked)
                {
                    sb.Append(" Apricots ,");
                }
                if (checkBox9.Checked)
                {
                    sb.Append("Peach ,");
                }
                if (checkBox10.Checked)
                {
                    sb.Append("Pistachio ,");
                }
            
        }
            string r = Convert.ToString(sb);
            textBox7.Text = r;
            int tot = 0;
            if (checkBox1.Checked)
            {
                tot = tot + 500;
                
            }
            if (checkBox3.Checked)
            {
                tot = tot + 1000;
                
            }
            if (checkBox4.Checked)
            {
                tot = tot + 1000;
                
            }
            if (checkBox5.Checked)
            {
                tot = tot + 1000;
                
            }
            if (checkBox6.Checked)
            {
                tot = tot + 1000;
                
            }
            if (checkBox7.Checked)
            {
                tot = tot + 1000;
                
            }
            if (checkBox8.Checked)
            {
                tot = tot + 1000;
                
            }
            if (checkBox9.Checked)
            {
                tot = tot + 1000;
                
            }
            if (checkBox10.Checked)
            {
                tot = tot + 1000;
                
            }
            string res = Convert.ToString(tot);
            textBox8.Text = res;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form7 fm7 = new Form7();
            fm7.Show();

        }
    }
}
