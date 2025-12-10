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
using System.Collections;

namespace Project
{
    public partial class Register : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = LAPTOP-CKS3DTGK; Initial Catalog=LatinRevision; Integrated Security=True");
   
        public bool goForward = false, accountCreate;
        public string username;
        public int usernameHash, profileIDValue;
        public Register()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {
            // hide the button to add a new class for the student as this is shown only if the student wishes to add a new class
            addClassButton.Hide();;
            connection.Open();
        }
        private void enterDetailsButton_Click(object sender, EventArgs e)
        {
            // print message box if values are left empty
            if (nameTextboxRegister.Text == "" || surnameTextboxRegister.Text == "" || usernameTextboxRegister.Text == "" || passwordTextboxRegister.Text == "" || mailAddressTextbox.Text == "" || roleComboBox.Text == "" || telephoneTextboxRegister.Text == "")
            {
                MessageBox.Show("Enter all details");
            }

            else
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Username from UserProfile where Username = '" + hashUsername(usernameTextboxRegister.Text) + "'", connection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                // check to see if username already exists in the database by looking for an existing record in the database equal to the one given by the user
                if (dataTable.Rows.Count >= 1)
                {
                    MessageBox.Show("Username already exists");
                }
            
                else
                {
                    // insert user login details into the generic table UserProfile
                    SqlCommand command = new SqlCommand(@"INSERT INTO [dbo].[UserProfile]
                    ([Username]
                    ,[Password]
                    ,[Name]
                    ,[Surname]
                    ,[Mail]
                    ,[Telephone]
                    ,[Role])
                VALUES
                ('" + hashUsername(usernameTextboxRegister.Text) + "', " + "'" + passwordTextboxRegister.Text + "','" + nameTextboxRegister.Text + "', '" + surnameTextboxRegister.Text + "',  '" + mailAddressTextbox.Text + "', " +
                    "'" + telephoneTextboxRegister.Text + "', '" + roleComboBox.Text + "')", connection);
                    command.ExecuteNonQuery();

                    // query to select profile ID for the username which has just been created
                    SqlCommand profile = new SqlCommand("Select profileID from UserProfile where Username = '" + hashUsername(usernameTextboxRegister.Text) + "'", connection);
                    SqlDataReader sqlDataReader = profile.ExecuteReader();
                    while(sqlDataReader.Read())
                    {
                        profileIDValue = Int32.Parse((String.Format("{0}", sqlDataReader["profileID"])));
                    }
                    sqlDataReader.Close();

                    // create specific account
                    // the class code inserted by the teacher is assumed to not be an existing one, so it will be added to the database in the class code table
                    // the class code has therefore to be unique so the system will check for existing class code before inserting to sql

                    if (roleComboBox.SelectedItem.ToString().Contains("Teacher"))
                    {
                        // call specific method for each user which will store their details in the database and handle exceptions to avoid having all references to sql tables in the same method which is not needed and would be less efiicient as only one user can register at a time
                        registerTeacher();
                    }

                    else if (roleComboBox.SelectedItem.ToString().Contains("Student"))
                    {
                        registerStudent();
                    }

                    else if (roleComboBox.SelectedItem.ToString().Contains("Parent"))
                    {
                        registerParent();
                    }

                    if(accountCreate == false)
                    {
                        // this method is only if the user has not registered correctly so there is no need to have the code in this method
                        deleteAccount();
                    }

                    if (goForward == false)
                    {
                        // open new login form if the user has registered successfully
                        // most frequent and likely case
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                }
            }
        }

        // the hash function i will apply to the username is the one from the aqa a level textbook for unit 1
        // since each username has to be unique, the hash function will be applied to the username and not the password because more than one user can choose the same password
        
        // create new method to get the hash value of the password chosen using a hash function
        // the hash function gets the ascii character for each character in the password and squares it
        // the modulus function is then applied to the value above to get the remainder when divided by 523
        // this is because the hash values are in the range 0, 522 so the value is modded with the prime number 523
        public string hashUsername(string username)
        {
            Hashtable hashtable = new Hashtable();
            int sum = 0;
            string hash = string.Empty;
            StringBuilder sb = new StringBuilder();
            byte[] ascii = Encoding.ASCII.GetBytes(username);
            foreach (byte b in ascii)
            {
                sb.Append(b);
                hash = sb.ToString();
            }

            int i;

            for (i = 0; i < sb.Length; i++)
            {
                sum += hash[i] * hash[i];
            }

            usernameHash = sum % 523;

            hashtable.Add(usernameHash, username);
            return Convert.ToString(usernameHash);
        }

        public void deleteAccount()
        {
            // delete the account stored on user profile if the user specific details are not entered 
            SqlCommand delete = new SqlCommand("Delete from UserProfile where Username = '" + hashUsername(usernameTextboxRegister.Text) + "'", connection);
            delete.ExecuteNonQuery();
            MessageBox.Show("Not registered");
            goForward = true;
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            // open new login form 
            Login goback = new Login(); 
            goback.Show();
            this.Hide();
        }

        private void roleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // disable each group box containing the text box for the other type of user
            // only one grioup box can be seen at one time (as the user can only be either a student, parent or teacher)
            // all group boxes will be disabled from the begininning and the selected one will be enabled while the remaining two are disabled
            if(roleComboBox.SelectedItem.ToString().Contains("Student"))
            {
                studentGroupBox.Enabled = true;
                parentGroupBox.Enabled = false;
                teacherGroupBox.Enabled = false;
            }

            if(roleComboBox.SelectedItem.ToString().Contains("Parent"))
            {
                parentGroupBox.Enabled = true;
                studentGroupBox.Enabled = false;
                teacherGroupBox.Enabled = false;
            }

            if(roleComboBox.SelectedItem.ToString().Contains("Teacher"))
            {
                teacherGroupBox.Enabled = true;
                studentGroupBox.Enabled = false;
                parentGroupBox.Enabled = false;
            }
        }        

