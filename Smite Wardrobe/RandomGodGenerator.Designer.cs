namespace Smite_Wardrobe
{
    partial class RandomGodGenerator
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
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.RandomGodGeneratedLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // classComboBox
            // 
            this.classComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Items.AddRange(new object[] {
            "Any Class",
            "Assassin",
            "Guardian",
            "Hunter",
            "Mage",
            "Warrior"});
            this.classComboBox.Location = new System.Drawing.Point(143, 18);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(148, 21);
            this.classComboBox.TabIndex = 0;
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackgroundImage = global::Smite_Wardrobe.Properties.Resources.form1Background;
            this.GenerateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GenerateButton.ForeColor = System.Drawing.Color.White;
            this.GenerateButton.Location = new System.Drawing.Point(143, 45);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(148, 30);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // RandomGodGeneratedLabel
            // 
            this.RandomGodGeneratedLabel.Enabled = false;
            this.RandomGodGeneratedLabel.Location = new System.Drawing.Point(143, 82);
            this.RandomGodGeneratedLabel.Name = "RandomGodGeneratedLabel";
            this.RandomGodGeneratedLabel.Size = new System.Drawing.Size(148, 20);
            this.RandomGodGeneratedLabel.TabIndex = 3;
            // 
            // RandomGodGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Smite_Wardrobe.Properties.Resources.form1Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(308, 118);
            this.Controls.Add(this.RandomGodGeneratedLabel);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.classComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RandomGodGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Random God Generator";
            this.Load += new System.EventHandler(this.RandomGodGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox RandomGodGeneratedLabel;
    }
}