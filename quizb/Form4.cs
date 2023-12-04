using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizb
{
    public partial class Form4 : Form
    {
        int avage, avage2, avage3 = 0;
        string wrong1a, wrong2b, wrong3c;
        string wrong1, wrong2, wrong3;
        string wronga, wrongb, wrongc;
        int result, result1;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            wrong1a = "3";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            avage2 += 3;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            wrong1a = "3";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
             avage2 += 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            wrong2b = "2,";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            wrong2b = "2,";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            wrong3c = "3";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            
            avage2 += 3;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            wrong3c = "3";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged_1(object sender, EventArgs e)
        {
            avage++;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            avage++;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            avage ++;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            wrongc = "3";
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            wrongc = "3";
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            wrong2b = "2,";
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            wrong2b = "2,";
        }

        private void radioButton12_CheckedChanged_1(object sender, EventArgs e)
        {
            wrong1 = "1,";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            wrong1 = "1,";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            wronga = "1,";
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            wronga = "1,";
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            wrongb = "2,";
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            wrongb = "2,";
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            wrongc = "3";
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            wrongc = "3";
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            avage3 += 5;
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            avage3 += 5;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            avage3 += 5;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            result1 = avage + avage2 + avage3;

            MessageBox.Show("Your Current points:  " + result1 + "\nwrong answer in no. : " + wronga + wrongb + wrongc, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Your Current points:  " + avage + "\nwrong answer in no. : " + wrong1 + wrong2 + wrong3, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = avage + avage2;
            MessageBox.Show("Your Current points:  " + avage2 + "\nwrong answer in no. : " + wrong1a + wrong2b + wrong3c, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }
    }
}
