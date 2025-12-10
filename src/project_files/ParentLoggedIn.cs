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
    public partial class ParentLoggedin : Form
    {
        SqlConnection Connection = new SqlConnection("Data Source = LAPTOP-CKS3DTGK; Initial Catalog=LatinRevision; Integrated Security=True");

        private int IDProfile;
        public ParentLoggedin(string parentName, int profileID)
        {
            InitializeComponent();
            nonelabel.Text = parentName;
            IDProfile = profileID;
        }
        private void ParentLoggedin_Load(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand nameParent = new SqlCommand( "Select count (*) Name from UserProfile", Connection);
            nameParent.ExecuteNonQuery();        
        }
        private void viewProgressButton_Click(object sender, EventArgs e)
        {
            ViewScores viewScores = new ViewScores(IDProfile);
            viewScores.Show();
        }

        private void communicateTeacherButton_Click(object sender, EventArgs e)
        {
            /*
            string c = "CommunicateTeacher";
            Comment comment = new Comment(c);
            comment.Show();*/
        }

        private void viewMessagesButton_Click(object sender, EventArgs e)
        {
            ViewMessages viewMessages = new ViewMessages();
            viewMessages.Show();
        }
    }
}
