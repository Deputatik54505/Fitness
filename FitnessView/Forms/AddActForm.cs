using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessView.Forms
{
    public partial class AddActForm : Form
    {
        public AddActForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addExercise = new NewActForm();
            addExercise.ShowDialog();
        }
    }
}
