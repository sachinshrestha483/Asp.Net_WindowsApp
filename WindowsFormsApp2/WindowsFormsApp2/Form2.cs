using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KCSCRR3\SQLEXPRESS;Initial Catalog=WINDOWSFORMAPP;Integrated Security=True");
        
        //SqlCommand cmd = new SqlCommand("sp_insert", con);
        
        //cmd.CommandType = CommandType.StoredProcedure;  

        private void Button1_Click(object sender, EventArgs e)
        {
            
            con.Open();

            int t= 0;
            if (checkBox1.Checked)
            {
                t= 1;
            }

            SqlCommand cmd = new SqlCommand("insert into StudentWindowsFormApp values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox3.Text + "', '" + 1 + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully.");
            con.Close();
           
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
