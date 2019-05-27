namespace EgitimKayitUI
{
    partial class frm_Dersler
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
            this.components = new System.ComponentModel.Container();
            this.dgvDersler = new System.Windows.Forms.DataGridView();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxDuzenle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.duzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).BeginInit();
            this.ctxDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDersler
            // 
            this.dgvDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDersler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id,
            this.Col_Name});
            this.dgvDersler.ContextMenuStrip = this.ctxDuzenle;
            this.dgvDersler.Location = new System.Drawing.Point(12, 55);
            this.dgvDersler.Name = "dgvDersler";
            this.dgvDersler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDersler.Size = new System.Drawing.Size(765, 298);
            this.dgvDersler.TabIndex = 0;
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(12, 12);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(254, 37);
            this.btnDersEkle.TabIndex = 1;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // Col_Id
            // 
            this.Col_Id.DataPropertyName = "Id";
            this.Col_Id.HeaderText = "Id";
            this.Col_Id.Name = "Col_Id";
            this.Col_Id.Visible = false;
            // 
            // Col_Name
            // 
            this.Col_Name.DataPropertyName = "DersAdi";
            this.Col_Name.HeaderText = "Ders Adı";
            this.Col_Name.Name = "Col_Name";
            // 
            // ctxDuzenle
            // 
            this.ctxDuzenle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duzenleToolStripMenuItem});
            this.ctxDuzenle.Name = "ctxDuzenle";
            this.ctxDuzenle.Size = new System.Drawing.Size(181, 48);
            // 
            // duzenleToolStripMenuItem
            // 
            this.duzenleToolStripMenuItem.Name = "duzenleToolStripMenuItem";
            this.duzenleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.duzenleToolStripMenuItem.Text = "Duzenle";
            this.duzenleToolStripMenuItem.Click += new System.EventHandler(this.duzenleToolStripMenuItem_Click);
            // 
            // frm_Dersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.dgvDersler);
            this.Name = "frm_Dersler";
            this.Text = "frm_Dersler";
            this.Load += new System.EventHandler(this.frm_Dersler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).EndInit();
            this.ctxDuzenle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDersler;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.ContextMenuStrip ctxDuzenle;
        private System.Windows.Forms.ToolStripMenuItem duzenleToolStripMenuItem;
    }
}