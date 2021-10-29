
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProtsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CarbsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CaloryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FatsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProtsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarbsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaloryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FatsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proteins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fats";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carbs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calories";
            // 
            // ProtsNumericUpDown
            // 
            this.ProtsNumericUpDown.DecimalPlaces = 1;
            this.ProtsNumericUpDown.Location = new System.Drawing.Point(66, 8);
            this.ProtsNumericUpDown.Name = "ProtsNumericUpDown";
            this.ProtsNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.ProtsNumericUpDown.TabIndex = 4;
            // 
            // CarbsNumericUpDown
            // 
            this.CarbsNumericUpDown.DecimalPlaces = 1;
            this.CarbsNumericUpDown.Location = new System.Drawing.Point(66, 66);
            this.CarbsNumericUpDown.Name = "CarbsNumericUpDown";
            this.CarbsNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.CarbsNumericUpDown.TabIndex = 5;
            // 
            // CaloryNumericUpDown
            // 
            this.CaloryNumericUpDown.DecimalPlaces = 1;
            this.CaloryNumericUpDown.Location = new System.Drawing.Point(66, 95);
            this.CaloryNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CaloryNumericUpDown.Name = "CaloryNumericUpDown";
            this.CaloryNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.CaloryNumericUpDown.TabIndex = 6;
            // 
            // FatsNumericUpDown
            // 
            this.FatsNumericUpDown.DecimalPlaces = 1;
            this.FatsNumericUpDown.Location = new System.Drawing.Point(66, 37);
            this.FatsNumericUpDown.Name = "FatsNumericUpDown";
            this.FatsNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.FatsNumericUpDown.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(107, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(66, 127);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(120, 23);
            this.NameTextBox.TabIndex = 11;
            this.NameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NewFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 240);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FatsNumericUpDown);
            this.Controls.Add(this.CaloryNumericUpDown);
            this.Controls.Add(this.CarbsNumericUpDown);
            this.Controls.Add(this.ProtsNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewFoodForm";
            this.Text = "NewFoodForm";
            this.Load += new System.EventHandler(this.NewFoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProtsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarbsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaloryNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FatsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ProtsNumericUpDown;
        private System.Windows.Forms.NumericUpDown CarbsNumericUpDown;
        private System.Windows.Forms.NumericUpDown CaloryNumericUpDown;
        private System.Windows.Forms.NumericUpDown FatsNumericUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}