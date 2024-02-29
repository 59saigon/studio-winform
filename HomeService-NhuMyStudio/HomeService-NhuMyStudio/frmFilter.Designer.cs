namespace HomeService_NhuMyStudio
{
    partial class frmFilter
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
            this.btnReviewNewFolder = new ReaLTaiizor.Controls.MaterialButton();
            this.btnNewFolder = new ReaLTaiizor.Controls.MaterialButton();
            this.btnReviewFolder = new ReaLTaiizor.Controls.MaterialButton();
            this.btnFolder = new ReaLTaiizor.Controls.MaterialButton();
            this.metroLabel2 = new ReaLTaiizor.Controls.MetroLabel();
            this.txtNewFolder = new ReaLTaiizor.Controls.SkyTextBox();
            this.dgvNewFolder = new System.Windows.Forms.DataGridView();
            this.txtFolder = new ReaLTaiizor.Controls.SkyTextBox();
            this.btnSelectAll = new ReaLTaiizor.Controls.MaterialButton();
            this.btnRemoveAll = new ReaLTaiizor.Controls.MaterialButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnJpg = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCr3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAll = new System.Windows.Forms.ToolStripMenuItem();
            this.cr3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRestart = new ReaLTaiizor.Controls.AirButton();
            this.btnSave = new ReaLTaiizor.Controls.AirButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewFolder)).BeginInit();
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
            // 
            // btnReviewNewFolder
            // 
            this.btnReviewNewFolder.AutoSize = false;
            this.btnReviewNewFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReviewNewFolder.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReviewNewFolder.Depth = 0;
            this.btnReviewNewFolder.HighEmphasis = true;
            this.btnReviewNewFolder.Icon = null;
            this.btnReviewNewFolder.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnReviewNewFolder.Location = new System.Drawing.Point(630, 29);
            this.btnReviewNewFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReviewNewFolder.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnReviewNewFolder.Name = "btnReviewNewFolder";
            this.btnReviewNewFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReviewNewFolder.Size = new System.Drawing.Size(223, 36);
            this.btnReviewNewFolder.TabIndex = 10;
            this.btnReviewNewFolder.Text = "Xem thư mục";
            this.btnReviewNewFolder.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReviewNewFolder.UseAccentColor = false;
            this.btnReviewNewFolder.UseVisualStyleBackColor = true;
            this.btnReviewNewFolder.Click += new System.EventHandler(this.btnReviewNewFolder_Click);
            // 
            // btnNewFolder
            // 
            this.btnNewFolder.AutoSize = false;
            this.btnNewFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewFolder.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNewFolder.Depth = 0;
            this.btnNewFolder.HighEmphasis = true;
            this.btnNewFolder.Icon = null;
            this.btnNewFolder.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnNewFolder.Location = new System.Drawing.Point(448, 29);
            this.btnNewFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNewFolder.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnNewFolder.Name = "btnNewFolder";
            this.btnNewFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNewFolder.Size = new System.Drawing.Size(174, 36);
            this.btnNewFolder.TabIndex = 8;
            this.btnNewFolder.Text = "Lưu tại...";
            this.btnNewFolder.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNewFolder.UseAccentColor = false;
            this.btnNewFolder.UseVisualStyleBackColor = true;
            this.btnNewFolder.Click += new System.EventHandler(this.btnNewFolder_Click);
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
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.IsDerivedStyle = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 375);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(327, 39);
            this.metroLabel2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Lưu ý: Dùng phím cách để chuyển ảnh ( một hoặc nhiều file ảnh )";
            this.metroLabel2.ThemeAuthor = "Taiizor";
            this.metroLabel2.ThemeName = "MetroLight";
            // 
            // txtNewFolder
            // 
            this.txtNewFolder.BackColor = System.Drawing.Color.MistyRose;
            this.txtNewFolder.BaseColor = System.Drawing.Color.Transparent;
            this.txtNewFolder.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtNewFolder.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txtNewFolder.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtNewFolder.BorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtNewFolder.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.txtNewFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.txtNewFolder.Location = new System.Drawing.Point(448, 57);
            this.txtNewFolder.MaxLength = 32767;
            this.txtNewFolder.MultiLine = false;
            this.txtNewFolder.Name = "txtNewFolder";
            this.txtNewFolder.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txtNewFolder.Size = new System.Drawing.Size(405, 25);
            this.txtNewFolder.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txtNewFolder.TabIndex = 24;
            this.txtNewFolder.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewFolder.UnknownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtNewFolder.UseSystemPasswordChar = false;
            // 
            // dgvNewFolder
            // 
            this.dgvNewFolder.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvNewFolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewFolder.Location = new System.Drawing.Point(446, 119);
            this.dgvNewFolder.Name = "dgvNewFolder";
            this.dgvNewFolder.RowHeadersWidth = 56;
            this.dgvNewFolder.RowTemplate.Height = 24;
            this.dgvNewFolder.Size = new System.Drawing.Size(405, 253);
            this.dgvNewFolder.TabIndex = 14;
            this.dgvNewFolder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewFolder_CellContentClick);
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
            // btnSelectAll
            // 
            this.btnSelectAll.AutoSize = false;
            this.btnSelectAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectAll.BackColor = System.Drawing.Color.Pink;
            this.btnSelectAll.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelectAll.Depth = 0;
            this.btnSelectAll.HighEmphasis = true;
            this.btnSelectAll.Icon = null;
            this.btnSelectAll.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSelectAll.Location = new System.Drawing.Point(334, 375);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelectAll.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSelectAll.Size = new System.Drawing.Size(107, 36);
            this.btnSelectAll.TabIndex = 24;
            this.btnSelectAll.Text = "Chọn hết";
            this.btnSelectAll.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSelectAll.UseAccentColor = false;
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.AutoSize = false;
            this.btnRemoveAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveAll.BackColor = System.Drawing.Color.Pink;
            this.btnRemoveAll.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemoveAll.Depth = 0;
            this.btnRemoveAll.HighEmphasis = true;
            this.btnRemoveAll.Icon = null;
            this.btnRemoveAll.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnRemoveAll.Location = new System.Drawing.Point(449, 375);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemoveAll.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemoveAll.Size = new System.Drawing.Size(107, 36);
            this.btnRemoveAll.TabIndex = 25;
            this.btnRemoveAll.Text = "Xóa hết";
            this.btnRemoveAll.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnRemoveAll.UseAccentColor = false;
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(868, 29);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMenu
            // 
            this.btnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile,
            this.cr3ToolStripMenuItem});
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
            this.btnFile.Size = new System.Drawing.Size(148, 30);
            this.btnFile.Text = "Files";
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnJpg
            // 
            this.btnJpg.Name = "btnJpg";
            this.btnJpg.Size = new System.Drawing.Size(126, 30);
            this.btnJpg.Text = ".jpg";
            this.btnJpg.Click += new System.EventHandler(this.btnJpg_Click);
            // 
            // btnCr3
            // 
            this.btnCr3.Name = "btnCr3";
            this.btnCr3.Size = new System.Drawing.Size(126, 30);
            this.btnCr3.Text = ".cr3";
            this.btnCr3.Click += new System.EventHandler(this.btnCr3_Click);
            // 
            // btnAll
            // 
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(126, 30);
            this.btnAll.Text = "All";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // cr3ToolStripMenuItem
            // 
            this.cr3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCopy,
            this.btnCut});
            this.cr3ToolStripMenuItem.Name = "cr3ToolStripMenuItem";
            this.cr3ToolStripMenuItem.Size = new System.Drawing.Size(148, 30);
            this.cr3ToolStripMenuItem.Text = "Modes";
            this.cr3ToolStripMenuItem.Click += new System.EventHandler(this.cr3ToolStripMenuItem_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(134, 30);
            this.btnCopy.Text = "copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCut
            // 
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(134, 30);
            this.btnCut.Text = "cut";
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Customization = "AAD///Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRestart.Image = null;
            this.btnRestart.Location = new System.Drawing.Point(616, 376);
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
            this.btnSave.Location = new System.Drawing.Point(744, 376);
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
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1, 91);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 22);
            this.txtSearch.TabIndex = 30;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(868, 431);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtNewFolder);
            this.Controls.Add(this.btnNewFolder);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.dgvNewFolder);
            this.Controls.Add(this.dgvFolder);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnReviewFolder);
            this.Controls.Add(this.btnReviewNewFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFilter";
            this.Load += new System.EventHandler(this.frmFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewFolder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFolder;
        private System.Windows.Forms.DataGridView dgvNewFolder;
        private ReaLTaiizor.Controls.SkyTextBox txtNewFolder;
        private ReaLTaiizor.Controls.SkyTextBox txtFolder;
        private ReaLTaiizor.Controls.MetroLabel metroLabel2;
        private ReaLTaiizor.Controls.MaterialButton btnSelectAll;
        private ReaLTaiizor.Controls.MaterialButton btnRemoveAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenu;
        private System.Windows.Forms.ToolStripMenuItem btnFile;
        private System.Windows.Forms.ToolStripMenuItem cr3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnJpg;
        private System.Windows.Forms.ToolStripMenuItem btnCr3;
        private System.Windows.Forms.ToolStripMenuItem btnCopy;
        private System.Windows.Forms.ToolStripMenuItem btnCut;
        private System.Windows.Forms.ToolStripMenuItem btnAll;
        private ReaLTaiizor.Controls.MaterialButton btnReviewNewFolder;
        private ReaLTaiizor.Controls.MaterialButton btnNewFolder;
        private ReaLTaiizor.Controls.MaterialButton btnReviewFolder;
        private ReaLTaiizor.Controls.MaterialButton btnFolder;
        private ReaLTaiizor.Controls.AirButton btnRestart;
        private ReaLTaiizor.Controls.AirButton btnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSearch;
    }
}