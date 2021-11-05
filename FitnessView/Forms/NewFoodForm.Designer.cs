
namespace FitnessView.Forms
{
    partial class NewFoodForm
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
            this.protsLabel = new System.Windows.Forms.Label();
            this.fatsLabel = new System.Windows.Forms.Label();
            this.carbsLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.protsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.carbsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.caloryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fatsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.protsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // protsLabel
            // 
            this.protsLabel.AutoSize = true;
            this.protsLabel.Location = new System.Drawing.Point(10, 10);
            this.protsLabel.Name = "protsLabel";
            this.protsLabel.Size = new System.Drawing.Size(50, 15);
            this.protsLabel.TabIndex = 0;
            this.protsLabel.Text = "Proteins";
            // 
            // fatsLabel
            // 
            this.fatsLabel.AutoSize = true;
            this.fatsLabel.Location = new System.Drawing.Point(10, 40);
            this.fatsLabel.Name = "fatsLabel";
            this.fatsLabel.Size = new System.Drawing.Size(28, 15);
            this.fatsLabel.TabIndex = 1;
            this.fatsLabel.Text = "Fats";
            this.fatsLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // carbsLabel
            // 
            this.carbsLabel.AutoSize = true;
            this.carbsLabel.Location = new System.Drawing.Point(10, 70);
            this.carbsLabel.Name = "carbsLabel";
            this.carbsLabel.Size = new System.Drawing.Size(37, 15);
            this.carbsLabel.TabIndex = 2;
            this.carbsLabel.Text = "Carbs";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Location = new System.Drawing.Point(10, 100);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(49, 15);
            this.caloriesLabel.TabIndex = 3;
            this.caloriesLabel.Text = "Calories";
            // 
            // protsNumericUpDown
            // 
            this.protsNumericUpDown.DecimalPlaces = 1;
            this.protsNumericUpDown.Location = new System.Drawing.Point(66, 8);
            this.protsNumericUpDown.Name = "protsNumericUpDown";
            this.protsNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.protsNumericUpDown.TabIndex = 4;
            // 
            // carbsNumericUpDown
            // 
            this.carbsNumericUpDown.DecimalPlaces = 1;
            this.carbsNumericUpDown.Location = new System.Drawing.Point(66, 66);
            this.carbsNumericUpDown.Name = "carbsNumericUpDown";
            this.carbsNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.carbsNumericUpDown.TabIndex = 5;
            // 
            // caloryNumericUpDown
            // 
            this.caloryNumericUpDown.DecimalPlaces = 1;
            this.caloryNumericUpDown.Location = new System.Drawing.Point(66, 95);
            this.caloryNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.caloryNumericUpDown.Name = "caloryNumericUpDown";
            this.caloryNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.caloryNumericUpDown.TabIndex = 6;
            // 
            // fatsNumericUpDown
            // 
            this.fatsNumericUpDown.DecimalPlaces = 1;
            this.fatsNumericUpDown.Location = new System.Drawing.Point(66, 37);
            this.fatsNumericUpDown.Name = "fatsNumericUpDown";
            this.fatsNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.fatsNumericUpDown.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(107, 205);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 130);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(66, 127);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(120, 23);
            this.nameTextbox.TabIndex = 11;
            this.nameTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NewFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 240);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.fatsNumericUpDown);
            this.Controls.Add(this.caloryNumericUpDown);
            this.Controls.Add(this.carbsNumericUpDown);
            this.Controls.Add(this.protsNumericUpDown);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.carbsLabel);
            this.Controls.Add(this.fatsLabel);
            this.Controls.Add(this.protsLabel);
            this.Name = "NewFoodForm";
            this.Text = "NewFoodForm";
            this.Load += new System.EventHandler(this.NewFoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.protsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloryNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label protsLabel;
        private System.Windows.Forms.Label fatsLabel;
        private System.Windows.Forms.Label carbsLabel;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.NumericUpDown protsNumericUpDown;
        private System.Windows.Forms.NumericUpDown carbsNumericUpDown;
        private System.Windows.Forms.NumericUpDown caloryNumericUpDown;
        private System.Windows.Forms.NumericUpDown fatsNumericUpDown;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextbox;
    }
}