using System;
using System.Windows.Forms;
using MaterialSkin.Controls
    ;
using HOSTEL_ANAGEMENT.
controls;

namespace HOSTEL_ANAGEMENT
{
    public partial class fulldashboard : MaterialForm
    {
        public fulldashboard()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {


            ad dc = new ad();
            showContol(dc);

        }
        public void showContol(Control control)
        {
            content.Controls.Clear();
           
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            content.Controls.Add(control);
        }
       

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            staffcontrol sc = new staffcontrol();
            showContol(sc);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            fee f = new fee();
            showContol(f);
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            room r = new room();
            showContol(r);
        }
    }
}
