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

namespace eClerx.ADO.NET.Day14
{
    public partial class FormAdoEx : Form
    {
        public FormAdoEx()
        {
            InitializeComponent();
        }

        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;
        private void FormAdoEx_Load(object sender, EventArgs e)
        {
            //Create Sql Connection
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=ECXLC5470\SQLEXPRESS;Initial Catalog=HR;Integrated Security=true";

            //Create Sql Command
            cmd = new SqlCommand();
            //passing Connection object
            cmd.Connection = con;
            //Passing Command
            cmd.CommandText = "Select cEmployeeCode, vFirstName,cCity,cState from Employee";

            //open the Connection
            con.Open();

            //execute the command and fetch the data
             reader = cmd.ExecuteReader();

            //Read rhe first Row
            reader.Read();

            //Store into Relevant text boxes
            TxtEmpCode.Text = reader["cEmployeeCode"].ToString();
            TxtFirstName.Text = reader["vFirstName"].ToString();
            TxtCity.Text = reader["cCity"].ToString();
            TxtState.Text = reader["cState"].ToString();

            //Close the reader object
            reader.Close();

            //Dispose the Command Object
            cmd.Dispose();

            //Close the connection
            con.Close();

           
            
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.ClearTest();

        }
        public void ClearTest()
        {
            TxtEmpCode.Text = "";
            TxtFirstName.Clear();
            TxtCity.Clear();
            TxtState.Clear();
            TxtEmpCode.Focus();

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(@"Data Source=ECXLC5470\SQLEXPRESS;Initial Catalog=HR;Integrated Security=true"))
            {
                using(cmd=new SqlCommand("Select vFirstName,cCity,cState from Employee where cEmployeeCode=@EmployeeCode",con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeCode", TxtEmpCode.Text);
                    
                    if(con.State==ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    using (reader=cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            reader.Read();
                            TxtFirstName.Text = reader["vFirstName"].ToString();
                            TxtCity.Text = reader["cCity"].ToString();
                            TxtState.Text = reader["cState"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("No Record");
                            this.ClearTest();
                        }
                    }
                }
            }
        }
    }
}
