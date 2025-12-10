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
    public partial class RoleChoice : Form
    {
        public RoleChoice()
        {
            InitializeComponent();
        }

        private void RoleChoice_Load(object sender, EventArgs e)
        {

        }

        private void openRegisterButton_Click(object sender, EventArgs e)
        {
            if(roleComboBox.SelectedItem.ToString().Contains("Student"))
            {
                StudentDetails student = new StudentDetails();
                student.Show();
                this.Hide();
            }
        }
    }
}
