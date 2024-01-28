namespace HomeService_NhuMyStudio
{
    partial class HomeFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cyberButton2 = new ReaLTaiizor.Controls.CyberButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cyberButton3 = new ReaLTaiizor.Controls.CyberButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRename = new ReaLTaiizor.Controls.CyberButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnFilter = new ReaLTaiizor.Controls.CyberButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(69, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dịch vụ | Như My Studio";
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(1040, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 46);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(246, 645);
            this.sidebar.TabIndex = 2;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cyberButton1);
            this.panel2.Location = new System.Drawing.Point(3, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 52);
            this.panel2.TabIndex = 11;
            // 
            // cyberButton1
            // 
            this.cyberButton1.Alpha = 20;
            this.cyberButton1.BackColor = System.Drawing.Color.Transparent;
            this.cyberButton1.Background = true;
            this.cyberButton1.Background_WidthPen = 4F;
            this.cyberButton1.BackgroundPen = true;
            this.cyberButton1.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton1.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton1.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton1.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton1.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton1.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton1.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberButton1.Effect_1 = true;
            this.cyberButton1.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton1.Effect_1_Transparency = 25;
            this.cyberButton1.Effect_2 = true;
            this.cyberButton1.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.cyberButton1.Effect_2_Transparency = 20;
            this.cyberButton1.Font = new System.Drawing.Font("Arial", 11F);
            this.cyberButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberButton1.Lighting = false;
            this.cyberButton1.LinearGradient_Background = false;
            this.cyberButton1.LinearGradientPen = false;
            this.cyberButton1.Location = new System.Drawing.Point(-20, -3);
            this.cyberButton1.Name = "cyberButton1";
            this.cyberButton1.PenWidth = 15;
            this.cyberButton1.Rounding = true;
            this.cyberButton1.RoundingInt = 70;
            this.cyberButton1.Size = new System.Drawing.Size(281, 55);
            this.cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberButton1.TabIndex = 10;
            this.cyberButton1.Tag = "Cyber";
            this.cyberButton1.TextButton = "CyberButton";
            this.cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberButton1.Timer_Effect_1 = 5;
            this.cyberButton1.Timer_RGB = 300;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cyberButton2);
            this.panel3.Location = new System.Drawing.Point(3, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 52);
            this.panel3.TabIndex = 12;
            // 
            // cyberButton2
            // 
            this.cyberButton2.Alpha = 20;
            this.cyberButton2.BackColor = System.Drawing.Color.Transparent;
            this.cyberButton2.Background = true;
            this.cyberButton2.Background_WidthPen = 4F;
            this.cyberButton2.BackgroundPen = true;
            this.cyberButton2.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton2.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton2.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton2.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton2.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton2.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton2.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton2.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberButton2.Effect_1 = true;
            this.cyberButton2.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton2.Effect_1_Transparency = 25;
            this.cyberButton2.Effect_2 = true;
            this.cyberButton2.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.cyberButton2.Effect_2_Transparency = 20;
            this.cyberButton2.Font = new System.Drawing.Font("Arial", 11F);
            this.cyberButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberButton2.Lighting = false;
            this.cyberButton2.LinearGradient_Background = false;
            this.cyberButton2.LinearGradientPen = false;
            this.cyberButton2.Location = new System.Drawing.Point(-20, -3);
            this.cyberButton2.Name = "cyberButton2";
            this.cyberButton2.PenWidth = 15;
            this.cyberButton2.Rounding = true;
            this.cyberButton2.RoundingInt = 70;
            this.cyberButton2.Size = new System.Drawing.Size(281, 55);
            this.cyberButton2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberButton2.TabIndex = 10;
            this.cyberButton2.Tag = "Cyber";
            this.cyberButton2.TextButton = "CyberButton";
            this.cyberButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberButton2.Timer_Effect_1 = 5;
            this.cyberButton2.Timer_RGB = 300;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cyberButton3);
            this.panel4.Location = new System.Drawing.Point(3, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 52);
            this.panel4.TabIndex = 13;
            // 
            // cyberButton3
            // 
            this.cyberButton3.Alpha = 20;
            this.cyberButton3.BackColor = System.Drawing.Color.Transparent;
            this.cyberButton3.Background = true;
            this.cyberButton3.Background_WidthPen = 4F;
            this.cyberButton3.BackgroundPen = true;
            this.cyberButton3.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton3.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton3.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton3.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton3.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton3.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton3.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton3.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberButton3.Effect_1 = true;
            this.cyberButton3.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton3.Effect_1_Transparency = 25;
            this.cyberButton3.Effect_2 = true;
            this.cyberButton3.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.cyberButton3.Effect_2_Transparency = 20;
            this.cyberButton3.Font = new System.Drawing.Font("Arial", 11F);
            this.cyberButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberButton3.Lighting = false;
            this.cyberButton3.LinearGradient_Background = false;
            this.cyberButton3.LinearGradientPen = false;
            this.cyberButton3.Location = new System.Drawing.Point(-20, -3);
            this.cyberButton3.Name = "cyberButton3";
            this.cyberButton3.PenWidth = 15;
            this.cyberButton3.Rounding = true;
            this.cyberButton3.RoundingInt = 70;
            this.cyberButton3.Size = new System.Drawing.Size(281, 55);
            this.cyberButton3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberButton3.TabIndex = 10;
            this.cyberButton3.Tag = "Cyber";
            this.cyberButton3.TextButton = "CyberButton";
            this.cyberButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberButton3.Timer_Effect_1 = 5;
            this.cyberButton3.Timer_RGB = 300;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnRename);
            this.panel5.Location = new System.Drawing.Point(3, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(241, 52);
            this.panel5.TabIndex = 12;
            // 
            // btnRename
            // 
            this.btnRename.Alpha = 20;
            this.btnRename.BackColor = System.Drawing.Color.Transparent;
            this.btnRename.Background = true;
            this.btnRename.Background_WidthPen = 4F;
            this.btnRename.BackgroundPen = true;
            this.btnRename.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnRename.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnRename.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnRename.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnRename.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnRename.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnRename.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnRename.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnRename.Effect_1 = true;
            this.btnRename.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnRename.Effect_1_Transparency = 25;
            this.btnRename.Effect_2 = true;
            this.btnRename.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnRename.Effect_2_Transparency = 20;
            this.btnRename.Font = new System.Drawing.Font("Arial", 11F);
            this.btnRename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnRename.Lighting = false;
            this.btnRename.LinearGradient_Background = false;
            this.btnRename.LinearGradientPen = false;
            this.btnRename.Location = new System.Drawing.Point(-20, -3);
            this.btnRename.Name = "btnRename";
            this.btnRename.PenWidth = 15;
            this.btnRename.Rounding = true;
            this.btnRename.RoundingInt = 70;
            this.btnRename.Size = new System.Drawing.Size(281, 55);
            this.btnRename.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnRename.TabIndex = 10;
            this.btnRename.Tag = "Cyber";
            this.btnRename.TextButton = "Đổi tên file";
            this.btnRename.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnRename.Timer_Effect_1 = 5;
            this.btnRename.Timer_RGB = 300;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnFilter);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(241, 52);
            this.panel6.TabIndex = 14;
            // 
            // btnFilter
            // 
            this.btnFilter.Alpha = 20;
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.Background = true;
            this.btnFilter.Background_WidthPen = 4F;
            this.btnFilter.BackgroundPen = true;
            this.btnFilter.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnFilter.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnFilter.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnFilter.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnFilter.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnFilter.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btnFilter.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnFilter.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnFilter.Effect_1 = true;
            this.btnFilter.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btnFilter.Effect_1_Transparency = 25;
            this.btnFilter.Effect_2 = true;
            this.btnFilter.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btnFilter.Effect_2_Transparency = 20;
            this.btnFilter.Font = new System.Drawing.Font("Arial", 11F);
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnFilter.Lighting = false;
            this.btnFilter.LinearGradient_Background = false;
            this.btnFilter.LinearGradientPen = false;
            this.btnFilter.Location = new System.Drawing.Point(-20, -3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.PenWidth = 15;
            this.btnFilter.Rounding = true;
            this.btnFilter.RoundingInt = 70;
            this.btnFilter.Size = new System.Drawing.Size(281, 55);
            this.btnFilter.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Tag = "Cyber";
            this.btnFilter.TextButton = "Chọn lọc <3";
            this.btnFilter.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.btnFilter.Timer_Effect_1 = 5;
            this.btnFilter.Timer_RGB = 300;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeService_NhuMyStudio.Properties.Resources.AnyConv_com__367414274_803314774825615_8341341525306293701_n;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 40);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // HomeFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1179, 691);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel panel6;
        private ReaLTaiizor.Controls.CyberButton btnFilter;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.CyberButton cyberButton2;
        private System.Windows.Forms.Panel panel4;
        private ReaLTaiizor.Controls.CyberButton cyberButton3;
        private System.Windows.Forms.Panel panel5;
        private ReaLTaiizor.Controls.CyberButton btnRename;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

