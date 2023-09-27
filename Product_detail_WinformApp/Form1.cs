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

namespace Product_detail_WinformApp
{
    public partial class Form1 : Form
    {
        //the below global variable will catch the id comming
        //from the GridView, so it will help us in 
        //deleting and updating
        int i;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "INSERT INTO Product_detail VALUES (@name,@company,@category,@price,@stock)";

            SqlCommand cmd = new SqlCommand(query, conn);
            
            cmd.Parameters.AddWithValue("@name", nametb.Text);
            cmd.Parameters.AddWithValue("@company", companytb.Text);
            cmd.Parameters.AddWithValue("@category", categorytb.Text);
            cmd.Parameters.AddWithValue("@price", pricetb.Text);
            cmd.Parameters.AddWithValue("@stock", stocktb.Text);
            

            conn.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data inserted successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                BindGridView();
                ResetControls();
            }
            else
            {
                MessageBox.Show("Data insertion failed!!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            conn.Close();
        }

        void ResetControls()
        {
            nametb.Clear();
            companytb.Clear();
            categorytb.Clear();
            pricetb.Clear();
            stocktb.Clear();
        }

        void BindGridView()
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "SELECT * FROM Product_detail";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            i = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            nametb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            companytb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            categorytb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            pricetb.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            stocktb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
           
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "UPDATE Product_detail SET Name = @name, Company = @company, Category = @category,Price =@price,Stock = @stock WHERE Id = @id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", i);
            cmd.Parameters.AddWithValue("@name", nametb.Text);
            cmd.Parameters.AddWithValue("@company", companytb.Text);
            cmd.Parameters.AddWithValue("@category", categorytb.Text);
            cmd.Parameters.AddWithValue("@price", pricetb.Text);
            cmd.Parameters.AddWithValue("@stock", stocktb.Text);


            conn.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Updated successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BindGridView();
                ResetControls();
            }
            else
            {
                MessageBox.Show("Data failed to update!!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            conn.Close();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "DELETE FROM Product_detail WHERE Id = @id";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", i);
            


            conn.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Deleted successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BindGridView();
                ResetControls();
            }
            else
            {
                MessageBox.Show("Data Deletion failed!!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            conn.Close();
        }
    }
}
