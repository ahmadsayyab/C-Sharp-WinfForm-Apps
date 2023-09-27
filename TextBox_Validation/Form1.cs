using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false; //means allow that value
            }
            else if(ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled= true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = false; //means allow that value
            }

            //for allowing backspace
            else if (ch == 8)
            {
                e.Handled = false;
            }
            //for allowing spacing in between
            else if(ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetterOrDigit(ch))
            {
                e.Handled = false; //means allow that value
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if(ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Enter digits only")
            {
                textBox1.Text = string.Empty;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                textBox1.Text = "Enter digits only";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter text only")
            {
                textBox2.Text = string.Empty;
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                textBox2.Text = "Enter text only";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Enter alphaNumeric values")
            {
                textBox3.Text = string.Empty;
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                textBox3.Text = "Enter alphaNumeric values";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString("dd-MM-yyyy"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //DateTime dt = DateTime.Now;
            //label7.Text = dt.ToString();
            //label7.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker2.Value.ToString("hh:mm:ss-tt"));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
         MessageBox.Show(dateTimePicker2.Value.ToString("dd-MM-yyyy hh:mm:ss-tt"));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label7.Text = dt.ToString();
            label7.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            label8.Text = "Click it to stop the timer";
            label8.Visible = true;
            //change button bg color
            button4.BackColor = Color.Orange;
            //change button font color
            button4.ForeColor = Color.Red;
            //change button height & width
            button4.Width = 200;
            button4.Height = 50;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            //label8.Text = "you did not click the button";
            label8.Visible = false;
            button4.BackColor = Color.Gray;
            button4.ForeColor = Color.Black;
            button4.Width = 196;
            button4.Height = 31;
        }
    }
}
