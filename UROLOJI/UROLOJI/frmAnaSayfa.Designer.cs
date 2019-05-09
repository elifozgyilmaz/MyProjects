namespace UROLOJI
{
    partial class frmAnaSayfa
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
            this.pnlLeft1 = new System.Windows.Forms.Panel();
            this.pnlLeft2 = new System.Windows.Forms.Panel();
            this.btnHastaBul = new System.Windows.Forms.Button();
            this.btnHastaKayit = new System.Windows.Forms.Button();
            this.grpLeft = new System.Windows.Forms.GroupBox();
            this.pnlLeft3 = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnUroloji = new System.Windows.Forms.Button();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.pnlLeft2.SuspendLayout();
            this.grpLeft.SuspendLayout();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft1
            // 
            this.pnlLeft1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlLeft1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft1.Location = new System.Drawing.Point(3, 16);
            this.pnlLeft1.Name = "pnlLeft1";
            this.pnlLeft1.Size = new System.Drawing.Size(192, 307);
            this.pnlLeft1.TabIndex = 2;
            // 
            // pnlLeft2
            // 
            this.pnlLeft2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlLeft2.Controls.Add(this.btnHastaBul);
            this.pnlLeft2.Controls.Add(this.btnHastaKayit);
            this.pnlLeft2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft2.Location = new System.Drawing.Point(195, 16);
            this.pnlLeft2.Name = "pnlLeft2";
            this.pnlLeft2.Size = new System.Drawing.Size(124, 307);
            this.pnlLeft2.TabIndex = 2;
            this.pnlLeft2.Visible = false;
            // 
            // btnHastaBul
            // 
            this.btnHastaBul.ForeColor = System.Drawing.Color.Black;
            this.btnHastaBul.Location = new System.Drawing.Point(3, 45);
            this.btnHastaBul.Name = "btnHastaBul";
            this.btnHastaBul.Size = new System.Drawing.Size(115, 23);
            this.btnHastaBul.TabIndex = 1;
            this.btnHastaBul.Text = "Hasta Bul";
            this.btnHastaBul.UseVisualStyleBackColor = true;
            this.btnHastaBul.Click += new System.EventHandler(this.btnHastaBul_Click);
            // 
            // btnHastaKayit
            // 
            this.btnHastaKayit.ForeColor = System.Drawing.Color.Black;
            this.btnHastaKayit.Location = new System.Drawing.Point(3, 15);
            this.btnHastaKayit.Name = "btnHastaKayit";
            this.btnHastaKayit.Size = new System.Drawing.Size(115, 23);
            this.btnHastaKayit.TabIndex = 0;
            this.btnHastaKayit.Text = "Hasta Kayıt";
            this.btnHastaKayit.UseVisualStyleBackColor = true;
            this.btnHastaKayit.Click += new System.EventHandler(this.btnHastaKayit_Click);
            // 
            // grpLeft
            // 
            this.grpLeft.BackColor = System.Drawing.Color.White;
            this.grpLeft.Controls.Add(this.pnlLeft3);
            this.grpLeft.Controls.Add(this.pnlLeft2);
            this.grpLeft.Controls.Add(this.pnlLeft1);
            this.grpLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpLeft.Location = new System.Drawing.Point(0, 99);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.Size = new System.Drawing.Size(127, 326);
            this.grpLeft.TabIndex = 3;
            this.grpLeft.TabStop = false;
            this.grpLeft.Text = "groupBox1";
            // 
            // pnlLeft3
            // 
            this.pnlLeft3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlLeft3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft3.Location = new System.Drawing.Point(319, 16);
            this.pnlLeft3.Name = "pnlLeft3";
            this.pnlLeft3.Size = new System.Drawing.Size(193, 307);
            this.pnlLeft3.TabIndex = 2;
            this.pnlLeft3.Visible = false;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(490, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(143, 65);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnUroloji
            // 
            this.btnUroloji.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUroloji.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUroloji.ForeColor = System.Drawing.Color.White;
            this.btnUroloji.Location = new System.Drawing.Point(35, 12);
            this.btnUroloji.Name = "btnUroloji";
            this.btnUroloji.Size = new System.Drawing.Size(128, 65);
            this.btnUroloji.TabIndex = 0;
            this.btnUroloji.Text = "ÜROLOJİ";
            this.btnUroloji.UseVisualStyleBackColor = false;
            this.btnUroloji.Click += new System.EventHandler(this.btnBilgiGiris_Click);
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlUst.Controls.Add(this.btnKapat);
            this.pnlUst.Controls.Add(this.btnUroloji);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(645, 99);
            this.pnlUst.TabIndex = 2;
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 425);
            this.Controls.Add(this.grpLeft);
            this.Controls.Add(this.pnlUst);
            this.IsMdiContainer = true;
            this.Name = "frmAnaSayfa";
            this.Text = "frmAnaSayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.pnlLeft2.ResumeLayout(false);
            this.grpLeft.ResumeLayout(false);
            this.pnlUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeft1;
        private System.Windows.Forms.Panel pnlLeft2;
        private System.Windows.Forms.GroupBox grpLeft;
        private System.Windows.Forms.Panel pnlLeft3;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnUroloji;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnHastaKayit;
        private System.Windows.Forms.Button btnHastaBul;
    }
}