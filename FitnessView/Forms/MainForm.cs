using BL.Controller;
using System;
using System.Windows.Forms;

namespace FitnessView.Forms
{
    public partial class MainForm : Form
    {
        public UserController UserController { get; private set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var helloForm = new HelloForm();
            helloForm.ShowDialog();
            if (helloForm.UserController != null)
            {
                UserController = helloForm.UserController;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserController.activeUser.ThrowBalance();
        }

        private void eatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addEating = new AddEatForm();
            addEating.ShowDialog();
        }

        private void actToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addAct = new AddActForm();
            addAct.ShowDialog();
        }
    }
}
