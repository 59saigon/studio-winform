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
            this.metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
            this.dgvFolder = new System.Windows.Forms.DataGridView();
            this.btnSave = new ReaLTaiizor.Controls.NightButton();
            this.btnNewFolder = new ReaLTaiizor.Controls.MaterialButton();
            this.btnRestart = new ReaLTaiizor.Controls.NightButton();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.txtNewFolder = new ReaLTaiizor.Controls.SkyTextBox();
            this.dgvNewFolder = new System.Windows.Forms.DataGridView();
            this.txtSearch = new ReaLTaiizor.Controls.SkyTextBox();
            this.parrotGradientPanel2 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.btnFolder = new ReaLTaiizor.Controls.MaterialButton();
            this.txtFolder = new ReaLTaiizor.Controls.SkyTextBox();
            this.metroLabel2 = new ReaLTaiizor.Controls.MetroLabel();
            this.btnSelectAll = new ReaLTaiizor.Controls.MaterialButton();
            this.btnRemoveAll = new ReaLTaiizor.Controls.MaterialButton();
            this.metroLabel3 = new ReaLTaiizor.Controls.MetroLabel();
            this.btnReviewFolder = new ReaLTaiizor.Controls.MaterialButton();
            this.btnReviewNewFolder = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolder)).BeginInit();
            this.parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewFolder)).BeginInit();
            this.parrotGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Cascadia Mono", 18.27692F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.IsDerivedStyle = true;
            this.metroLabel1.Location = new System.Drawing.Point(125, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(342, 52);
            this.metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Folder gốc";
            this.metroLabel1.ThemeAuthor = "Taiizor";
            this.metroLabel1.ThemeName = "MetroLight";
            // 
            // dgvFolder
            // 
            this.dgvFolder.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvFolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFolder.Location = new System.Drawing.Point(25, 139);
            this.dgvFolder.Name = "dgvFolder";
            this.dgvFolder.RowHeadersWidth = 56;
            this.dgvFolder.RowTemplate.Height = 24;
            this.dgvFolder.Size = new System.Drawing.Size(442, 266);
            this.dgvFolder.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.HoverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSave.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.btnSave.Location = new System.Drawing.Point(683, 6);
            this.btnSave.MinimumSize = new System.Drawing.Size(144, 47);
            this.btnSave.Name = "btnSave";
            this.btnSave.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.btnSave.PressedBackColor = System.Drawing.Color.DarkGreen;
            this.btnSave.PressedForeColor = System.Drawing.Color.White;
            this.btnSave.Radius = 20;
            this.btnSave.Size = new System.Drawing.Size(213, 47);
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
            this.btnNewFolder.Location = new System.Drawing.Point(491, 6);
            this.btnNewFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNewFolder.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnNewFolder.Name = "btnNewFolder";
            this.btnNewFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNewFolder.Size = new System.Drawing.Size(135, 36);
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
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRestart.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRestart.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestart.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.btnRestart.Location = new System.Drawing.Point(25, 6);
            this.btnRestart.MinimumSize = new System.Drawing.Size(144, 47);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRestart.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.btnRestart.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.btnRestart.PressedForeColor = System.Drawing.Color.White;
            this.btnRestart.Radius = 20;
            this.btnRestart.Size = new System.Drawing.Size(213, 47);
            this.btnRestart.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Khởi động lại";
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.LightBlue;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.LightPink;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Controls.Add(this.btnSave);
            this.parrotGradientPanel1.Controls.Add(this.btnRestart);
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 455);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(928, 86);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel1.TabIndex = 11;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
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
            this.txtNewFolder.Location = new System.Drawing.Point(491, 43);
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
            this.dgvNewFolder.Location = new System.Drawing.Point(491, 139);
            this.dgvNewFolder.Name = "dgvNewFolder";
            this.dgvNewFolder.RowHeadersWidth = 56;
            this.dgvNewFolder.RowTemplate.Height = 24;
            this.dgvNewFolder.Size = new System.Drawing.Size(405, 266);
            this.dgvNewFolder.TabIndex = 14;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Pink;
            this.txtSearch.BaseColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtSearch.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txtSearch.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtSearch.BorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.txtSearch.Location = new System.Drawing.Point(25, 117);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MultiLine = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(442, 25);
            this.txtSearch.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.UnknownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // parrotGradientPanel2
            // 
            this.parrotGradientPanel2.BottomLeft = System.Drawing.Color.LightBlue;
            this.parrotGradientPanel2.BottomRight = System.Drawing.Color.LightPink;
            this.parrotGradientPanel2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel2.Controls.Add(this.btnReviewNewFolder);
            this.parrotGradientPanel2.Controls.Add(this.btnReviewFolder);
            this.parrotGradientPanel2.Controls.Add(this.btnFolder);
            this.parrotGradientPanel2.Controls.Add(this.btnNewFolder);
            this.parrotGradientPanel2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel2.Location = new System.Drawing.Point(0, -4);
            this.parrotGradientPanel2.Name = "parrotGradientPanel2";
            this.parrotGradientPanel2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel2.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel2.Size = new System.Drawing.Size(928, 41);
            this.parrotGradientPanel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel2.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel2.TabIndex = 12;
            this.parrotGradientPanel2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel2.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.parrotGradientPanel2.TopRight = System.Drawing.Color.Fuchsia;
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
            this.btnFolder.Location = new System.Drawing.Point(25, 6);
            this.btnFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFolder.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFolder.Size = new System.Drawing.Size(135, 36);
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
            this.txtFolder.Location = new System.Drawing.Point(25, 43);
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
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.IsDerivedStyle = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 413);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(327, 39);
            this.metroLabel2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Lưu ý: Dùng phím cách để chuyển ảnh ( một hoặc nhiều file ảnh )";
            this.metroLabel2.ThemeAuthor = "Taiizor";
            this.metroLabel2.ThemeName = "MetroLight";
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
            this.btnSelectAll.Location = new System.Drawing.Point(359, 410);
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
            this.btnRemoveAll.Location = new System.Drawing.Point(789, 410);
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
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Cascadia Mono", 18.27692F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.IsDerivedStyle = true;
            this.metroLabel3.Location = new System.Drawing.Point(554, 71);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(342, 52);
            this.metroLabel3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Folder mới";
            this.metroLabel3.ThemeAuthor = "Taiizor";
            this.metroLabel3.ThemeName = "MetroLight";
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
            this.btnReviewFolder.Location = new System.Drawing.Point(168, 6);
            this.btnReviewFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReviewFolder.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnReviewFolder.Name = "btnReviewFolder";
            this.btnReviewFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReviewFolder.Size = new System.Drawing.Size(135, 36);
            this.btnReviewFolder.TabIndex = 9;
            this.btnReviewFolder.Text = "Xem thư mục";
            this.btnReviewFolder.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReviewFolder.UseAccentColor = false;
            this.btnReviewFolder.UseVisualStyleBackColor = true;
            this.btnReviewFolder.Click += new System.EventHandler(this.btnReviewFolder_Click);
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
            this.btnReviewNewFolder.Location = new System.Drawing.Point(634, 6);
            this.btnReviewNewFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReviewNewFolder.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnReviewNewFolder.Name = "btnReviewNewFolder";
            this.btnReviewNewFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReviewNewFolder.Size = new System.Drawing.Size(135, 36);
            this.btnReviewNewFolder.TabIndex = 10;
            this.btnReviewNewFolder.Text = "Xem thư mục";
            this.btnReviewNewFolder.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReviewNewFolder.UseAccentColor = false;
            this.btnReviewNewFolder.UseVisualStyleBackColor = true;
            this.btnReviewNewFolder.Click += new System.EventHandler(this.btnReviewNewFolder_Click);
            // 
            // frmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(925, 527);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtNewFolder);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.parrotGradientPanel2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvNewFolder);
            this.Controls.Add(this.parrotGradientPanel1);
            this.Controls.Add(this.dgvFolder);
            this.Controls.Add(this.metroLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFilter";
            this.Text = "frmFilter";
            this.Load += new System.EventHandler(this.frmFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolder)).EndInit();
            this.parrotGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewFolder)).EndInit();
            this.parrotGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgvFolder;
        private ReaLTaiizor.Controls.NightButton btnSave;
        private ReaLTaiizor.Controls.MaterialButton btnNewFolder;
        private ReaLTaiizor.Controls.NightButton btnRestart;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private System.Windows.Forms.DataGridView dgvNewFolder;
        private ReaLTaiizor.Controls.SkyTextBox txtSearch;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel2;
        private ReaLTaiizor.Controls.SkyTextBox txtNewFolder;
        private ReaLTaiizor.Controls.MaterialButton btnFolder;
        private ReaLTaiizor.Controls.SkyTextBox txtFolder;
        private ReaLTaiizor.Controls.MetroLabel metroLabel2;
        private ReaLTaiizor.Controls.MaterialButton btnSelectAll;
        private ReaLTaiizor.Controls.MaterialButton btnRemoveAll;
        private ReaLTaiizor.Controls.MetroLabel metroLabel3;
        private ReaLTaiizor.Controls.MaterialButton btnReviewFolder;
        private ReaLTaiizor.Controls.MaterialButton btnReviewNewFolder;
    }
}