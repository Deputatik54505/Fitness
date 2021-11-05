using BL.Controller;
using FitnessView.Forms;
using System;
using System.Windows.Forms;

namespace FitnessView
{
    public partial class HelloForm : Form
    {
        public UserController UserController { get;private set; }
        public HelloForm()
        {
            InitializeComponent();
        }

        private void HelloForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextbox.Text != null)
            {
                UserController userController = new UserController(nameTextbox.Text);
                if (userController.isNewUser)
                {
                    NewUser newUserForm = new NewUser(userController);
                    newUserForm.ShowDialog();
                    this.UserController = newUserForm.UserController;
                    Close();
                }
                else
                {
                    UserController = userController;
                    Close();
                }
                
            }
        }
    }
}
