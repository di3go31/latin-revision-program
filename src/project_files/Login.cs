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
    public partial class Login : Form 
    {
        // create new connection
        SqlConnection loginConnection = new SqlConnection("Data Source = LAPTOP-CKS3DTGK; Initial Catalog=LatinRevision; Integrated Security=True");
        // meaningful identifier names
        public string profileName, usernameHashValue;
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            loginConnection.Open();
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            // open the register form
            Register position = new Register();
            position.Show();
            this.Hide();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // will exit the application
            Application.Exit();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            // get username and password from database and compare them against the values given by the user
            // select count(*) means that the number of records is selected 
            // the count function is an aggregate SQL function
            
            // select the name of the student and pass it as an argument to the constructor of StudentPage
            // this is to identify which student is answering the questions each time

            Register register = new Register();
            usernameHashValue = register.hashUsername(usernameTextboxLogin.Text);
            SqlDataAdapter adapter = new SqlDataAdapter("Select count(*) from UserProfile where Username = '" + usernameHashValue + "' and Password = '"+passwordTextboxLogin.Text+"' and Role = '"+roleComboboxLogin.Text+"'", loginConnection);

            SqlCommand name = new SqlCommand("Select Name from UserProfile where profileID = (Select profileID from UserProfile where Username = '" + usernameHashValue + "')", loginConnection);
            name.ExecuteNonQuery();
            SqlDataReader sqlData = name.ExecuteReader();
            while(sqlData.Read())
            {
                profileName = sqlData["Name"].ToString();
            }
            sqlData.Close();

            DataTable datatable = new DataTable();
            adapter.Fill(datatable);

            // checks if username and password match the ones saved to the database
            // this means that there is one record which contains the provided parameters
            if (datatable.Rows[0][0].ToString() == ("1"))
            {
                try
                {
                    if (roleComboboxLogin.SelectedItem.ToString().Contains("Student"))
                    {
                        // use of object oriented programming
                        // call specific methods depending on the user which is more efficient than having all the code on the same method which is not necessary
                        studentLogin();
                    }

                    if (roleComboboxLogin.SelectedItem.ToString().Contains("Teacher"))
                    {
                        teacherLogin();
                    }

                    if (roleComboboxLogin.SelectedItem.ToString().Contains("Parent"))
                    {
                        parentLogin();
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("Enter login details");
                }
            }

            else
            {
                MessageBox.Show("Incorrect details", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void studentLogin()
        {
            // select both student and teacher ID to pass the value as an argument to the constructor of the next form to be opened
            SqlCommand selectID = new SqlCommand("Select StudentID from Student where profileID = (Select profileID from UserProfile where Username = '" + usernameHashValue + "')", loginConnection);
            int idProfile = 0;
            SqlDataReader studentIDReader = selectID.ExecuteReader();
            while (studentIDReader.Read())
            {
                idProfile = Int32.Parse((String.Format("{0}", studentIDReader["StudentID"])));
            }
            studentIDReader.Close();

            // open a specific form if the user is a student, parent or teacher
            StudentPage studentPage = new StudentPage(profileName, idProfile);
            studentPage.Show();
            this.Hide();
        }

        private void teacherLogin()
        {
            SqlCommand selectTeacherID = new SqlCommand("Select TeacherID from Teacher where profileID = (Select profileID from UserProfile where Username = '" + usernameHashValue + "')", loginConnection);
            int ProfileID = 0;
            SqlDataReader Reader = selectTeacherID.ExecuteReader();
            while (Reader.Read())
            {
                ProfileID = Int32.Parse((String.Format("{0}", Reader["TeacherID"])));
            }
            Reader.Close();

            teacherLoggedin teacher = new teacherLoggedin(profileName, ProfileID);
            teacher.Show();
            this.Hide();
        }
        private void parentLogin()
        {
            SqlCommand selectParentID = new SqlCommand("Select ParentID from Parent where profileID = (Select profileID from UserProfile where Username = '" + usernameHashValue + "')", loginConnection);
            int IDParent = 0;
            SqlDataReader Reader = selectParentID.ExecuteReader();
            while (Reader.Read())
            {
                IDParent = Int32.Parse((String.Format("{0}", Reader["ParentID"])));
            }
            Reader.Close();

            // give the name of the user to the other forms using the same string in which the name retrieved from the database is stored
            ParentLoggedin parent = new ParentLoggedin(profileName, IDParent);
            parent.Show();
            this.Hide();
        }
    }
}