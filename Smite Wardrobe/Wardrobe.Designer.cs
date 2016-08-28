namespace Smite_Wardrobe
{
    partial class Wardrobe
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
            this.WardrobeListView = new System.Windows.Forms.ListView();
            this.God = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Skin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // WardrobeListView
            // 
            this.WardrobeListView.BackColor = System.Drawing.Color.Black;
            this.WardrobeListView.BackgroundImage = global::Smite_Wardrobe.Properties.Resources.form1Background;
            this.WardrobeListView.BackgroundImageTiled = true;
            this.WardrobeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.God,
            this.Skin});
            this.WardrobeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WardrobeListView.ForeColor = System.Drawing.Color.White;
            this.WardrobeListView.FullRowSelect = true;
            this.WardrobeListView.GridLines = true;
            this.WardrobeListView.Location = new System.Drawing.Point(0, 0);
            this.WardrobeListView.Name = "WardrobeListView";
            this.WardrobeListView.Size = new System.Drawing.Size(421, 578);
            this.WardrobeListView.TabIndex = 0;
            this.WardrobeListView.UseCompatibleStateImageBehavior = false;
            // 
            // God
            // 
            this.God.Text = "God";
            this.God.Width = 100;
            // 
            // Skin
            // 
            this.Skin.Text = "Skin";
            this.Skin.Width = 150;
            // 
            // Wardrobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Smite_Wardrobe.Properties.Resources.form1Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 578);
            this.Controls.Add(this.WardrobeListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Wardrobe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wardrobe";
            this.Load += new System.EventHandler(this.Wardrobe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView WardrobeListView;
        private System.Windows.Forms.ColumnHeader God;
        private System.Windows.Forms.ColumnHeader Skin;
    }
}