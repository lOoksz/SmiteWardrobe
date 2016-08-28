namespace Smite_Wardrobe
{
    partial class addGodToDatabaseForm
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
            this.addGodButton = new System.Windows.Forms.Button();
            this.newGodNameTextBox = new System.Windows.Forms.TextBox();
            this.newGodNameLabel = new System.Windows.Forms.Label();
            this.newGodPantheonLabel = new System.Windows.Forms.Label();
            this.newGodAttackTypeLabel = new System.Windows.Forms.Label();
            this.newGodPowerTypeLabel = new System.Windows.Forms.Label();
            this.newGodClassLabel = new System.Windows.Forms.Label();
            this.newGodPantheonComboBox = new System.Windows.Forms.ComboBox();
            this.newGodAttackTypeComboBox = new System.Windows.Forms.ComboBox();
            this.newGodPowerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.newGodClassComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addGodButton
            // 
            this.addGodButton.Location = new System.Drawing.Point(196, 216);
            this.addGodButton.Name = "addGodButton";
            this.addGodButton.Size = new System.Drawing.Size(90, 23);
            this.addGodButton.TabIndex = 0;
            this.addGodButton.Text = "Add God";
            this.addGodButton.UseVisualStyleBackColor = true;
            this.addGodButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // newGodNameTextBox
            // 
            this.newGodNameTextBox.Location = new System.Drawing.Point(130, 71);
            this.newGodNameTextBox.Name = "newGodNameTextBox";
            this.newGodNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.newGodNameTextBox.TabIndex = 1;
            // 
            // newGodNameLabel
            // 
            this.newGodNameLabel.AutoSize = true;
            this.newGodNameLabel.Location = new System.Drawing.Point(30, 74);
            this.newGodNameLabel.Name = "newGodNameLabel";
            this.newGodNameLabel.Size = new System.Drawing.Size(35, 13);
            this.newGodNameLabel.TabIndex = 3;
            this.newGodNameLabel.Text = "Name";
            // 
            // newGodPantheonLabel
            // 
            this.newGodPantheonLabel.AutoSize = true;
            this.newGodPantheonLabel.Location = new System.Drawing.Point(30, 100);
            this.newGodPantheonLabel.Name = "newGodPantheonLabel";
            this.newGodPantheonLabel.Size = new System.Drawing.Size(53, 13);
            this.newGodPantheonLabel.TabIndex = 4;
            this.newGodPantheonLabel.Text = "Pantheon";
            // 
            // newGodAttackTypeLabel
            // 
            this.newGodAttackTypeLabel.AutoSize = true;
            this.newGodAttackTypeLabel.Location = new System.Drawing.Point(30, 127);
            this.newGodAttackTypeLabel.Name = "newGodAttackTypeLabel";
            this.newGodAttackTypeLabel.Size = new System.Drawing.Size(79, 13);
            this.newGodAttackTypeLabel.TabIndex = 5;
            this.newGodAttackTypeLabel.Text = "Ranged/Melee";
            // 
            // newGodPowerTypeLabel
            // 
            this.newGodPowerTypeLabel.AutoSize = true;
            this.newGodPowerTypeLabel.Location = new System.Drawing.Point(30, 154);
            this.newGodPowerTypeLabel.Name = "newGodPowerTypeLabel";
            this.newGodPowerTypeLabel.Size = new System.Drawing.Size(88, 13);
            this.newGodPowerTypeLabel.TabIndex = 6;
            this.newGodPowerTypeLabel.Text = "Magical/Physical";
            // 
            // newGodClassLabel
            // 
            this.newGodClassLabel.AutoSize = true;
            this.newGodClassLabel.Location = new System.Drawing.Point(30, 181);
            this.newGodClassLabel.Name = "newGodClassLabel";
            this.newGodClassLabel.Size = new System.Drawing.Size(32, 13);
            this.newGodClassLabel.TabIndex = 7;
            this.newGodClassLabel.Text = "Class";
            // 
            // newGodPantheonComboBox
            // 
            this.newGodPantheonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newGodPantheonComboBox.FormattingEnabled = true;
            this.newGodPantheonComboBox.Items.AddRange(new object[] {
            "Chinese",
            "Egyptian",
            "Greek",
            "Hindu",
            "Japanese",
            "Mayan",
            "Norse",
            "Roman"});
            this.newGodPantheonComboBox.Location = new System.Drawing.Point(130, 97);
            this.newGodPantheonComboBox.Name = "newGodPantheonComboBox";
            this.newGodPantheonComboBox.Size = new System.Drawing.Size(156, 21);
            this.newGodPantheonComboBox.Sorted = true;
            this.newGodPantheonComboBox.TabIndex = 8;
            // 
            // newGodAttackTypeComboBox
            // 
            this.newGodAttackTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newGodAttackTypeComboBox.FormattingEnabled = true;
            this.newGodAttackTypeComboBox.Items.AddRange(new object[] {
            "Melee",
            "Ranged"});
            this.newGodAttackTypeComboBox.Location = new System.Drawing.Point(130, 124);
            this.newGodAttackTypeComboBox.Name = "newGodAttackTypeComboBox";
            this.newGodAttackTypeComboBox.Size = new System.Drawing.Size(156, 21);
            this.newGodAttackTypeComboBox.Sorted = true;
            this.newGodAttackTypeComboBox.TabIndex = 9;
            // 
            // newGodPowerTypeComboBox
            // 
            this.newGodPowerTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newGodPowerTypeComboBox.FormattingEnabled = true;
            this.newGodPowerTypeComboBox.Items.AddRange(new object[] {
            "Magical",
            "Physical"});
            this.newGodPowerTypeComboBox.Location = new System.Drawing.Point(130, 151);
            this.newGodPowerTypeComboBox.Name = "newGodPowerTypeComboBox";
            this.newGodPowerTypeComboBox.Size = new System.Drawing.Size(156, 21);
            this.newGodPowerTypeComboBox.Sorted = true;
            this.newGodPowerTypeComboBox.TabIndex = 10;
            // 
            // newGodClassComboBox
            // 
            this.newGodClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newGodClassComboBox.FormattingEnabled = true;
            this.newGodClassComboBox.Items.AddRange(new object[] {
            "Assassin",
            "Guardian",
            "Hunter",
            "Mage",
            "Warrior"});
            this.newGodClassComboBox.Location = new System.Drawing.Point(130, 178);
            this.newGodClassComboBox.Name = "newGodClassComboBox";
            this.newGodClassComboBox.Size = new System.Drawing.Size(156, 21);
            this.newGodClassComboBox.Sorted = true;
            this.newGodClassComboBox.TabIndex = 11;
            // 
            // addGodToDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Smite_Wardrobe.Properties.Resources.form1Background;
            this.ClientSize = new System.Drawing.Size(308, 251);
            this.Controls.Add(this.newGodClassComboBox);
            this.Controls.Add(this.newGodPowerTypeComboBox);
            this.Controls.Add(this.newGodAttackTypeComboBox);
            this.Controls.Add(this.newGodPantheonComboBox);
            this.Controls.Add(this.newGodClassLabel);
            this.Controls.Add(this.newGodPowerTypeLabel);
            this.Controls.Add(this.newGodAttackTypeLabel);
            this.Controls.Add(this.newGodPantheonLabel);
            this.Controls.Add(this.newGodNameLabel);
            this.Controls.Add(this.newGodNameTextBox);
            this.Controls.Add(this.addGodButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addGodToDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add God to Database";
            this.Load += new System.EventHandler(this.addGodToDatabaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addGodButton;
        private System.Windows.Forms.TextBox newGodNameTextBox;
        private System.Windows.Forms.Label newGodNameLabel;
        private System.Windows.Forms.Label newGodPantheonLabel;
        private System.Windows.Forms.Label newGodAttackTypeLabel;
        private System.Windows.Forms.Label newGodPowerTypeLabel;
        private System.Windows.Forms.Label newGodClassLabel;
        private System.Windows.Forms.ComboBox newGodPantheonComboBox;
        private System.Windows.Forms.ComboBox newGodAttackTypeComboBox;
        private System.Windows.Forms.ComboBox newGodPowerTypeComboBox;
        private System.Windows.Forms.ComboBox newGodClassComboBox;
    }
}