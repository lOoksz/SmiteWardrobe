namespace Smite_Wardrobe
{
    partial class removeGodForm
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
            this.removeGodComboBox = new System.Windows.Forms.ComboBox();
            this.removeGodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // removeGodComboBox
            // 
            this.removeGodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.removeGodComboBox.FormattingEnabled = true;
            this.removeGodComboBox.Location = new System.Drawing.Point(167, 25);
            this.removeGodComboBox.Name = "removeGodComboBox";
            this.removeGodComboBox.Size = new System.Drawing.Size(198, 21);
            this.removeGodComboBox.Sorted = true;
            this.removeGodComboBox.TabIndex = 0;
            // 
            // removeGodButton
            // 
            this.removeGodButton.Location = new System.Drawing.Point(166, 52);
            this.removeGodButton.Name = "removeGodButton";
            this.removeGodButton.Size = new System.Drawing.Size(198, 23);
            this.removeGodButton.TabIndex = 1;
            this.removeGodButton.Text = "Remove God";
            this.removeGodButton.UseVisualStyleBackColor = true;
            this.removeGodButton.Click += new System.EventHandler(this.removeGodButton_Click);
            // 
            // removeGodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Smite_Wardrobe.Properties.Resources.form1Background;
            this.ClientSize = new System.Drawing.Size(376, 92);
            this.Controls.Add(this.removeGodButton);
            this.Controls.Add(this.removeGodComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "removeGodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remove God from Database";
            this.Load += new System.EventHandler(this.removeGodForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox removeGodComboBox;
        private System.Windows.Forms.Button removeGodButton;
    }
}