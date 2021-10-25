using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessView.Forms
{
    public partial class AddEatForm : Form
    {
        public AddEatForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddEatForm_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addFood = new NewFoodForm();
            addFood.ShowDialog();
        }
    }
}
