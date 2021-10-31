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
        List<double[]> rows = new List<double[]>();
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

            UpdateRows();

        }

        private void UpdateRows()
        {
            rows[0] = new double[4]{UserController.activeUser.Balance.Proteins,
                UserController.activeUser.Balance.Carbs,
                UserController.activeUser.Balance.Fats,
                UserController.activeUser.Balance.Calories};
            dataGridView1.Rows[0].SetValues(rows[0][0], rows[0][1], rows[0][2], rows[0][3]);
            foreach (var eating in eatingController.Eatings)
            {
                rows.Add(new double[4]{eating.Prots,
                    eating.Carbs,
                    eating.Fats,
                    eating.Calories});
                dataGridView1.Rows.Add(rows[rows.Count - 1][0],
                    rows[rows.Count - 1][1],
                    rows[rows.Count - 1][2],
                    rows[rows.Count - 1][3]);
            }
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
                dataGridView1.Rows.Add(rows[rows.Count - 1][0],
                    rows[rows.Count - 1][1],
                    rows[rows.Count - 1][2],
                    rows[rows.Count - 1][3]);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].HeaderCell.Value = $"eating №{rows.Count - 1}";
            }
            foreach (var i in eatingController.Eatings)
                Debug.WriteLine(i);
            UpdateRows();
        }

        private void actToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addAct = new AddActForm(UserController);
            addAct.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void BuildDG()
        {
            #region create headers and balance row
            dataGridView1.Columns.Add("Prots", "Prots");
            dataGridView1.Columns.Add("Carbs", "Carbs");
            dataGridView1.Columns.Add("Fats", "Fats");
            dataGridView1.Columns.Add("Calory", "Calories");
            rows.Add(new double[4]{UserController.activeUser.Balance.Proteins,
                UserController.activeUser.Balance.Carbs,
                UserController.activeUser.Balance.Fats,
                UserController.activeUser.Balance.Calories});
            dataGridView1.Rows.Add(rows[0][0], rows[0][1], rows[0][2], rows[0][3]);
            dataGridView1.Rows[0].HeaderCell.Value = "balance";
            UserController.Save();
            #endregion
            UpdateRows();
        }
    }
}
