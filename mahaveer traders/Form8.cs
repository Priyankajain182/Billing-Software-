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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            string pr1 = @"datasource=localhost;user=root;password=jain8844;database=mahaveer;port=3306";
            MySqlConnection con1 = new MySqlConnection(pr1);
            con1.Open();
            MySqlCommand cmd = con1.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from shop1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con1.Close();


        }
    }
}
