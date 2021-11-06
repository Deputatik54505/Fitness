using BL.Controller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace FitnessView.Forms
{
    public partial class MainForm : Form
    {
        public UserController UserController { get; private set; }
        List<double[]> rows;
        EatingController eatingController;
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
            eatingController = new EatingController(UserController);
            foreach(var i in eatingController.Eatings)
                Debug.WriteLine(i);
            BuildDG();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserController.ThrowBalance();
            eatingController = new EatingController(UserController);
            UpdateRows();
        }

       
        private void eatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addEating = new AddEatForm(UserController);
            addEating.ShowDialog();
            eatingController = new EatingController(UserController);
            if (addEating.DialogResult == DialogResult.OK && eatingController.Eatings.Count > 0)
            {
                var index = eatingController.Eatings.Count-1;
                rows.Add(new double[4]{ eatingController.Eatings[index].Prots ,
                    eatingController.Eatings[index].Carbs,
                    eatingController.Eatings[index].Fats,
                    eatingController.Eatings[index].Calories});
                dataGridView.Rows.Add(rows[rows.Count - 1][0],
                    rows[rows.Count - 1][1],
                    rows[rows.Count - 1][2],
                    rows[rows.Count - 1][3]);
                dataGridView.Rows[dataGridView.Rows.Count - 2].HeaderCell.Value = $"eating №{rows.Count - 1}";
            }
            foreach (var i in eatingController.Eatings)
                Debug.WriteLine(i);
            UpdateRows();
        }

        private void actToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addAct = new AddActForm(UserController);
            addAct.ShowDialog();
            UpdateRows();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}
        void BuildDG()
        {
            #region create headers and balance row
            dataGridView.Columns.Add("Prots", "Prots");
            dataGridView.Columns.Add("Carbs", "Carbs");
            dataGridView.Columns.Add("Fats", "Fats");
            dataGridView.Columns.Add("Calory", "Calories");
           
            
            #endregion
            UpdateRows();
        }
        private void UpdateRows()
        {
            dataGridView.Rows.Clear();
            rows = new List<double[]>();
            rows.Add(new double[4]{UserController.activeUser.Balance.Proteins,
                UserController.activeUser.Balance.Carbs,
                UserController.activeUser.Balance.Fats,
                UserController.activeUser.Balance.Calories});
            dataGridView.Rows.Add(rows[0][0], rows[0][1], rows[0][2], rows[0][3]);
            dataGridView.Rows[0].HeaderCell.Value = "balance";
            foreach (var eating in eatingController.Eatings)
            {
                rows.Add(new double[4]{eating.Prots,
                    eating.Carbs,
                    eating.Fats,
                    eating.Calories});
                dataGridView.Rows.Add(rows[rows.Count - 1][0],
                    rows[rows.Count - 1][1],
                    rows[rows.Count - 1][2],
                    rows[rows.Count - 1][3]);
                dataGridView.Rows[rows.Count - 1].HeaderCell.Value = $"Eating number {eatingController.Eatings.Count}";
            }
        }

        private void tabataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
