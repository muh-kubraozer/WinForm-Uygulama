namespace EgitimKayitUI
{
    partial class AnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modüllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derslerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şubelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogretmenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modüllerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modüllerToolStripMenuItem
            // 
            this.modüllerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrencilerToolStripMenuItem,
            this.derslerToolStripMenuItem,
            this.şubelerToolStripMenuItem,
            this.ogretmenlerToolStripMenuItem});
            this.modüllerToolStripMenuItem.Name = "modüllerToolStripMenuItem";
            this.modüllerToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.modüllerToolStripMenuItem.Text = "Modüller";
            // 
            // öğrencilerToolStripMenuItem
            // 
            this.öğrencilerToolStripMenuItem.Name = "öğrencilerToolStripMenuItem";
            this.öğrencilerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğrencilerToolStripMenuItem.Text = "Öğrenciler";
            this.öğrencilerToolStripMenuItem.Click += new System.EventHandler(this.öğrencilerToolStripMenuItem_Click);
            // 
            // derslerToolStripMenuItem
            // 
            this.derslerToolStripMenuItem.Name = "derslerToolStripMenuItem";
            this.derslerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.derslerToolStripMenuItem.Text = "Dersler";
            this.derslerToolStripMenuItem.Click += new System.EventHandler(this.derslerToolStripMenuItem_Click);
            // 
            // şubelerToolStripMenuItem
            // 
            this.şubelerToolStripMenuItem.Name = "şubelerToolStripMenuItem";
            this.şubelerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.şubelerToolStripMenuItem.Text = "Şubeler";
            // 
            // ogretmenlerToolStripMenuItem
            // 
            this.ogretmenlerToolStripMenuItem.Name = "ogretmenlerToolStripMenuItem";
            this.ogretmenlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ogretmenlerToolStripMenuItem.Text = "Ogretmenler";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modüllerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrencilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derslerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şubelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogretmenlerToolStripMenuItem;
    }
}