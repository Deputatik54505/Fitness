
namespace FitnessView.Forms
{
    partial class AddActForm
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
            this.chooseExerciseLabel = new System.Windows.Forms.Label();
            this.exerciseListComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.newActButton = new System.Windows.Forms.Button();
            this.ActTypeComboBox = new System.Windows.Forms.ComboBox();
            this.activityTipeLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.setsLabel = new System.Windows.Forms.Label();
            this.numeric1 = new System.Windows.Forms.NumericUpDown();
            this.numeric2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseExerciseLabel
            // 
            this.chooseExerciseLabel.AutoSize = true;
            this.chooseExerciseLabel.Location = new System.Drawing.Point(17, 44);
            this.chooseExerciseLabel.Name = "chooseExerciseLabel";
            this.chooseExerciseLabel.Size = new System.Drawing.Size(92, 15);
            this.chooseExerciseLabel.TabIndex = 0;
            this.chooseExerciseLabel.Text = "Choose exercise";
            // 
            // exerciseListComboBox
            // 
            this.exerciseListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exerciseListComboBox.FormattingEnabled = true;
            this.exerciseListComboBox.Location = new System.Drawing.Point(128, 41);
            this.exerciseListComboBox.Name = "exerciseListComboBox";
            this.exerciseListComboBox.Size = new System.Drawing.Size(121, 23);
            this.exerciseListComboBox.TabIndex = 3;
            this.exerciseListComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(175, 151);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // newActButton
            // 
            this.newActButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newActButton.Location = new System.Drawing.Point(12, 151);
            this.newActButton.Name = "newActButton";
            this.newActButton.Size = new System.Drawing.Size(75, 23);
            this.newActButton.TabIndex = 5;
            this.newActButton.Text = "New Act";
            this.newActButton.UseVisualStyleBackColor = true;
            this.newActButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ActTypeComboBox
            // 
            this.ActTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActTypeComboBox.FormattingEnabled = true;
            this.ActTypeComboBox.Location = new System.Drawing.Point(128, 12);
            this.ActTypeComboBox.Name = "ActTypeComboBox";
            this.ActTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.ActTypeComboBox.TabIndex = 7;
            this.ActTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ActTypeBox_SelectedIndexChanged);
            // 
            // activityTipeLabel
            // 
            this.activityTipeLabel.AutoSize = true;
            this.activityTipeLabel.Location = new System.Drawing.Point(17, 15);
            this.activityTipeLabel.Name = "activityTipeLabel";
            this.activityTipeLabel.Size = new System.Drawing.Size(76, 15);
            this.activityTipeLabel.TabIndex = 6;
            this.activityTipeLabel.Text = "Activity type:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(17, 72);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 15);
            this.label.TabIndex = 8;
            // 
            // setsLabel
            // 
            this.setsLabel.AutoSize = true;
            this.setsLabel.Location = new System.Drawing.Point(17, 101);
            this.setsLabel.Name = "setsLabel";
            this.setsLabel.Size = new System.Drawing.Size(0, 15);
            this.setsLabel.TabIndex = 9;
            // 
            // numeric1
            // 
            this.numeric1.Location = new System.Drawing.Point(130, 70);
            this.numeric1.Name = "numeric1";
            this.numeric1.Size = new System.Drawing.Size(120, 23);
            this.numeric1.TabIndex = 10;
            // 
            // numeric2
            // 
            this.numeric2.Location = new System.Drawing.Point(130, 99);
            this.numeric2.Name = "numeric2";
            this.numeric2.Size = new System.Drawing.Size(120, 23);
            this.numeric2.TabIndex = 11;
            this.numeric2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // AddActForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 186);
            this.Controls.Add(this.numeric2);
            this.Controls.Add(this.numeric1);
            this.Controls.Add(this.setsLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ActTypeComboBox);
            this.Controls.Add(this.activityTipeLabel);
            this.Controls.Add(this.newActButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.exerciseListComboBox);
            this.Controls.Add(this.chooseExerciseLabel);
            this.Name = "AddActForm";
            this.Text = "AddActForm";
            this.Load += new System.EventHandler(this.AddActForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseExerciseLabel;
        private System.Windows.Forms.ComboBox exerciseListComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button newActButton;
        private System.Windows.Forms.ComboBox ActTypeComboBox;
        private System.Windows.Forms.Label activityTipeLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label setsLabel;
        private System.Windows.Forms.NumericUpDown numeric1;
        private System.Windows.Forms.NumericUpDown numeric2;
    }
}