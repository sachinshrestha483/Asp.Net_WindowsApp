using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 from2obj=new Form2();
            //MoreActions objUI = new MoreActions();
            from2obj.ShowDialog();
            this.Close();
        }
    }
}
