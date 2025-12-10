using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class User
    {
        private string Username;
        private string Password;
        private string Role;
        private string Mail;
        private string Name;
        private string Surname;
        private string Telephone;
        public void getUsername()
        {
            // TODO - implement User.getUsername
        }

        public void setUsername(int Username)
        {
            // TODO - implement User.setUsername
        }

        public void getPassword()
        {
            // TODO - implement User.getPassword
        }

        public void setPassword(string Password)
        {
            // TODO - implement User.setPassword
        }

        public void getRole()
        {
            // TODO - implement User.getRole
        }
        public void setRole(int Role)
        {
            // TODO - implement User.setRole
        }

        public void getMailAddress()
        {
            // TODO - implement User.getMailAddress
        }

        public void setMailAddress(int MailAddress)
        {
            // TODO - implement User.setMailAddress
        }

        public void getAttribute()
        {
            // TODO - implement User.getAttribute
        }

        public void setAttribute(int attribute)
        {
            // TODO - implement User.setAttribute
        }
        public void getName()
        {
            // TODO - implement User.getName
        }

        public void setName(int Name)
        {
            // TODO - implement User.setName
        }
        public void getSurname()
        {
            // TODO - implement User.getSurname
        }

        public void setSurname(int Surname)
        {
            // TODO - implement User.setSurname
        }
        public void getTelephone()
        {
            // TODO - implement User.getTelephone
        }

        public void setTelephone(int Telephone)
        {
            // TODO - implement User.setTelephone
        }
    }
    public class Student : User
    {
        private int StudentID;
        private int studentName;
        private int studentSurname;
        private double studentScore;
        private string studentProgress;
        public void getStudentID()
        {
            // TODO - implement Student.getStudentID
        }

        public void setStudentID(int StudentID)
        {
            // TODO - implement Student.setStudentID
        }
        public void getStudentName()
        {
            // TODO - implement Student.getStudentName
        }

        public void setStudentName(int studentName)
        {
            this.studentName = studentName;
        }
        public void getStudentSurname()
        {
            // TODO - implement Student.getStudentSurname
        }

        public void setStudentSurname(int studentSurname)
        {
            this.studentSurname = studentSurname;
        }
        public void getStudentScore()
        {
            // TODO - implement Student.getStudentScore
        }

        public void setStudentScore(int studentScore)
        {
            // TODO - implement Student.setStudentScore
        }
        public void getAttribute()
        {
            // TODO - implement Student.getAttribute
        }

        public void setAttribute(int attribute)
        {
            // TODO - implement Student.setAttribute
        }
    }
    public class StudentController
    {
        private Student student;
        private StudentView view;

        public StudentController(string name, string id)
        {

        }
        public void answerQuestion()
        {
            // TODO - implement StudentController.answerQuestion
        }
        public void askForHelp()
        {
            // TODO - implement StudentController.askForHelp
        }
        public void viewOtherScores()
        {
            // TODO - implement StudentController.viewOtherScores
        }
    }
    public class StudentView
    {
        private double topicScore;
        public void printScores()
        {
            // TODO - implement StudentView.printScores
        }
        public void printStudentID()
        {
            // TODO - implement StudentView.printStudentID
        }
    }
    public class Teacher : User
    {
        private int TeacherID;
        private string Subject;
        public void getSubject()
        {
            // TODO - implement Teacher.getSubject
        }

        public void setSubject(int Subject)
        {
            // TODO - implement Teacher.setSubject
        }
    }
    public class TeacherController
    {
        public void leaveComment()
        {
            // TODO - implement TeacherController.leaveComment
        }
        public void addQuestion()
        {
            // TODO - implement TeacherController.addQuestion
        }
        public void viewProgress()
        {
            // TODO - implement TeacherController.viewProgress
        }
        public void informParents()
        {
            // TODO - implement TeacherController.informParents
        }
    }
    public class TeacherView
    {
        private string subject;
        public void printsubject()
        {
            // TODO - implement TeacherView.printsubject
        }
    }
    public class Parent : User
    {
        private int ParentID;
        private string Telephone;
        public Parent(int getParentID, string getTelephone)
        {
            ParentID = getParentID;
            Telephone = getTelephone;
        }
        public int getParentID()
        {
            // TODO - implement Parent.getParentID
            return ParentID;
        }

        public void setParentID(int ParentID)
        {
            // TODO - implement Parent.setParentID
        }
        public string getTelephone()
        {
            // TODO - implement Parent.getTelephone
            return Telephone;
        }

        public void setTelephone(string Telephone)
        {
            // TODO - implement Parent.setTelephone
        }
    }
    public class ParentController
    {
        public void communicate()
        {
            // TODO - implement ParentController.communicate
        }
    }
    public class ParentView
    {
        private string ParentTelephone;
        public void printTelephone()
        {
            // TODO - implement ParentView.printTelephone
        }
    }
    public class UserProfile : User
    {
        public int profileID;
        public string userDetails;

        public void verifyDetails(int Username, int Password)
        {
            // TODO - implement UserProfile.verifyDetails
        }
        public void createProfile()
        {
            // TODO - implement UserProfile.createProfile
        }
        public void updateProfile()
        {
            // TODO - implement UserProfile.updateProfile
        }
    }
    public class LoginController
    {
        private string loginStatus;
        private int attribute;

        public void login(string Username, char Password)
        {
            // TODO - implement LoginController.login
        }
    }
    public class Question
    {
        private int questionNo;
        private char topicQuestion;
        public int getQuestionNo()
        {
            return this.questionNo;
        }

        public void setQuestionNo(int questionNo)
        {
            this.questionNo = questionNo;
        }
        public char getTopicQuestion()
        {
            return this.topicQuestion;
        }

        public void setTopicQuestion(string topicQuestion)
        {
            // TODO - implement Question.setTopicQuestion
        }
    }
    public class QuestionController
    {
        public void askQuestion()
        {
            // TODO - implement QuestionController.askQuestion
        }

        public void markQuestion(int questionNo)
        {
            // TODO - implement QuestionController.markQuestion
        }
        public void questionExists()
        {
            // TODO - implement QuestionController.questionExists
        }
        public void insertQuestion()
        {
            // TODO - implement QuestionController.insertQuestion
        }
        public void showClue()
        {
            // TODO - implement QuestionController.showClue
        }
        public void saveTip()
        {
            // TODO - implement QuestionController.saveTip
        }
    }
    public class QuestionView
    {
        private int questionResult;
        public void getQuestionResult()
        {
            // TODO - implement QuestionView.getQuestionResult
        }

        public void setQuestionResult(int questionResult)
        {
            this.questionResult = questionResult;
        }
        public void printQuestionResult()
        {
            // TODO - implement QuestionView.printQuestionResult
        }
    }
    public class Score
    {
        private double average;
        private double TopicScore;
        public void getAvScore()
        {
            // TODO - implement Score.getAvScore
        }

        public void setAvScore(int AvScore)
        {
            // TODO - implement Score.setAvScore
        }
        public void getTopicScore()
        {
            // TODO - implement Score.getTopicScore
        }

        public void setTopicScore(int TopicScore)
        {
            // TODO - implement Score.setTopicScore
        }
    }
    public class ScoreController
    {
        public void saveScore()
        {
            // TODO - implement ScoreController.saveScore
        }
        public void showOtherScores()
        {
            // TODO - implement ScoreController.showOtherScores
        }
    }
    public class ScoreView
    {
        private double QuestionScore;
        public void getQuestionScore()
        {
            // TODO - implement ScoreView.getQuestionScore
        }

        public void setQuestionScore(int QuestionScore)
        {
            // TODO - implement ScoreView.setQuestionScore
        }
        public void printscores()
        {
            // TODO - implement ScoreView.printscores
        }
    }
    public class Progress
    {
        private char topicProgress;
        private char averageProgress;

        public void sketchGraph(int topicName, int topicScore)
        {
            // TODO - implement Progress.sketchGraph
        }
        public char getTopicProgress()
        {
            return this.topicProgress;
        }

        public void setTopicProgress(char topicProgress)
        {
            this.topicProgress = topicProgress;
        }
        public char getAverageProgress()
        {
            return this.averageProgress;
        }

        public void setAverageProgress(char averageProgress)
        {
            this.averageProgress = averageProgress;
        }
    }
    public class ProgressController
    {
        private string questionsProgress;
        public string getQuestionsProgress()
        {
            return this.questionsProgress;
        }

        public void setQuestionsProgress(string questionsProgress)
        {
            this.questionsProgress = questionsProgress;
        }
    }
    public class ProgressView
    {
        private string progressEach;
        private string topicProgress;
        public void printProgress()
        {
            // TODO - implement ProgressView.printProgress
        }
        public void printTopicProgess()
        {
            // TODO - implement ProgressView.printTopicProgess
        }
    }
    public class Comment1
    {
        private string teacherComment;
        private string parentComment;
        public void getTeacherComment()
        {
            // TODO - implement Comment.getTeacherComment
        }

        public void setTeacherComment(int teacherComment)
        {
            // TODO - implement Comment.setTeacherComment
        }
        public void getParentComment()
        {
            // TODO - implement Comment.getParentComment
        }

        public void setParentComment(int parentComment)
        {
            // TODO - implement Comment.setParentComment
        }
        public void commentProgress()
        {
            // TODO - implement Comment.commentProgress
        }
    }
    public class CommentController
    {
        public void sendComment()
        {
            // TODO - implement CommentController.sendComment
        }
        public void displayComment()
        {
            // TODO - implement CommentController.displayComment
        }
    }
    public class CommentView
    {
        public void printComment()
        {
            // TODO - implement CommentView.printComment
        }
    }
    public class Topic
    {
        private int topicName;
        private int topicScore;
        private int chapter;
        public void getTopicName()
        {
            // TODO - implement Topic.getTopicName
        }

        public void setTopicName(int topicName)
        {
            this.topicName = topicName;
        }
        public void getTopicScore()
        {
            // TODO - implement Topic.getTopicScore
        }

        public void setTopicScore(int topicScore)
        {
            this.topicScore = topicScore;
        }
        public void getChapter()
        {
            // TODO - implement Topic.getChapter
        }
        public void setChapter(int chapter)
        {
            this.chapter = chapter;
        }
    }
    public class TopicController
    {
        public void chooseTopic()
        {
            // TODO - implement TopicController.chooseTopic
        }
        public void saveTopicScores()
        {
            // TODO - implement TopicController.saveTopicScores
        }
    }
    public class TopicView
    {
        private string TopicName;
        public void printTopicName()
        {
            // TODO - implement TopicView.printTopicName
        }
    }
}