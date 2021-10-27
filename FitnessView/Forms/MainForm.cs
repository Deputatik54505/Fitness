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
            #region dataGridView
            dataGridView1.Columns.Add("Prots", "Prots");
            dataGridView1.Columns.Add("Carbs", "Carbs");
            dataGridView1.Columns.Add("Fats", "Fats");
            dataGridView1.Columns.Add("Calory", "Calories");
            dataGridView1.Rows.Add(UserController.activeUser.Balance.Proteins,
                UserController.activeUser.Balance.Carbs,
                UserController.activeUser.Balance.Fats,
                UserController.activeUser.Balance.Calories);
            dataGridView1.Rows[0].HeaderCell.Value = "balance";
            UserController.Save();



            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserController.activeUser.ThrowBalance();
        }

        private void eatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addEating = new AddEatForm(UserController);
            addEating.ShowDialog();
        }

        private void actToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addAct = new AddActForm(UserController);
            addAct.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
