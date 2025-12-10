using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Mark_Work : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source = LAPTOP-CKS3DTGK; Initial Catalog=LatinRevision; Integrated Security=True");

        public int profileConstructor, studentIDValue;
        public string studentAns;

        public Mark_Work(int profileID)
        {
            InitializeComponent();
            // profile id of the teacher from the constructor argument which is to be used in subsequent queries
            profileConstructor = profileID;
        }
        private void Mark_Work_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
        }
        private void studentCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentNameLabel.Text = studentComboBox.SelectedItem.ToString();

            // select student's student id to be used in other queries
            SqlCommand selectStudentID = new SqlCommand("Select StudentID from Student where profileID = (Select profileID from UserProfile where Name = '" + studentComboBox.SelectedItem.ToString() + "' and Role = 'Student')", sqlConnection);
            SqlDataReader IDReader = selectStudentID.ExecuteReader();
            while(IDReader.Read())
            {
                studentIDValue = Int32.Parse((String.Format("{0}", IDReader["StudentID"])));
            }
            IDReader.Close();

            SqlCommand selectQuestions = new SqlCommand("Select Question.QuestionName, Question.QuestionAnswer, Question.NumberofMarks, Answer.AnswerGiven from Question inner join Answer on Question.QuestionID = Answer.QuestionID and Answer.isMarked = 'False' and Answer.StudentID = '" + studentIDValue + "'", sqlConnection);
            SqlDataReader questionReader = selectQuestions.ExecuteReader();
            while(questionReader.Read())
            {
                string x = questionReader["QuestionName"].ToString();
                questionsComboBox.Items.Add(x);
            }
            questionReader.Close();
        }

        private void loadNamesButton_Click(object sender, EventArgs e)
        {
            // select every student name using link table student teacher
            // this means that by having a corresponding teacher id, the students are in the same class
            // SqlCommand selectName = new SqlCommand("Select Name from UserProfile, StudentTeacher, Student where StudentTeacher.StudentID = UserProfile.profileID and StudentTeacher.TeacherID = '"+profileConstructor+"' and Student.profileID = StudentTeacher.StudentID", sqlConnection);
            SqlCommand selectName = new SqlCommand("Select UserProfile.Name from ((UserProfile inner join Student on UserProfile.profileID = Student.profileID) inner join StudentTeacher on Student.StudentID = StudentTeacher.StudentID and StudentTeacher.TeacherID = '"+profileConstructor+"')", sqlConnection);
            SqlDataReader nameReader = selectName.ExecuteReader();
            while (nameReader.Read())
            {
                string k = nameReader["Name"].ToString();
                studentComboBox.Items.Add(k);
            }
            nameReader.Close();

            loadNamesButton.Enabled = false;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            // exception handling 
            if (numberMarksTextBox.Text != "")
            {
                try
                {
                    // update the answer table with the input of number of marks set by the teacher where student id corresponds to the student who answered the question
                    SqlCommand updateMarks = new SqlCommand("Update Answer set MarksAwarded = '" + numberMarksTextBox.Text + "', isMarked = 'True' where AnswerID = (Select AnswerID from Answer where AnswerGiven = '" + studentAns + "' and StudentID = '" + studentIDValue + "')", sqlConnection);
                    updateMarks.ExecuteNonQuery();
                    MessageBox.Show("Question marked succesffully");
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Input number of marks");
            }
        }
        
        private void doneQuestionButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                questionLabel.Text = questionsComboBox.SelectedItem.ToString();

                SqlCommand selectQAnswer = new SqlCommand("Select Question.QuestionAnswer, Question.NumberofMarks, Answer.AnswerGiven from Question inner join Answer on Question.QuestionID = Answer.QuestionID and Question.QuestionName = '"+questionsComboBox.SelectedItem.ToString()+"' and Answer.StudentID = '"+studentIDValue+"'", sqlConnection);
                SqlDataReader resultReader = selectQAnswer.ExecuteReader();
                while(resultReader.Read())
                {
                    string h = resultReader["QuestionAnswer"].ToString();
                    originalAnswerLabel.Text = h;

                    studentAns = resultReader["AnswerGiven"].ToString();
                    answerLabel.Text = studentAns;

                    string i = resultReader["NumberofMarks"].ToString();
                    numberMarksLabel.Text = i;
                }
                resultReader.Close();
            }

            catch(NullReferenceException)
            {
                MessageBox.Show("No question selected");
            }
        }
        private void questionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // leave empty
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // leave empty 
        }
    }
}