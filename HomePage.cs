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
            clo_load();
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
                MessageBox.Show("Enter status first");
                return;
            }
            string query = "insert into dbo.Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) values('" + this.firstT.Text + "','" + this.lastT.Text + "','" + this.contactT.Text + "','" + this.emailT.Text + "','" + this.regT.Text + "','" + this.statusT.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                loadGrid();
                con.Close();
                firstT.Clear();
                lastT.Clear();
                contactT.Clear();
                emailT.Clear();
                regT.Clear();
                statusT.Clear();
                MessageBox.Show("succesfully saved");

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
        { 
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "Delete from Student where Id= '"+StdId+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show(firstT.Text+" "+lastT.Text+"Student Deleted");
            loadGrid();




        }

        private void deleteAllbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
                string query = "DELETE FROM dbo.Student";
                SqlCommand cmd = new SqlCommand(query, con);
                //SqlDataReader reader;
                try
                {


                    //reader = cmd.ExecuteReader();
                    cmd.ExecuteNonQuery();
                    loadGrid();
                    MessageBox.Show("cleared successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            
            

        }
        int StdId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StdId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            firstT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lastT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            contactT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            regT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            emailT.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            statusT.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void seatchbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if(searchDropdown.Text == "")
            {
                MessageBox.Show("please select what to search");
            }
            
            if(searchDropdown.Text == "Registeration number")
            {
                string query = "select * from dbo.Student where RegistrationNumber like '" + searchT.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();
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
            }
            if (searchDropdown.Text == "First name")
            {
                string query = "select * from dbo.Student where FirstName like '" + searchT.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {

                    cmd.ExecuteNonQuery();
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
            }
            if (searchDropdown.Text == "Last name")
            {
                string query = "select * from dbo.Student where LastName like '" + searchT.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();

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
            }
            if (searchDropdown.Text == "E-mail")
            {
                string query = "select * from dbo.Student where Email like '" + searchT.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {

                    cmd.ExecuteNonQuery();
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
            }
            if (searchDropdown.Text == "Status")
            {
                string query = "select * from dbo.Student where Status like '" + searchT.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();

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
            }
            if (searchDropdown.Text == "Contact")
            {
                string query = "select * from dbo.Student where Contact like '" + searchT.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();
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
            }

        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            loadGrid();
        }


 /// <summary>
 /// //////////////Student Management Ends Here///////////////////////////////////////////////////////////////////////
 /// </summary>
 /// <param name="sender"></param>
 /// <param name="e"></param>
 
        public void clo_load()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string x = "SELECT * FROM Clo";
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
                dataGridView2.DataSource = bSource;
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

        private void cloCreatebtn_Click(object sender, EventArgs e)
        {
            DateTime date = System.DateTime.Now;
            SqlConnection con = new SqlConnection(conString);


            
            string query = "insert into dbo.Clo(Name,DateCreated,DateUpdated) values ('" + this.CloSearchText.Text + "','"+date+"', '"+date+ "')";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                CloSearchText.Clear();
                clo_load();
                MessageBox.Show("succesfully created");

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

        private void cloRefresh_Click(object sender, EventArgs e)
        {
            clo_load();
        }

        private void cloSearchbtn_Click(object sender, EventArgs e)
        {
            if (CloSearchText.Text == "")
            {
                MessageBox.Show("type clo name to search");
                return;
            }
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "select * from dbo.Clo where Name like '" + CloSearchText.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dataSet = new DataTable();
                sda.Fill(dataSet);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataSet;
                dataGridView2.DataSource = bSource;
                sda.Update(dataSet);
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (CloSearchText.Text == "")
            {
                MessageBox.Show("select a clo or type clo name");
                return;
            }
            DateTime date = DateTime.Now;
            SqlConnection con = new SqlConnection(conString);
            string query = "update Clo set DateUpdated='"+date+ "', Name ='"+CloSearchText.Text+"' where  Id = '" + CloId + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                CloSearchText.Clear();
                clo_load();
                MessageBox.Show(CloSearchText.Text + " has been updated");

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

        private void btnUpdateStd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string query = "Update Student SET FirstName = '"+firstT.Text+"', LastName= '"+lastT.Text+"',Contact='"+contactT.Text+"',RegistrationNumber='"+regT.Text+"', Email='"+emailT.Text+"', Status = '"+statusT.Text+"' where Id = '"+StdId+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show(firstT.Text + " " + lastT.Text + " Has Been Updated");
            loadGrid();
        }
        int CloId;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CloId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            CloSearchText.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void deleteCLObtn_Click(object sender, EventArgs e)
        {
            if (CloSearchText.Text == "")
            {
                MessageBox.Show("select a clo or type clo name");
                return;
            }
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "delete from CLo where Id='" + CloId + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            clo_load();
            MessageBox.Show(CloSearchText.Text + " has been Deleted");
        }
           

//////////////////////////////////////////////////////////////clo ENDS/////////////////////////////////////////////////////
        public void Rubric_load()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string x = "SELECT * FROM Rubric";
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

        private void cloSearchRubricbtn_Click(object sender, EventArgs e)
        {
            if (searchCLoRubric.Text == "")
            {
                MessageBox.Show("type clo name to search");
                return;
            }
           

        }
    
    }
    
}