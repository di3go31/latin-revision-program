using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Project
{
    public partial class Comment : Form
    {
        SqlConnection Connection = new SqlConnection("Data Source = LAPTOP-CKS3DTGK; Initial Catalog=LatinRevision; Integrated Security=True");

        public string typeofComment;
        public int senderProfileID;
        // queue
        public Queue<int> receivers = new Queue<int> { };
        public Comment(string type , int senderID, ArrayList receiver)
        {
            InitializeComponent();
            typeofComment = type;
            senderProfileID = senderID;
            for (int h = 0; h < receiver.Count; h++)
            {
                receivers.Enqueue(Convert.ToInt32(receiver[h]));
            }
            typeofCommentLabel.Text = typeofComment;
            Connection.Open();
        }

        private void Comment_Load(object sender, EventArgs e)
        {
            /*
if(typeofComment == "ParentCommunicate")
{
    SqlCommand insertComment3 = new SqlCommand(@"INSERT INTO [dbo].[Comment]
([commentText]
,[SenderID]
,[CommentType])
VALUES
('" + commentTextBox.Text + "', '"+senderProfileID+"' ,'"+typeofComment+"')", Connection);
    insertComment3.ExecuteNonQuery();
}
            if (typeofComment == "CommunicateTeacher")
            { 
                SqlCommand insertComment = new SqlCommand(@"INSERT INTO [dbo].[Comment]
           ([commentText]
           ,[ReceiverID]
           ,[SenderID]
           ,[CommentType])
     VALUES
           ('" + commentTextBox.Text+"', '"+senderProfileID+"' ,'"+typeofComment+"')", Connection);
                insertComment.ExecuteNonQuery();
            }

            
            if(typeofComment == "Review")
            {
                SqlCommand insertComment1 = new SqlCommand(@"INSERT INTO [dbo].[Comment]
           ([commentText]
           ,[SenderID]
           ,[CommentType])
     VALUES
           ('" + commentTextBox.Text + "', '"+senderProfileID+"' ,'"+typeofComment+"')", Connection);
                insertComment1.ExecuteNonQuery();
            }*/
        }

        private void commentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                for (int f = 0; f < receivers.Count; f++)
                {
                    SqlCommand insertComment2 = new SqlCommand(@"INSERT INTO [dbo].[Comment]
           ([commentText]
           ,[SenderID]
           ,[ReceiverID]
           ,[CommentType])
     VALUES
           ('" + commentTextBox.Text + "', '" + senderProfileID + "' , '" + receivers.Dequeue() + "' ,'" + typeofComment + "')", Connection);
                    insertComment2.ExecuteNonQuery();
                }
                MessageBox.Show("Comment sent");
                this.Close();
            }

            catch (ArgumentNullException)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
