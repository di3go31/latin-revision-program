using System;
using System.Collections;
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
    public partial class teacherLoggedin : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source = LAPTOP-CKS3DTGK; Initial Catalog=LatinRevision; Integrated Security=True");

        public int profileID;
        public teacherLoggedin(string teacherName, int ID)
        {
            InitializeComponent();
            sqlConnection.Open();
            nonelabel.Text = teacherName;
            profileID = ID;
        }
        private void teacherLoggedin_Load(object sender, EventArgs e)
        {

        } 
        private void addQuestionsButton_Click(object sender, EventArgs e)
        {
            addQuestion newQuestion = new addQuestion();
            newQuestion.Show();
        }

        private void viewMessagesButton_Click(object sender, EventArgs e)
        {
            ViewMessages messages = new ViewMessages();
            messages.Show();
        }

        private void viewProgressButton_Click(object sender, EventArgs e)
        {
            SqlCommand selectID = new SqlCommand("Select TeacherID from Teacher where profileID = '" + profileID + "'", sqlConnection);
            SqlDataReader profileReader = selectID.ExecuteReader();
            while(profileReader.Read())
            {
                profileID = Int32.Parse((String.Format("{0}", profileReader["TeacherID"])));
            }
            profileReader.Close();
            ViewScores viewScores = new ViewScores(profileID);
            viewScores.Show();
        }

        private void commentStudentButton_Click(object sender, EventArgs e)
        {
            SqlCommand receiverID = new SqlCommand("Select UserProfile.profileID from UserProfile inner join Student on Student.profileID = UserProfile.profileID inner join StudentTeacher on StudentTeacher.StudentID = Student.StudentID and StudentTeacher.TeacherID = '40'", sqlConnection);
            SqlDataReader receiver = receiverID.ExecuteReader();
            ArrayList receiverIDS = new ArrayList { };
            while(receiver.Read())
            {
                int receiverIDNumber = Int32.Parse((String.Format("{0}", receiver["profileID"])));
                receiverIDS.Add(receiverIDNumber);
            }
            receiver.Close();
            string q = "StudentProgress";
            Comment comment = new Comment(q, profileID, receiverIDS);
            comment.Show();
        }

        private void communicateParentButton_Click(object sender, EventArgs e)
        {
            /*
            string a = "ParentCommunicate";
            Comment commentParent = new Comment(a);
            commentParent.Show();*/
        }

        private void MarkWorkButton_Click(object sender, EventArgs e)
        {
            Mark_Work work = new Mark_Work(profileID);
            work.Show();
        }
    }
}
