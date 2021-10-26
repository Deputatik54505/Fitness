using BL.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessView.Forms
{
    public partial class NewActForm : Form
    {
        ExerciseController exerciseController;
        public NewActForm(ExerciseController exerciseController)
        {
            this.exerciseController = exerciseController;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewActForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            exerciseController.CreateActivity(textBox1.Text,(int)numericUpDown1.Value);
            exerciseController.Save();
            Close();
        }
    }
}
