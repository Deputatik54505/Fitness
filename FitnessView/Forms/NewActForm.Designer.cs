
namespace FitnessView.Forms
{
    partial class NewActForm
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
            this.energyCoastLabel = new System.Windows.Forms.Label();
            this.energyCoastNumeric = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.energyCoastNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // energyCoastLabel
            // 
            this.energyCoastLabel.AutoSize = true;
            this.energyCoastLabel.Location = new System.Drawing.Point(12, 41);
            this.energyCoastLabel.Name = "energyCoastLabel";
            this.energyCoastLabel.Size = new System.Drawing.Size(32, 15);
            this.energyCoastLabel.TabIndex = 0;
            this.energyCoastLabel.Text = "Error";
            this.energyCoastLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // energyCoastNumeric
            // 
            this.energyCoastNumeric.Location = new System.Drawing.Point(120, 41);
            this.energyCoastNumeric.Name = "energyCoastNumeric";
            this.energyCoastNumeric.Size = new System.Drawing.Size(120, 23);
            this.energyCoastNumeric.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(173, 85);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(120, 12);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(120, 23);
            this.nameTextbox.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // NewActForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 120);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.energyCoastNumeric);
            this.Controls.Add(this.energyCoastLabel);
            this.Name = "NewActForm";
            this.Text = "NewActForm";
            this.Load += new System.EventHandler(this.NewActForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.energyCoastNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label energyCoastLabel;
        private System.Windows.Forms.NumericUpDown energyCoastNumeric;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label nameLabel;
    }
}