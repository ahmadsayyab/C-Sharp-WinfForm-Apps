using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Insert_data_ToDB_WinformApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "Enter your id");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "Enter your name");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                comboBox1.Focus();
                errorProvider3.SetError(this.comboBox1, "Enter your gender");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text) == true)
            {
                textBox4.Focus();
                errorProvider4.SetError(this.textBox4, "Enter your address");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "Enter your id");
            }
            else if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "Enter your name");
            }
            else if (comboBox1.SelectedItem == null)
            {
                comboBox1.Focus();
                errorProvider3.SetError(this.comboBox1, "Enter your gender");
            }
            else if (string.IsNullOrEmpty(textBox4.Text) == true)
            {
                textBox4.Focus();
                errorProvider4.SetError(this.textBox4, "Enter your address");
            }
            else
            {
                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

                SqlConnection conn = new SqlConnection(cs);
                string query = "SELECT * FROM Customer where c_id = @uid";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", textBox1.Text);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
               
                if (reader.HasRows == true)
                {
                    MessageBox.Show(textBox1.Text + " already exist!!!");
                    textBox1.Clear();
                    textBox2.Clear();
                    
                    comboBox1.SelectedItem = null;
                    textBox4.Clear();
                    textBox1.Focus();
                }
                else
                {
                    conn.Close();
                    
                    string query2 = "INSERT INTO Customer VALUES (@id,@name,@gender,@addr)";
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@id", textBox1.Text);
                    cmd2.Parameters.AddWithValue("@name", textBox2.Text);
                    cmd2.Parameters.AddWithValue("@gender", comboBox1.Text);
                    cmd2.Parameters.AddWithValue("@addr", textBox4.Text);
                    
                    conn.Open();

                    int a = cmd2.ExecuteNonQuery();

                    if(a > 0)
                    {
                        MessageBox.Show("Data inserted Successfully");
                        textBox1.Clear();
                        textBox2.Clear();
                        comboBox1.SelectedItem = null;
                        textBox4.Clear();
                        textBox1.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Data insertion failed");
                        textBox1.Clear();
                        textBox2.Clear();
                        comboBox1.SelectedItem = null;
                        textBox4.Clear();
                        textBox1.Focus();
                    }

                    conn.Close();
                }
               

            }
        }
    }
}
