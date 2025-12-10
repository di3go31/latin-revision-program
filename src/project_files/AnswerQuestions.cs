using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class answerQuestions : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source = LAPTOP-CKS3DTGK; Initial Catalog=LatinRevision; Integrated Security=True");
        private ArrayList questionAsked = new ArrayList { };
        private ArrayList questionAnswered = new ArrayList { };
        private int index = 0, id;
        public answerQuestions(int studentID)
        {
            InitializeComponent();
            id = studentID;
        }
        private void answerQuestions_Load(object sender, EventArgs e)
        {
            goBackButton.Enabled = false;
            SubmitButton.Enabled = false;
        }
        
        private void doneButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SubmitButton.Enabled = true;
            if (TopicComboBox.SelectedIndex == -1 || LevelComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Choose topic and level");
            }

            else
            {
                try
                {
                    SqlCommand selectQuestions = new SqlCommand("Select QuestionName, NumberofMarks, QuestionDifficulty from Question where (TopicID = (Select TopicID from Topic where TopicName = '" + TopicComboBox.SelectedItem.ToString() + "') and LevelID = (Select LevelID from Level where subjectLevel = '" + LevelComboBox.SelectedItem.ToString() + "'))", sqlConnection);
                    SqlDataReader questionReader = selectQuestions.ExecuteReader();
                    int marks = 0;
                    string question = string.Empty;

                    while (questionReader.Read())
                    {
                        question = questionReader["QuestionName"].ToString();

                        marks = Convert.ToInt32(questionReader["NumberofMarks"]);

                        questionAsked.Add(question);
                        questionAnswered.Add("");
                    }
                    questionLabel.Text = questionAsked[0].ToString();
                    questionReader.Close();
                }

                catch (NullReferenceException)
                {
                    MessageBox.Show("Enter topic and level");
                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            goBackButton.Enabled = true;
            questionAnswered[index] = questionTextBox.Text;

            try
            {
                if (questionTextBox.Text != "")
                {
                    index++;
                    questionLabel.Text = questionAsked[index].ToString();
                    // questionTextBox.Text = questionAnswered[index].ToString();
                    // the attrribute marks awarded will be set when the teacher has marked the question, plus the teacher ID
                    SqlCommand storeQuestions = new SqlCommand(@"INSERT INTO [dbo].[Answer]
           ([QuestionID]
           ,[StudentID]
           ,[AnswerGiven]
           ,[isMarked]
           )
       VALUES
           ((Select QuestionID from Question where QuestionName = '" + questionAsked[index].ToString() + "'), '" + id + "', '" + questionTextBox.Text + "', 'False')", sqlConnection);
                    storeQuestions.ExecuteNonQuery();
                }
            }
            
            catch(Exception)
            {
                MessageBox.Show("Finished");
                sqlConnection.Close();
                this.Close();
            }

            questionTextBox.Text = "";
        }
        private void seeClueButton_Click(object sender, EventArgs e)
        {
            if(questionLabel.Text.Contains("bam"))
            {
                MessageBox.Show("bam: perfect tense past first", "Clue");
            }
        }
        private void goBackButton_Click(object sender, EventArgs e)
        {
            index = index - 1 ;
            questionLabel.Text = questionAsked[index].ToString();
            questionTextBox.Text = questionAnswered[index].ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            // leave empty
        }

        private void topicLable_Click(object sender, EventArgs e)
        {

        }
        private void LevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void chooseChapterchecbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void questionsTimer_Tick(object sender, EventArgs e)
        {

        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}