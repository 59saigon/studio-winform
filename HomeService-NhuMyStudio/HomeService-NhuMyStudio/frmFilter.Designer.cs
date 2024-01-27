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
            this.lọcẢnhNhanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jpgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cr3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
            this.dgvFolder = new System.Windows.Forms.DataGridView();
            this.txtSearch = new ReaLTaiizor.Controls.FoxTextBox();
            this.btnSave = new ReaLTaiizor.Controls.NightButton();
            this.btnNewFolder = new ReaLTaiizor.Controls.MaterialButton();
            this.btnRestart = new ReaLTaiizor.Controls.NightButton();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvNewFolder = new System.Windows.Forms.DataGridView();
            this.btnAdd = new ReaLTaiizor.Controls.DreamButton();
            this.txtNewFolder = new ReaLTaiizor.Controls.DungeonTextBox();
            this.btnFolder = new ReaLTaiizor.Controls.MaterialButton();
            this.txtFolder = new ReaLTaiizor.Controls.DungeonTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolder)).BeginInit();
            this.parrotGradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewFolder)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lọcẢnhNhanhToolStripMenuItem
            // 
            this.lọcẢnhNhanhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jpgToolStripMenuItem,
            this.cr3ToolStripMenuItem});
            this.lọcẢnhNhanhToolStripMenuItem.Name = "lọcẢnhNhanhToolStripMenuItem";
            this.lọcẢnhNhanhToolStripMenuItem.Size = new System.Drawing.Size(126, 25);
            this.lọcẢnhNhanhToolStripMenuItem.Text = "Lọc ảnh nhanh";
            // 
            // jpgToolStripMenuItem
            // 
            this.jpgToolStripMenuItem.Name = "jpgToolStripMenuItem";
            this.jpgToolStripMenuItem.Size = new System.Drawing.Size(126, 30);
            this.jpgToolStripMenuItem.Text = ".jpg";
            // 
            // cr3ToolStripMenuItem
            // 
            this.cr3ToolStripMenuItem.Name = "cr3ToolStripMenuItem";
            this.cr3ToolStripMenuItem.Size = new System.Drawing.Size(126, 30);
            this.cr3ToolStripMenuItem.Text = ".cr3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lọcẢnhNhanhToolStripMenuItem,
            this.lọcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lọcToolStripMenuItem
            // 
            this.lọcToolStripMenuItem.Name = "lọcToolStripMenuItem";
            this.lọcToolStripMenuItem.Size = new System.Drawing.Size(142, 25);
            this.lọcToolStripMenuItem.Text = " Lọc file scan ảnh";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroLabel1.IsDerivedStyle = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 59);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(184, 23);
            this.metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "DANH SÁCH FILE";
            this.metroLabel1.ThemeAuthor = "Taiizor";
            this.metroLabel1.ThemeName = "MetroLight";
            // 
            // dgvFolder
            // 
            this.dgvFolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFolder.Location = new System.Drawing.Point(25, 139);
            this.dgvFolder.Name = "dgvFolder";
            this.dgvFolder.RowHeadersWidth = 56;
            this.dgvFolder.RowTemplate.Height = 24;
            this.dgvFolder.Size = new System.Drawing.Size(442, 266);
            this.dgvFolder.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearch.EnabledCalc = true;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.txtSearch.Location = new System.Drawing.Point(25, 104);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MultiLine = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.Size = new System.Drawing.Size(236, 29);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSave.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnSave.HoverForeColor = System.Drawing.Color.Lime;
            this.btnSave.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.btnSave.Location = new System.Drawing.Point(654, 3);
            this.btnSave.MinimumSize = new System.Drawing.Size(144, 47);
            this.btnSave.Name = "btnSave";
            this.btnSave.NormalBackColor = System.Drawing.Color.Lime;
            this.btnSave.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.btnSave.PressedBackColor = System.Drawing.Color.DarkGreen;
            this.btnSave.PressedForeColor = System.Drawing.Color.White;
            this.btnSave.Radius = 20;
            this.btnSave.Size = new System.Drawing.Size(231, 47);
            this.btnSave.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu tập tin";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnNewFolder.Location = new System.Drawing.Point(-10, 26);
            this.btnNewFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNewFolder.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnNewFolder.Name = "btnNewFolder";
            this.btnNewFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNewFolder.Size = new System.Drawing.Size(226, 36);
            this.btnNewFolder.TabIndex = 8;
            this.btnNewFolder.Text = "Lưu tại...";
            this.btnNewFolder.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNewFolder.UseAccentColor = false;
            this.btnNewFolder.UseVisualStyleBackColor = true;
            this.btnNewFolder.Click += new System.EventHandler(this.btnNewFolder_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRestart.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRestart.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnRestart.HoverForeColor = System.Drawing.Color.Red;
            this.btnRestart.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.btnRestart.Location = new System.Drawing.Point(408, 3);
            this.btnRestart.MinimumSize = new System.Drawing.Size(144, 47);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnRestart.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.btnRestart.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnRestart.PressedForeColor = System.Drawing.Color.White;
            this.btnRestart.Radius = 20;
            this.btnRestart.Size = new System.Drawing.Size(231, 47);
            this.btnRestart.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Khởi động lại";
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.IndianRed;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.Plum;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Controls.Add(this.btnSave);
            this.parrotGradientPanel1.Controls.Add(this.btnRestart);
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 455);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(928, 85);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel1.TabIndex = 11;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNewFolder);
            this.panel2.Controls.Add(this.btnNewFolder);
            this.panel2.Location = new System.Drawing.Point(696, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 13;
            // 
            // dgvNewFolder
            // 
            this.dgvNewFolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewFolder.Location = new System.Drawing.Point(491, 139);
            this.dgvNewFolder.Name = "dgvNewFolder";
            this.dgvNewFolder.RowHeadersWidth = 56;
            this.dgvNewFolder.RowTemplate.Height = 24;
            this.dgvNewFolder.Size = new System.Drawing.Size(405, 266);
            this.dgvNewFolder.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnAdd.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnAdd.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAdd.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.ForeColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(347, 410);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 38);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNewFolder
            // 
            this.txtNewFolder.BackColor = System.Drawing.Color.Transparent;
            this.txtNewFolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtNewFolder.EdgeColor = System.Drawing.Color.White;
            this.txtNewFolder.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNewFolder.ForeColor = System.Drawing.Color.DimGray;
            this.txtNewFolder.Location = new System.Drawing.Point(-6, 63);
            this.txtNewFolder.MaxLength = 32767;
            this.txtNewFolder.Multiline = false;
            this.txtNewFolder.Name = "txtNewFolder";
            this.txtNewFolder.ReadOnly = false;
            this.txtNewFolder.Size = new System.Drawing.Size(216, 34);
            this.txtNewFolder.TabIndex = 19;
            this.txtNewFolder.Text = "TraMy";
            this.txtNewFolder.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewFolder.UseSystemPasswordChar = false;
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
            this.btnFolder.Location = new System.Drawing.Point(-18, 26);
            this.btnFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFolder.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFolder.Size = new System.Drawing.Size(239, 36);
            this.btnFolder.TabIndex = 4;
            this.btnFolder.Text = "Thư mục ảnh cần lọc";
            this.btnFolder.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFolder.UseAccentColor = false;
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.BackColor = System.Drawing.Color.Transparent;
            this.txtFolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtFolder.EdgeColor = System.Drawing.Color.White;
            this.txtFolder.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtFolder.ForeColor = System.Drawing.Color.DimGray;
            this.txtFolder.Location = new System.Drawing.Point(-6, 63);
            this.txtFolder.MaxLength = 32767;
            this.txtFolder.Multiline = false;
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = false;
            this.txtFolder.Size = new System.Drawing.Size(221, 34);
            this.txtFolder.TabIndex = 18;
            this.txtFolder.Text = "TraMy";
            this.txtFolder.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFolder.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFolder);
            this.panel1.Controls.Add(this.btnFolder);
            this.panel1.Location = new System.Drawing.Point(490, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 12;
            // 
            // frmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 534);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvNewFolder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.parrotGradientPanel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvFolder);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFilter";
            this.Text = "frmFilter";
            this.Load += new System.EventHandler(this.frmFilter_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolder)).EndInit();
            this.parrotGradientPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewFolder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem lọcẢnhNhanhToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jpgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cr3ToolStripMenuItem;
        private ReaLTaiizor.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgvFolder;
        private ReaLTaiizor.Controls.FoxTextBox txtSearch;
        private ReaLTaiizor.Controls.NightButton btnSave;
        private ReaLTaiizor.Controls.MaterialButton btnNewFolder;
        private ReaLTaiizor.Controls.NightButton btnRestart;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvNewFolder;
        private ReaLTaiizor.Controls.DreamButton btnAdd;
        private ReaLTaiizor.Controls.DungeonTextBox txtNewFolder;
        private ReaLTaiizor.Controls.MaterialButton btnFolder;
        private ReaLTaiizor.Controls.DungeonTextBox txtFolder;
        private System.Windows.Forms.Panel panel1;
    }
}