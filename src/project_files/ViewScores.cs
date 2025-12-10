using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ViewScores : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source = LAPTOP-CKS3DTGK; Initial Catalog=LatinRevision; Integrated Security=True");

        public int markResult, studentIDNumber, progressTopic, progressAverage, scoreTotal, IDNumber, index, y;
        private ArrayList scores = new ArrayList { };
        private ArrayList Zscores = new ArrayList { };
        public static List<int> sDeviation = new List<int> { };
        public ViewScores(int IDName)
        {
            InitializeComponent();
            IDNumber = IDName;
        }
        private void ViewScores_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand insertProgress = new SqlCommand(@"INSERT INTO [dbo].[Progress]
           ([TargetGrade]
           ,[AverageProgress]
           ,[TopicProgress]
           ,[StudentID]
           ,[SubjectID]
           ,[LevelID]
            )
     VALUES
           ('" + targetGradeTextBox.Text + "', '" + progressAverage + "', '" + progressTopic + "','" + studentIDNumber + "', (Select SubjectID from Subject where SubjectTaken = '" + subjectTextBox.Text + "'), (Select LevelID from Student where StudentID = '" + studentIDNumber + "'))", sqlConnection);
                insertProgress.ExecuteNonQuery();

                insertScores();
            }

            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            viewButton.Hide();
            if (topicComboBox.SelectedIndex != -1)
            {
                try
                {
                    // the scores and progress are inserted into the sql tables when the teacher or student or parent wishes to view progress
                    // this is to avoid inserting the fields into sql from the form MarkWork which is not necessary and would be less efficient

                    // select number of students per class for the teacher form and their names
                    // select the name of each student to label the x axis 
                    SqlCommand selectStudents = new SqlCommand("Select UserProfile.Name from ((UserProfile inner join Student on UserProfile.profileID = Student.profileID) inner join StudentTeacher on Student.StudentID = StudentTeacher.StudentID and StudentTeacher.TeacherID = '" + IDTextBox.Text + "')", sqlConnection);
                    SqlDataReader sqlData = selectStudents.ExecuteReader();
                    string numStudents;
                    List<string> students = new List<string> { };
                    while (sqlData.Read())
                    {
                        numStudents = sqlData["Name"].ToString();
                        students.Add(numStudents.ToString());
                    }
                    sqlData.Close();

                    for (int i = 0; i < students.Count; i++)
                    {
                        // this is to avoid writing the query into the other ones, instead it can be separate so it becomes just a single value and is not repeated
                        // select the student id for the student in the class with the index of the queue in the for loop 
                        SqlCommand studentID = new SqlCommand("Select StudentID from Student where profileID = (Select profileID from UserProfile where Name = '" + students[i] + "')", sqlConnection);
                        SqlDataReader dataReader = studentID.ExecuteReader();
                        while (dataReader.Read())
                        {
                            studentIDNumber = Int32.Parse((String.Format("{0}", dataReader["StudentID"])));
                        }
                        dataReader.Close();

                        // select the sum of the marks awarded for a given student for a given topic 
                        // this will only include questions that they have answered, if the student has not yet answered any questions, the result will be zero
                        SqlCommand scores = new SqlCommand("Select Sum(MarksAwarded) as 'Marks' from Answer inner join Question on Answer.QuestionID = Question.QuestionID and Question.TopicID = (Select TopicID from Topic where TopicName = '" + topicComboBox.SelectedItem.ToString() + "') and Answer.StudentID = '" + studentIDNumber + "'", sqlConnection);
                        SqlDataReader scoresReader = scores.ExecuteReader();
                        string scoreX;
                        while (scoresReader.Read())
                        {
                            scoreX = scoresReader["Marks"].ToString();
                            topicProgressChart.Series["Scores"].Points.AddXY(students[i], scoreX);
                        }
                        scoresReader.Close();

                        SqlCommand totalScore = new SqlCommand("Select Sum(MarksAwarded) as 'TotalMarks' from Answer inner join Question on Question.QuestionID = Answer.QuestionID and Question.LevelID = '2'", sqlConnection);
                        SqlDataReader sqlDataReader = totalScore.ExecuteReader();
                        scoreTotal = 0;
                        while (sqlDataReader.Read())
                        {
                            scoreTotal = Int32.Parse((String.Format("{0}", sqlDataReader["TotalMarks"])));
                            sDeviation.Add(scoreTotal);
                        }
                        sqlDataReader.Close();

                        SqlCommand studentScore = new SqlCommand("Select Avg(MarksAwarded) as 'Avg' from Answer where StudentID = '" + studentIDNumber + "'", sqlConnection);
                        SqlDataReader scoreReader = studentScore.ExecuteReader();
                        while (scoreReader.Read())
                        {
                            // y = Int32.Parse((String.Format("{0}", scoreReader["Avg"])));
                            double y = scoreReader.GetDouble(0);
                            averageChart.Series["Average"].Points.AddXY(students[i], Convert.ToDouble(y));
                        }
                        scoreReader.Close();

                        NormalDistribution();
                    }
                }
            
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Choose topic");
            }
        }

        private double NormalDistribution()
        {
            // get the list of values of marks awarded for a given topic by all students (not one student in particular) which is already stored in a global variable (scoreTotal)
            // standard deviation is defined as the square root of variance
            // variance is defined as Sxx = Σx^2 - n*mean^2

            // the sum of the total scores is already a value retrieved by an aggregate sql function
            List<int> values = new List<int> { };
            SqlCommand sigmaX = new SqlCommand("Select MarksAwarded from Answer inner join Question on Question.QuestionID = Answer.QuestionID and Question.TopicID = (Select TopicID from Topic where TopicName = '" + topicComboBox.SelectedItem.ToString() + "' and Answer.isMarked = 'True')", sqlConnection);
            SqlDataReader data = sigmaX.ExecuteReader();
            while (data.Read())
            {
                int value = Int32.Parse((String.Format("{0}", data["MarksAwarded"])));
                values.Add(value);
            }
            data.Close();

            float numberMarks = values.Count;
            float totalSum = 0;
            for (int i = 0; i < numberMarks; i++)
            {
                totalSum += values[i];
            }

            float mean = totalSum / numberMarks;

            double sumX = 0;
            for (int y = 0; y < values.Count; y++)
            {
                sumX += Math.Pow(values[y], 2);
            }

            double valueStandard = Math.Sqrt((sumX / values.Count) - Math.Pow(mean, 2));
            standardDeviationLabel.Text = valueStandard.ToString();

            meanLabel.Text = mean.ToString();

            index = 0;
            double probability = 0, zScore = 0;
            for (int a = 0; a < values.Count; a++)
            {
                // this says how spread out the data is from the mean
                int xValue = values[a];
                probability = (1 / (valueStandard * Math.Sqrt(2 * Math.PI))) * Math.Exp(-0.5 * Math.Pow(((xValue - mean) / valueStandard), 2));
                scores.Add(probability.ToString());

                // store z scores in array
                zScore = (xValue - mean) / valueStandard;
                Zscores.Add(zScore.ToString());
            }

            distributionLabel.Text = scores[index].ToString();
            zScoreLabel.Text = zScore.ToString();

            // variance is the standard deviation squared
            double variance = Math.Pow(valueStandard, 2);
            varianceLabel.Text = variance.ToString();

            return probability;
        }

        private void topicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NormalDistribution();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                index++;
                distributionLabel.Text = scores[index].ToString();
                // update z score label
                zScoreLabel.Text = Zscores[index].ToString();
            }

            catch (ArgumentOutOfRangeException)
            {
                // this means that the scores have ended, the index value is equal to the size of the array containing the students' scores 
                MessageBox.Show("End");
                nextButton.Hide();
            }
        }

        private void insertScores()
        { 
            for(int j = 0; j<sDeviation.Count; j++)
            {
                // insert details regarding student scores into specific sql table 
                SqlCommand scoresUpdate = new SqlCommand(@"INSERT INTO [dbo].[Score]
           ([TopicScore]
           ,[AverageScore]
           ,[StudentID]
           ,[TopicID]
           ,[LevelID]
           ,[SubjectID])
     VALUES
           ('"+sDeviation[j].ToString()+"', '"+y+"', '"+studentIDNumber+ "', (Select TopicID from Topic where TopicName = '" + topicComboBox.SelectedItem.ToString() + "'), '2', (Select SubjectID from Subject where SubjectTaken = '"+subjectTextBox.Text+"'))", sqlConnection);
                scoresUpdate.ExecuteNonQuery();
            }

            MessageBox.Show("Finished");
        }
        private void viewScores_Closing(object sender, EventArgs e)
        {
            // insert scores after the teacher has reviewed them 
            insertScores();
            MergeSort();
        }
        private void MergeSort()
        {
            int[] questions = new int[] {3,2,2,3,4,5,64,3,3,3,55,3,3,2,4,3,4,5};
            int i = questions[0];
            int j = questions[questions.Length / 2];
            int indexNumber = i;
            int[] B = new int[] { };
            while (indexNumber < questions[questions.Length -1])
            {
                if(j >= questions[questions.Length - 1] || (i < j && questions[i] < questions[j]))
                {
                    B[indexNumber] = questions[i];
                    i++;
                }

                else
                {
                    B[indexNumber] = questions[j];
                    j++;
                }
                indexNumber++;

                MessageBox.Show(B.ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void chart2_Click(object sender, EventArgs e)
        {

        }
        private void subjectTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void meanLabel_Click(object sender, EventArgs e)
        {

        }
    }
}