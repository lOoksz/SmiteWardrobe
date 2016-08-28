namespace Smite_Wardrobe
{
    partial class addSkinToDatabaseForm
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
            this.newGodSkinComboBox = new System.Windows.Forms.ComboBox();
            this.newSkinTextBox = new System.Windows.Forms.TextBox();
            this.newGodSkinLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addSkinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newGodSkinComboBox
            // 
            this.newGodSkinComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newGodSkinComboBox.FormattingEnabled = true;
            this.newGodSkinComboBox.Location = new System.Drawing.Point(126, 66);
            this.newGodSkinComboBox.Name = "newGodSkinComboBox";
            this.newGodSkinComboBox.Size = new System.Drawing.Size(142, 21);
            this.newGodSkinComboBox.Sorted = true;
            this.newGodSkinComboBox.TabIndex = 0;
            this.newGodSkinComboBox.SelectedIndexChanged += new System.EventHandler(this.newGodSkinComboBox_SelectedIndexChanged);
            // 
            // newSkinTextBox
            // 
            this.newSkinTextBox.Location = new System.Drawing.Point(126, 93);
            this.newSkinTextBox.Name = "newSkinTextBox";
            this.newSkinTextBox.Size = new System.Drawing.Size(142, 20);
            this.newSkinTextBox.TabIndex = 1;
            // 
            // newGodSkinLabel
            // 
            this.newGodSkinLabel.AutoSize = true;
            this.newGodSkinLabel.Location = new System.Drawing.Point(44, 69);
            this.newGodSkinLabel.Name = "newGodSkinLabel";
            this.newGodSkinLabel.Size = new System.Drawing.Size(76, 13);
            this.newGodSkinLabel.TabIndex = 2;
            this.newGodSkinLabel.Text = "New skin is for";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name of new skin";
            // 
            // addSkinButton
            // 
            this.addSkinButton.Location = new System.Drawing.Point(126, 119);
            this.addSkinButton.Name = "addSkinButton";
            this.addSkinButton.Size = new System.Drawing.Size(142, 23);
            this.addSkinButton.TabIndex = 4;
            this.addSkinButton.Text = "Add Skin";
            this.addSkinButton.UseVisualStyleBackColor = true;
            this.addSkinButton.Click += new System.EventHandler(this.addSkinButton_Click);
            // 
            // addSkinToDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Smite_Wardrobe.Properties.Resources.form1Background;
            this.ClientSize = new System.Drawing.Size(298, 170);
            this.Controls.Add(this.addSkinButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newGodSkinLabel);
            this.Controls.Add(this.newSkinTextBox);
            this.Controls.Add(this.newGodSkinComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addSkinToDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Skin to Database";
            this.Load += new System.EventHandler(this.addSkinToDatabaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox newGodSkinComboBox;
        private System.Windows.Forms.TextBox newSkinTextBox;
        private System.Windows.Forms.Label newGodSkinLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addSkinButton;
    }
}