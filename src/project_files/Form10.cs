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
    public partial class choosePosition : Form
    {
        public choosePosition()
        {
            InitializeComponent();
        }

        private void choosePosition_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }
        private void positionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (positionComboBox.SelectedItem.ToString().Contains("Teacher"))
            {
                teacherCredentials teacherRegister = new teacherCredentials();
                teacherRegister.Show();
                this.Hide();
            }

            if (positionComboBox.SelectedItem.ToString().Contains("Parent"))
            {
                parentCredentials parentRegister = new parentCredentials();
                parentRegister.Show();
                this.Hide();
            }

            if(positionComboBox.SelectedItem.ToString().Contains("Student"))
            {
                Register studentRegister = new Register();
                studentRegister.Show();
                this.Hide();
            }
        }
      }
    }

