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
    public partial class ChooseTopic : Form
    {
        public ChooseTopic()
        {
            InitializeComponent();
        }

        private void ChooseTopic_Load(object sender, EventArgs e)
        {
       
        }
        private void chooseChapterchecbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            foreach (object itemChecked in chooseChapterchecbox.CheckedItems)
            {
                //IndexOf method to get the index of an item
                MessageBox.Show("Item with title: \"" + itemChecked.ToString() + "\", is checked. Checked state is: " 
                + chooseChapterchecbox.GetItemCheckState(chooseChapterchecbox.Items.IndexOf(itemChecked)).ToString() + ".");
            }
            */
        }

        private void topicDoneButton_Click(object sender, EventArgs e)
        {
            if (chooseChapterchecbox.CheckedIndices.Count > 10)
            {
                MessageBox.Show("Choose less than ten chapters");
            }

            else
            {
                // open the form to choose the topic the student is struggling the most with 
                this.Hide();
                StudentPageFirst studentLogin = new StudentPageFirst(comboBox1.SelectedItem.ToString());
                studentLogin.Show();
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backtoLoginButton_Click(object sender, EventArgs e)
        {
            Login backtoLogin = new Login();
            backtoLogin.Show();
            this.Hide();
        }
    }
}