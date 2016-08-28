namespace Smite_Wardrobe
{
    partial class removeSkinForm
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
            this.removeSkinGodComboBox = new System.Windows.Forms.ComboBox();
            this.removeSkinNameComboBox = new System.Windows.Forms.ComboBox();
            this.removeSkinButton = new System.Windows.Forms.Button();
            this.removeSkinGodNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // removeSkinGodComboBox
            // 
            this.removeSkinGodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.removeSkinGodComboBox.FormattingEnabled = true;
            this.removeSkinGodComboBox.Location = new System.Drawing.Point(116, 66);
            this.removeSkinGodComboBox.Name = "removeSkinGodComboBox";
            this.removeSkinGodComboBox.Size = new System.Drawing.Size(170, 21);
            this.removeSkinGodComboBox.Sorted = true;
            this.removeSkinGodComboBox.TabIndex = 0;
            this.removeSkinGodComboBox.SelectedIndexChanged += new System.EventHandler(this.removeSkinGodComboBox_SelectedIndexChanged);
            // 
            // removeSkinNameComboBox
            // 
            this.removeSkinNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.removeSkinNameComboBox.FormattingEnabled = true;
            this.removeSkinNameComboBox.Location = new System.Drawing.Point(116, 93);
            this.removeSkinNameComboBox.Name = "removeSkinNameComboBox";
            this.removeSkinNameComboBox.Size = new System.Drawing.Size(170, 21);
            this.removeSkinNameComboBox.Sorted = true;
            this.removeSkinNameComboBox.TabIndex = 1;
            // 
            // removeSkinButton
            // 
            this.removeSkinButton.Location = new System.Drawing.Point(116, 135);
            this.removeSkinButton.Name = "removeSkinButton";
            this.removeSkinButton.Size = new System.Drawing.Size(170, 23);
            this.removeSkinButton.TabIndex = 2;
            this.removeSkinButton.Text = "Remove Skin";
            this.removeSkinButton.UseVisualStyleBackColor = true;
            this.removeSkinButton.Click += new System.EventHandler(this.removeSkinButton_Click);
            // 
            // removeSkinGodNameLabel
            // 
            this.removeSkinGodNameLabel.AutoSize = true;
            this.removeSkinGodNameLabel.Location = new System.Drawing.Point(30, 69);
            this.removeSkinGodNameLabel.Name = "removeSkinGodNameLabel";
            this.removeSkinGodNameLabel.Size = new System.Drawing.Size(58, 13);
            this.removeSkinGodNameLabel.TabIndex = 3;
            this.removeSkinGodNameLabel.Text = "God Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Skin Name";
            // 
            // removeSkinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Smite_Wardrobe.Properties.Resources.form1Background;
            this.ClientSize = new System.Drawing.Size(298, 170);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeSkinGodNameLabel);
            this.Controls.Add(this.removeSkinButton);
            this.Controls.Add(this.removeSkinNameComboBox);
            this.Controls.Add(this.removeSkinGodComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "removeSkinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remove Skin from Database";
            this.Load += new System.EventHandler(this.removeSkinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox removeSkinGodComboBox;
        private System.Windows.Forms.ComboBox removeSkinNameComboBox;
        private System.Windows.Forms.Button removeSkinButton;
        private System.Windows.Forms.Label removeSkinGodNameLabel;
        private System.Windows.Forms.Label label1;
    }
}