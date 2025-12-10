using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class StudentPage : Form
    {
        private int studentID;
        public StudentPage(string profileValue, int ID)
        {
            InitializeComponent();
            // set the label equal to the value of their profile id
            welcomelabel.Text = profileValue;
            studentIDLabel.Text = Convert.ToString(ID);
            studentID = ID;
        }
        private void StudentPage_Load(object sender, EventArgs e)
        {
            // leave empty
        }       

        private void answerQuestionsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(chooseSubjectComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Choose a subject");
                }

                else if (chooseSubjectComboBox.SelectedItem.ToString() == "Latin")
                {
                    answerQuestions questions = new answerQuestions(studentID);
                    questions.Show();
                }
            }

            catch(Exception)
            {
                MessageBox.Show("Choose a subject");
            }
        }

        private void viewMessagesButton_Click(object sender, EventArgs e)
        {
            ViewMessages view = new ViewMessages();
            view.Show();
        }

        private void sendFeedbackButton_Click(object sender, EventArgs e)
        {
            /*
            string r = "Review";
            Comment comment = new Comment(r);
            comment.Show();*/
        }

        private void viewPreviousScoresButton_Click(object sender, EventArgs e)
        {
            ViewScores scores = new ViewScores(studentID);
            scores.Show();
        }

        private void viewOtherScoresButton_Click(object sender, EventArgs e)
        {
            ViewScores scores = new ViewScores(studentID);
            scores.Show();
        }

        private void teacherEnquiryButton_Click(object sender, EventArgs e)
        {
            /*
            string type = "teacherComment";
            Comment comment = new Comment(type);
            comment.Show();*/
        }
        private void label9_Click(object sender, EventArgs e)
        {
   
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}