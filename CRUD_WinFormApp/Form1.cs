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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_WinFormApp
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);


            string query = "SELECT * FROM Employee where Id = @uid";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@uid", id.Text);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                MessageBox.Show("id " + id.Text + " already exist!!!");
                ResetFields();

            }
            else
            {

                conn.Close();
                string query2 = "INSERT INTO Employee VALUES (@id, @name,@gender, @age, @designation, @salary)";

                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.Parameters.AddWithValue("@id", id.Text);
                cmd2.Parameters.AddWithValue("@name", name.Text);
                cmd2.Parameters.AddWithValue("@gender", gender.SelectedItem);
                cmd2.Parameters.AddWithValue("@age", age.Value);
                cmd2.Parameters.AddWithValue("@designation", designation.SelectedItem);
                cmd2.Parameters.AddWithValue("@salary", salary.Text);

                conn.Open();

                int a = cmd2.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data inserted successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGridView();
                }
                else
                {

                    MessageBox.Show("Insertion Failed!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
                ResetFields();
            }
        }
        void BindGridView()
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "SELECT * FROM Employee";

            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();

            //sda got table from DB, and it fills the DataTable
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            gender.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            age.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
            designation.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            salary.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "UPDATE Employee set id = @id, Name = @name, Gender =@gender, Age = @age,Designation = @designation, Salary =@salary  WHERE Id = @id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@gender", gender.SelectedItem);
            cmd.Parameters.AddWithValue("@age", age.Value);
            cmd.Parameters.AddWithValue("@designation", designation.SelectedItem);
            cmd.Parameters.AddWithValue("@salary", salary.Text);

            conn.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Updated successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridView();
            }
            else
            {

                MessageBox.Show("Updation Failed!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            ResetFields();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "DELETE FROM Employee WHERE Id = @id ";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id.Text);
            

            conn.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data deleted successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridView();
            }
            else
            {

                MessageBox.Show("Deletion Failed!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            ResetFields();
        }

        void ResetFields()
        {
            id.Clear();
            name.Clear();
            gender.SelectedItem = null;
            age.Value = 20;
            designation.SelectedItem = null;
            salary.Clear();
            id.Focus();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(cs);

            //string query = "SELECT * FROM Employee WHERE Name LIKE @name + '%'";
            //SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            //sda.SelectCommand.Parameters.AddWithValue("@name", searchBox.Text);

            //DataTable data = new DataTable();
            //sda.Fill(data);

            //if(data.Rows.Count > 0)
            //{
            //    dataGridView1.DataSource = data;
            //    searchBox.Clear();
            //    searchBox.Focus();
            //}
            //else
            //{
            //    MessageBox.Show("Could not find data!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    dataGridView1.DataSource = null;
            //    searchBox.Clear();
            //    searchBox.Focus();
            //}
        }

        //the below method runs when the text inside textbox changes.
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);

            string query = "SELECT * FROM Employee WHERE Name LIKE @name + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.Parameters.AddWithValue("@name", searchBox.Text);

            DataTable data = new DataTable();
            sda.Fill(data);

            if (data.Rows.Count > 0)
            {
                dataGridView1.DataSource = data;
               
            }
            else
            {
                MessageBox.Show("Could not find data!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null;
                searchBox.Clear();
                searchBox.Focus();
            }
        }
    }
}
