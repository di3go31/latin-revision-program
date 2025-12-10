using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class teacherCredentials : Form
    {
        public teacherCredentials()
        {
            InitializeComponent();
        }
        private void teacherLoggedin_Load(object sender, EventArgs e)
        {
            
        }

        private void saveteacherDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connectionTeacher = new SqlConnection("Data Source = LAPTOP-CKS3DTGK; Initial Catalog=Latin; Integrated Security=True");
                connectionTeacher.Open();

                SqlCommand teacherDetails = new SqlCommand(@"INSERT INTO [dbo].[Teacher]
                (
                )
                VALUES 
                ('" + subjectTextBox.Text + "', '" + departmentTextBox.Text + "')", connectionTeacher);
                teacherDetails.ExecuteNonQuery();

                SqlCommand insertSubject = new SqlCommand(@"INSERT INTO [dbo].[Subjectteacher_FK]
           ([TeacherID]
           ,[SubjectID])
     VALUES
           ()");
                insertSubject.ExecuteNonQuery();

                SqlCommand insertClass = new SqlCommand(@"INSERT INTO [dbo].[ClassCode]
           ([ClassCode]
           ,[TeacherID]
           ,[SubjectID])
     VALUES
           ()");
                insertClass.ExecuteNonQuery();

                SqlCommand insertStudent = new SqlCommand(@"INSERT INTO [dbo].[StudentTeacher]
           ([StudentID]
           ,[TeacherID])
     VALUES
           ()");

                DialogResult result =  MessageBox.Show("Do you want to add another class code?");
                if (result == DialogResult.Yes)
                {
                    subjectTextBox.Text = "";
                    classCodeTextBox.Text = "";
                }

                else if( result == DialogResult.No)
                {
                    MessageBox.Show("Registered successfully");
                    this.Close();
                    Login login1 = new Login();
                    login1.Show();
                    this.Hide();
                }

                }

                catch(Exception)
                {
                    MessageBox.Show("Enter details correctly");
                }
            }
                
        }
    }