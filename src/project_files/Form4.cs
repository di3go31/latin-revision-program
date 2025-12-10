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

namespace Project
{
    public partial class ParentCredentials : Form
    {
        public ParentCredentials()
        {
            InitializeComponent();
        }
        private void ParentLoggedin_Load(object sender, EventArgs e)
        {
         
        }

        private void saveParentDetailsButton_Click(object sender, EventArgs e)
        {
            SqlConnection connectionParent = new SqlConnection("Data Source = LAPTOP-CKS3DTGK; Initial Catalog=Latin; Integrated Security=True");
            connectionParent.Open();
            SqlCommand newDetails = new SqlCommand("Select * from Parent", connectionParent);
            SqlCommand parentDetails = new SqlCommand(@"INSERT INTO [dbo].[Parent]
           ([Address]
           ,[Postcode]
           ,[NumberofKids]
           ,[NameofChild])
     VALUES
           ('" + addressTextBox.Text + "', '" + postcodeTextBox.Text + "', '" + NoofKidsTextBox.Text + "', " + "'" + nameChildTextBox.Text + "')", connectionParent);

            if (addressTextBox.Text == "" || postcodeTextBox.Text == "" || NoofKidsTextBox.Text == "" || nameChildTextBox.Text == "")
            {
                MessageBox.Show("Enter details to register");
            }
            else
            {
                try
                {
                    newDetails.ExecuteNonQuery();
                    parentDetails.ExecuteNonQuery();
                    MessageBox.Show("Registered successfully");
                    this.Close();
                    // open a new login form after the user is registered so they can login 
                    Login login2 = new Login();
                    login2.Show();
                    this.Hide();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Enter details in correct form");
                }
            }
        }
    }
}
