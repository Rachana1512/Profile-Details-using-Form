using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Image img;
        Class1 ob1;


        ListBox list;

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Welcome to Your Profile...!");
            ob1 = new Class1();

            lbaddress.Visible = false;
            tbaddress.Visible = false;

            list = new ListBox();
            list.Size = new System.Drawing.Size(200, 78);
            list.Location = new System.Drawing.Point(282, 340);
            this.Controls.Add(list);
            list.MultiColumn = false;
            list.SelectionMode = SelectionMode.MultiExtended;

            list.BeginUpdate();

            list.Items.Add("DotNet");
            list.Items.Add("Core Java");
            list.Items.Add("Ado & Asp.Net");
            list.Items.Add("PLSql");
            list.Items.Add("Angular JS");
            list.Items.Add("React JS");
            list.Items.Add("MVC");

            list.EndUpdate();

            // Select three items from the ListBox.
            list.SetSelected(0, true);
            list.SetSelected(2, true);
            // list.SetSelected(5, true);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                lbaddress.Visible = true;
                tbaddress.Visible = true;
            }
            else
            {
                lbaddress.Visible = false;
                tbaddress.Visible = false;
            }
        }
      
        //IMAGE BUTTON SELECTION
        private void btnimage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG (*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(f.FileName);
                pictureBox1.Image = img;
            }
        }

        //BUTTON FOR RESUME FILE
        private void btnresume_Click(object sender, EventArgs e)
        {
            OpenFileDialog f1 = new OpenFileDialog();
            f1.Filter = "All files (*.*)|*.*";
            if (f1.ShowDialog() == DialogResult.OK)
            {
                //ob1.Resume = File.ReadAllText(f1.FileName);
                //richTextBox1.Text = ob1.Resume;
                //object file;
                //printPreviewControl1.Document.DocumentName=
            }
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            ob1.name = tbname.Text;
            ob1.img = img;
            ob1.Phone = tbmobile.Text.ToString();
            ob1.email = tbemail.Text;
            ob1.Gend = (radioButton1.Checked) ? radioButton1.Text : radioButton2.Text;
            foreach (string str in list.SelectedItems)
            {
                ob1.skills.Add(str);
            }
            ob1.Dob = dateTimePicker2.Value;
            ob1.Addre = tbaddress.Text;
            Form2 ob = new Form2(ob1);
            this.Hide();
            ob.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