        private void addClassButton_Click(object sender, EventArgs e)
        {
            // this allows the student to add extra subjects after they have registerd
            SqlCommand insertSubject = new SqlCommand(@"INSERT INTO [dbo].[StudentSubject]
            ([StudentID]
            ,[SubjectID]
            )
            VALUES
            ((SELECT StudentID FROM [dbo].[Student] WHERE profileID = (SELECT profileID FROM [dbo].[UserProfile] WHERE Username = '" + hashUsername(usernameTextboxRegister.Text) + "')), (SELECT SubjectID FROM [dbo].[Subject] WHERE SubjectTaken = '" + subjectComboBox.Text + "'))", connection);
            insertSubject.ExecuteNonQuery();

            // link tables student and teacher 
            // this is done after the student is registered 
            // this shows which students are in which class and taught by which teacher
            SqlCommand linkTables = new SqlCommand(@"INSERT INTO [dbo].[StudentTeacher]
            ([StudentID]
            ,[TeacherID]
            ,[SubjectID]
            )
            VALUES
            ((SELECT StudentID FROM [dbo].[Student] WHERE profileID = (SELECT profileID FROM [dbo].[UserProfile] WHERE Username = '" + hashUsername(usernameTextboxRegister.Text) + "')), (SELECT TeacherID FROM [dbo].[Teacher] WHERE TeacherID = (Select TeacherID from [dbo].[Teacher] where ClassCode = '" + classcodetextBoxStudent.Text + "')), (SELECT SubjectID FROM [dbo].[Subject] WHERE SubjectTaken = '" + subjectComboBox.Text + "'))", connection);
            linkTables.ExecuteNonQuery();

            MessageBox.Show("New class added");
            addClass();
        }

        private void registerTeacher()
        {
            if (subjectTextBoxTeacher.Text == "" || classCodeTextBoxteacher.Text == "" || departmentTextBox.Text == "")
            {
                MessageBox.Show("Enter details");
            }

            else
            {
                try
                {
                    // store the int value in the insert statement into teacher table and do the same for the other tables
                    SqlCommand insertProfile = new SqlCommand(@"INSERT INTO [dbo].[Teacher]
                                ([profileID]
                                ,[Department]
                                ,[ClassCode]
                                )
                            VALUES
                            ('"+profileIDValue+"', '" + departmentTextBox.Text + "', '" + classCodeTextBoxteacher.Text + "')", connection);
                    insertProfile.ExecuteNonQuery();

                    // link tables subject and teacher, this is to show which teacher teaches which subject
                    SqlCommand teacherSubject = new SqlCommand(@"INSERT INTO [dbo].[Subjectteacher_FK]
                                ([TeacherID]
                                ,[SubjectID])
                            VALUES
                            ((SELECT TeacherID FROM [dbo].[Teacher] WHERE profileID = '"+profileIDValue+"'), (SELECT SubjectID FROM [dbo].[Subject] WHERE SubjectTaken = '" + subjectTextBoxTeacher.Text + "'))", connection);
                    teacherSubject.ExecuteNonQuery();
                    MessageBox.Show("Registered successfully");
                    accountCreate = true;
                }

                catch (SqlException)
                {
                    MessageBox.Show("Enter details");
                }
            }
        }

        private void registerStudent()
        {
            if (levelComboBox.SelectedIndex == -1 || subjectComboBox.SelectedIndex == -1 || parentnametextBox.Text == "" || classcodetextBoxStudent.Text == "")
            {
                MessageBox.Show("Enter details");
            }

            else
            {
                try
                {
                    // insert profile id, level studying at and parent name to student table
                    SqlCommand insertStudent = new SqlCommand(@"INSERT INTO [dbo].[Student]
                                ([profileID]
                                ,[LevelID]
		                        )
                            VALUES
                            ('"+profileIDValue+"', (SELECT LevelID FROM [dbo].[Level] WHERE subjectLevel = '" + levelComboBox.Text + "'))", connection);
                    insertStudent.ExecuteNonQuery();

                    // link tables student and subject in many-to-many relationship
                    // select student id of student for which the profile id has just been created
                    // select subject id where the subject is equal to the one specified
                    // this shows how many students study which subject
                    SqlCommand insertSubject = new SqlCommand(@"INSERT INTO [dbo].[StudentSubject]
                                ([StudentID]
                                ,[SubjectID]
                                )
                            VALUES
                            ((SELECT StudentID FROM [dbo].[Student] WHERE profileID = '"+profileIDValue+"'), (SELECT SubjectID FROM [dbo].[Subject] WHERE SubjectTaken = '" + subjectComboBox.Text + "'))", connection);
                    insertSubject.ExecuteNonQuery();

                    // link tables student and teacher 
                    // this is done after the student is registered 
                    // this shows which students are in which class and taught by which teacher
                    SqlCommand linkTables = new SqlCommand(@"INSERT INTO [dbo].[StudentTeacher]
                                ([StudentID]
                                ,[TeacherID]
                                ,[SubjectID]
                                )
                            VALUES
                            ((SELECT StudentID FROM [dbo].[Student] WHERE profileID = '"+profileIDValue+"'), (SELECT TeacherID FROM [dbo].[Teacher] WHERE TeacherID = (Select TeacherID from [dbo].[Teacher] where ClassCode = '" + classcodetextBoxStudent.Text + "')), (SELECT SubjectID FROM [dbo].[Subject] WHERE SubjectTaken = '" + subjectComboBox.Text + "'))", connection);
                    linkTables.ExecuteNonQuery();

                    MessageBox.Show("Registered successfully");
                    accountCreate = true;

                    // call private method to empty the class code textbox and subject so the student can add a new class code
                    addClass();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void registerParent()
        {
            if (nameChildTextBox.Text == "" || studentIDTextBoxParent.Text == "" || addressTextBox.Text == "" || postcodeTextBox.Text == "")
            {
                MessageBox.Show("Enter details");
            }

            else
            {
                try
                {
                    // insert parent details to database
                    SqlCommand insertParent = new SqlCommand(@"INSERT INTO [dbo].[Parent]
                                ([profileID]
                                ,[Address]
                                ,[NumberofKids]
                                ,[NameofChild])
                            VALUES
                            ('" + profileIDValue + "', '" + addressTextBox.Text + "', '" + studentIDTextBoxParent.Text + "', '" + nameChildTextBox.Text + "')", connection);
                    insertParent.ExecuteNonQuery();

                    // link tables student and parent, this is done after the parent has registered as a parent does not necessarily have to be registered before a student registers
                    // this shows which parent has which child
                    SqlCommand studentParent = new SqlCommand(@"INSERT INTO [dbo].[ParentStudent_FK]
                            ([StudentID]
                            ,[ParentID])
                            VALUES
                            ((SELECT StudentID FROM [dbo].[Student] WHERE StudentID = '" + studentIDTextBoxParent.Text + "'), (SELECT ParentID FROM [dbo].[Parent] WHERE profileID = '"+profileIDValue+"'))", connection);
                    studentParent.ExecuteNonQuery();
                    MessageBox.Show("Registered successfully");
                    accountCreate = true;
                }

                catch(SqlException ex)
                {
                    MessageBox.Show("Details entered incorrectly");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void addClass()
        {
            // ask if the student needs to enter more than one class code for their subjects
            DialogResult dialog = MessageBox.Show("Do you want to add another subject?", "Confirm", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                addClassButton.Show();
                enterDetailsButton.Enabled = false;

                usernameTextboxRegister.Text = "";
                passwordTextboxRegister.Text = "";
                nameTextboxRegister.Text = "";
                surnameTextboxRegister.Text = "";
                mailAddressTextbox.Text = "";
                telephoneTextboxRegister.Text = "";
                roleComboBox.Text = "";
                // empty values of text box for the user to enter new values
                // disable username group box so the system does not display message 'username already exists'
                registerGroupBox.Enabled = false;

                subjectComboBox.Text = "";
                classcodetextBoxStudent.Text = "";
                goForward = true;
            }

            else if (dialog == DialogResult.No)
            {
                MessageBox.Show("Thank you");
                goForward = false;
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            // leave empty
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // leave empty
        }
    }
}