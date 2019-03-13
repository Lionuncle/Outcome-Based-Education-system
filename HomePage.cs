//@@ -0,0 +1,121 @@
﻿using System;
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int rowID = int.Parse(dataGridView1[0, selectedIndex].Value.ToString());
                string query = "DELETE FROM dbo.Student";
                SqlCommand cmd = new SqlCommand(query, con);
                //SqlDataReader reader;
                try
                {


                    //reader = cmd.ExecuteReader();
                    cmd.ExecuteNonQuery();
                    loadGrid();
                    MessageBox.Show("Deleted succesfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
            else
            {
                MessageBox.Show("Please select atleat 1 entire row");
            }
                

        
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
    }
}