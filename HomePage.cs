using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HireACarUI
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            loadGrid();
        }
        public string conString = "Data Source=AQIB;Initial Catalog=ProjectB;Integrated Security=True";
        public void loadGrid()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string x = "SELECT * FROM Student";
            SqlCommand cmd = new SqlCommand(x, con);
            cmd.ExecuteNonQuery();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dataSet = new DataTable();
                sda.Fill(dataSet);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataSet;
                dataGridView1.DataSource = bSource;
                sda.Update(dataSet);
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }

        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            //con.Open();

            int parsedValue;
            
            if (!int.TryParse(statusT.Text, out parsedValue))
            {
                MessageBox.Show("Enter only numbers in status");
                return;
            }
            string query = "insert into dbo.Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) values('" + this.firstT.Text + "','" + this.lastT.Text + "','" + this.contactT.Text + "','" + this.emailT.Text + "','" + this.regT.Text + "','" + this.statusT.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                loadGrid();
                con.Close();
                MessageBox.Show("Data saved succesfully");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        { /*
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int rowID = int.Parse(dataGridView1[0, selectedIndex].Value.ToString());
                string query = "DELETE FROM Table1 WHERE RowID = @RowID";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader;
                try
                {


                    reader = cmd.ExecuteReader();
                    loadGrid();
                    MessageBox.Show("Deleted succesfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
                

        */
        }
    }
}
