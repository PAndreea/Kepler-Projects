using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CExercitii;

namespace WindowsFormsEx
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Ex10.message());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Ex1.message());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Ex2.message());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(Ex3.message(textBox1.Text));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Ex6.message(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string bton = "";
            if(radioButton1.Checked)
            {
                bton = "+";
            }
            if (radioButton2.Checked)
            {
                bton = "-";
            }
            if (radioButton3.Checked)
            {
                bton = "--";
            }
            
            List<string> temp;

            string x = textBox4.Text;
            string[] xArray=x.Split(',');
            temp = xArray.ToList();

            temp =Ex9.exercitiu(bton, textBox3.Text,temp);
            string[] tempArray = temp.ToArray();
            string tempFull= string.Join(",",tempArray);
            textBox4.Text = tempFull;
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Alege imagini.";
            open.Multiselect = true;
            open.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
            DialogResult result = open.ShowDialog();
            if(result==DialogResult.OK)
            {
                string[] files = open.FileNames;
                int x = 10, y = 10;
                int maxHeigth = -1;
                foreach(string imag in files)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(imag);
                    pic.Location = new Point(x, y);
                    Size size = new Size(200, 200);
                    pic.Size = size;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    x += pic.Width + 10;
                    maxHeigth = Math.Max(pic.Height, maxHeigth);
                    if(x>this.ClientSize.Width-100)
                    {
                        x = 10;
                        y += maxHeigth + 10;
                    }
                    this.Imagini.Controls.Add(pic);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }



}
