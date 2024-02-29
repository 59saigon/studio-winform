namespace HomeService_NhuMyStudio
{
    partial class frmRename
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
            this.dgvFolder = new System.Windows.Forms.DataGridView();
            this.btnReviewFolder = new ReaLTaiizor.Controls.MaterialButton();
            this.btnFolder = new ReaLTaiizor.Controls.MaterialButton();
            this.txtFolder = new ReaLTaiizor.Controls.SkyTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnJpg = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCr3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRestart = new ReaLTaiizor.Controls.AirButton();
            this.btnSave = new ReaLTaiizor.Controls.AirButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodeStart = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFolder
            // 
            this.dgvFolder.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvFolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFolder.Location = new System.Drawing.Point(-1, 119);
            this.dgvFolder.Name = "dgvFolder";
            this.dgvFolder.RowHeadersWidth = 56;
            this.dgvFolder.RowTemplate.Height = 24;
            this.dgvFolder.Size = new System.Drawing.Size(442, 253);
            this.dgvFolder.TabIndex = 2;
            this.dgvFolder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFolder_CellContentClick);
            // 
            // btnReviewFolder
            // 
            this.btnReviewFolder.AutoSize = false;
            this.btnReviewFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReviewFolder.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReviewFolder.Depth = 0;
            this.btnReviewFolder.HighEmphasis = true;
            this.btnReviewFolder.Icon = null;
            this.btnReviewFolder.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnReviewFolder.Location = new System.Drawing.Point(213, 29);
            this.btnReviewFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReviewFolder.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnReviewFolder.Name = "btnReviewFolder";
            this.btnReviewFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReviewFolder.Size = new System.Drawing.Size(228, 36);
            this.btnReviewFolder.TabIndex = 9;
            this.btnReviewFolder.Text = "Xem thư mục";
            this.btnReviewFolder.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReviewFolder.UseAccentColor = false;
            this.btnReviewFolder.UseVisualStyleBackColor = true;
            this.btnReviewFolder.Click += new System.EventHandler(this.btnReviewFolder_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.AutoSize = false;
            this.btnFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFolder.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFolder.Depth = 0;
            this.btnFolder.HighEmphasis = true;
            this.btnFolder.Icon = null;
            this.btnFolder.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnFolder.Location = new System.Drawing.Point(1, 29);
            this.btnFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFolder.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFolder.Size = new System.Drawing.Size(204, 36);
            this.btnFolder.TabIndex = 4;
            this.btnFolder.Text = "Tìm thư mục";
            this.btnFolder.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFolder.UseAccentColor = false;
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.BackColor = System.Drawing.Color.MistyRose;
            this.txtFolder.BaseColor = System.Drawing.Color.Transparent;
            this.txtFolder.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtFolder.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txtFolder.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtFolder.BorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtFolder.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.txtFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.txtFolder.Location = new System.Drawing.Point(0, 57);
            this.txtFolder.MaxLength = 32767;
            this.txtFolder.MultiLine = false;
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txtFolder.Size = new System.Drawing.Size(441, 25);
            this.txtFolder.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txtFolder.TabIndex = 23;
            this.txtFolder.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFolder.UnknownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtFolder.UseSystemPasswordChar = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(443, 29);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMenu
            // 
            this.btnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile});
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(80, 25);
            this.btnMenu.Text = "Settings";
            // 
            // btnFile
            // 
            this.btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnJpg,
            this.btnCr3,
            this.btnAll});
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(243, 30);
            this.btnFile.Text = "Files";
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnJpg
            // 
            this.btnJpg.Name = "btnJpg";
            this.btnJpg.Size = new System.Drawing.Size(243, 30);
            this.btnJpg.Text = ".jpg";
            this.btnJpg.Click += new System.EventHandler(this.btnJpg_Click);
            // 
            // btnCr3
            // 
            this.btnCr3.Name = "btnCr3";
            this.btnCr3.Size = new System.Drawing.Size(243, 30);
            this.btnCr3.Text = ".cr3";
            this.btnCr3.Click += new System.EventHandler(this.btnCr3_Click);
            // 
            // btnAll
            // 
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(243, 30);
            this.btnAll.Text = "All";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Customization = "AAD///Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRestart.Image = null;
            this.btnRestart.Location = new System.Drawing.Point(204, 378);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.NoRounding = false;
            this.btnRestart.Size = new System.Drawing.Size(109, 45);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Khởi động lại";
            this.btnRestart.Transparent = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Customization = "AP8A//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.Image = null;
            this.btnSave.Location = new System.Drawing.Point(332, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.NoRounding = false;
            this.btnSave.Size = new System.Drawing.Size(109, 45);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Lưu tập tin";
            this.btnSave.Transparent = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-20, -20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "+  Code start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "FileName";
            // 
            // txtCodeStart
            // 
            this.txtCodeStart.Location = new System.Drawing.Point(331, 88);
            this.txtCodeStart.Name = "txtCodeStart";
            this.txtCodeStart.Size = new System.Drawing.Size(100, 22);
            this.txtCodeStart.TabIndex = 36;
            this.txtCodeStart.TextChanged += new System.EventHandler(this.txtCodeStart_TextChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(105, 88);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(100, 22);
            this.txtFileName.TabIndex = 35;
            // 
            // frmRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(443, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodeStart);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.dgvFolder);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnReviewFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRename";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFilter";
            this.Load += new System.EventHandler(this.frmFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFolder;
        private ReaLTaiizor.Controls.SkyTextBox txtFolder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenu;
        private System.Windows.Forms.ToolStripMenuItem btnFile;
        private System.Windows.Forms.ToolStripMenuItem btnJpg;
        private System.Windows.Forms.ToolStripMenuItem btnCr3;
        private System.Windows.Forms.ToolStripMenuItem btnAll;
        private ReaLTaiizor.Controls.MaterialButton btnReviewFolder;
        private ReaLTaiizor.Controls.MaterialButton btnFolder;
        private ReaLTaiizor.Controls.AirButton btnRestart;
        private ReaLTaiizor.Controls.AirButton btnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodeStart;
        private System.Windows.Forms.TextBox txtFileName;
    }
}