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
    public partial class addQuestion : Form
    {
        public bool next = true;
        public addQuestion()
        {
            InitializeComponent();
        }

        private void addQuestion_Load(object sender, EventArgs e)
        {

        }

        public void saveQuestionButton_Click(object sender, EventArgs e)
        {
            if (next == true)
            {
                try
                {
                    SqlConnection question = new SqlConnection("Data Source = LAPTOP-CKS3DTGK; Initial Catalog=LatinRevision; Integrated Security=True");
                    question.Open();
                    // insert new question to the database
                    SqlCommand command = new SqlCommand(@"INSERT INTO [dbo].[Question]
           ([QuestionName]
           ,[QuestionAnswer]
           ,[NumberofMarks]
           ,[SubjectID]
           ,[LevelID]
           ,[TopicID]
           ,[QuestionDifficulty])
     VALUES
            ('" + questionTextBox.Text + "', '" + answerTextBox.Text + "', '" + marksTextBox.Text + "', (SELECT SubjectID FROM [dbo].[Subject] WHERE SubjectTaken = '"+subjectComboBox.Text+"'), (SELECT LevelID FROM [dbo].[Level] WHERE subjectLevel = '"+levelComboBox.Text+"'), (SELECT TopicID FROM [dbo].[Topic] WHERE TopicName = '"+topicComboBox.Text+"'),'"+gradeTextBox.Text+"')", question);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Question saved");
                    topicComboBox.Text = "";
                    gradeTextBox.Text = "";
                    questionTextBox.Text = "";
                    answerTextBox.Text = "";
                    marksTextBox.Text = "";
                    DialogResult result = MessageBox.Show("Are you done?", "Exit", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // in case the user wishes to add more question, the system will ask if they want to add another one
                        next = false;
                        this.Hide();
                    }
                 
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("Enter the next question");
                    }
                }
            
                catch(SqlException)
                {
                    MessageBox.Show("Enter all fields");
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
