using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace HOSTEL_ANAGEMENT
{
    public partial class Form1 : MaterialForm

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(materialCheckBox1.Checked)
            {
                materialSingleLineTextField2.UseSystemPasswordChar = false;
            }
            else
                {
                materialSingleLineTextField2.UseSystemPasswordChar = true;
            }
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            
        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {
           
        }

        private void materialCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if(materialCheckBox1.Checked)
            {
                materialSingleLineTextField2.UseSystemPasswordChar = false;
                    
            }
            else
            {
                materialSingleLineTextField2.UseSystemPasswordChar = true;

            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            fulldashboard fd = new fulldashboard();
            fd.WindowState = FormWindowState.Maximized;
            fd.Show();
        }

        private void materialCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
