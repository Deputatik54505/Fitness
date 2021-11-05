
namespace FitnessView.Forms
{
    partial class AddEatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseFoodLabel = new System.Windows.Forms.Label();
            this.foodListComboBox = new System.Windows.Forms.ComboBox();
            this.weightNumeric = new System.Windows.Forms.NumericUpDown();
            this.weightLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.newFoodButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseFoodLabel
            // 
            this.chooseFoodLabel.AutoSize = true;
            this.chooseFoodLabel.Location = new System.Drawing.Point(12, 9);
            this.chooseFoodLabel.Name = "chooseFoodLabel";
            this.chooseFoodLabel.Size = new System.Drawing.Size(75, 15);
            this.chooseFoodLabel.TabIndex = 0;
            this.chooseFoodLabel.Text = "Choose food";
            // 
            // foodListComboBox
            // 
            this.foodListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foodListComboBox.FormattingEnabled = true;
            this.foodListComboBox.Location = new System.Drawing.Point(93, 6);
            this.foodListComboBox.Name = "foodListComboBox";
            this.foodListComboBox.Size = new System.Drawing.Size(121, 23);
            this.foodListComboBox.TabIndex = 1;
            this.foodListComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // weightNumeric
            // 
            this.weightNumeric.Location = new System.Drawing.Point(94, 35);
            this.weightNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.weightNumeric.Name = "weightNumeric";
            this.weightNumeric.Size = new System.Drawing.Size(120, 23);
            this.weightNumeric.TabIndex = 2;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(12, 37);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(74, 15);
            this.weightLabel.TabIndex = 3;
            this.weightLabel.Text = "Input weight";
            // 
            // addButton
            // 
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButton.Location = new System.Drawing.Point(135, 136);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // newFoodButton
            // 
            this.newFoodButton.Location = new System.Drawing.Point(11, 136);
            this.newFoodButton.Name = "newFoodButton";
            this.newFoodButton.Size = new System.Drawing.Size(75, 23);
            this.newFoodButton.TabIndex = 5;
            this.newFoodButton.Text = "New food";
            this.newFoodButton.UseVisualStyleBackColor = true;
            this.newFoodButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddEatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 171);
            this.Controls.Add(this.newFoodButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.weightNumeric);
            this.Controls.Add(this.foodListComboBox);
            this.Controls.Add(this.chooseFoodLabel);
            this.Name = "AddEatForm";
            this.Text = "AddEatForm";
            this.Load += new System.EventHandler(this.AddEatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weightNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseFoodLabel;
        private System.Windows.Forms.ComboBox foodListComboBox;
        private System.Windows.Forms.NumericUpDown weightNumeric;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button newFoodButton;
    }
}