using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Class1 c)
        {
            InitializeComponent();
            lblName.Text = c.name;
            lblMobile.Text = c.Phone;
            lblAddress.Text = c.Addre;
            lblDOB.Text = c.Dob.ToShortDateString();
            lblemail.Text = c.email;
            string str = "";
            foreach (string s in c.skills)
            {
                str += s + ", ";
            }
            lblSkills.Text = str;
            pictureBox1.Image = c.img;
            lblgend.Text = c.Gend;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Details Submitted Successfully...!");
            this.Close();
            Application.Exit();
        }
    }
}
