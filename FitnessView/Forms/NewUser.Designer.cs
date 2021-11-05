
namespace FitnessView.Forms
{
    partial class NewUser
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
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.actLabel = new System.Windows.Forms.Label();
            this.weightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.actNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(10, 10);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(101, 15);
            this.weightLabel.TabIndex = 0;
            this.weightLabel.Text = "Input your weight";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(10, 50);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(99, 15);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Input your height";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(10, 90);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(84, 15);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Input your age";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(10, 130);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(114, 15);
            this.genderLabel.TabIndex = 3;
            this.genderLabel.Text = "Choose your gender";
            // 
            // actLabel
            // 
            this.actLabel.AutoSize = true;
            this.actLabel.Location = new System.Drawing.Point(10, 170);
            this.actLabel.Name = "actLabel";
            this.actLabel.Size = new System.Drawing.Size(106, 30);
            this.actLabel.TabIndex = 4;
            this.actLabel.Text = "Input your activity \r\ncoeff";
            // 
            // weightNumericUpDown
            // 
            this.weightNumericUpDown.Location = new System.Drawing.Point(131, 7);
            this.weightNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.weightNumericUpDown.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.weightNumericUpDown.Name = "weightNumericUpDown";
            this.weightNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.weightNumericUpDown.TabIndex = 5;
            this.weightNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.Location = new System.Drawing.Point(131, 45);
            this.heightNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.heightNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.heightNumericUpDown.TabIndex = 6;
            this.heightNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.Location = new System.Drawing.Point(131, 88);
            this.ageNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.ageNumericUpDown.TabIndex = 7;
            this.ageNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "female",
            "male"});
            this.genderComboBox.Location = new System.Drawing.Point(131, 127);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 23);
            this.genderComboBox.TabIndex = 8;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // actNumericUpDown
            // 
            this.actNumericUpDown.DecimalPlaces = 1;
            this.actNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.actNumericUpDown.Location = new System.Drawing.Point(131, 177);
            this.actNumericUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.actNumericUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            this.actNumericUpDown.Name = "actNumericUpDown";
            this.actNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.actNumericUpDown.TabIndex = 9;
            this.actNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.saveButton.Location = new System.Drawing.Point(176, 215);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 250);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.actNumericUpDown);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.ageNumericUpDown);
            this.Controls.Add(this.heightNumericUpDown);
            this.Controls.Add(this.weightNumericUpDown);
            this.Controls.Add(this.actLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.weightLabel);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label actLabel;
        private System.Windows.Forms.NumericUpDown weightNumericUpDown;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.NumericUpDown ageNumericUpDown;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.NumericUpDown actNumericUpDown;
        private System.Windows.Forms.Button saveButton;
    }
}