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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeFrm));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnFilter = new ReaLTaiizor.Controls.CyberButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRename = new ReaLTaiizor.Controls.CyberButton();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(176, 733);
            this.sidebar.TabIndex = 2;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
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
            this.btnFilter.Location = new System.Drawing.Point(-3, -3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.PenWidth = 15;
            this.btnFilter.Rounding = true;
            this.btnFilter.RoundingInt = 70;
            this.btnFilter.Size = new System.Drawing.Size(176, 55);
            this.btnFilter.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Tag = "Cyber";
            this.btnFilter.TextButton = "Chọn lọc ";
            this.btnFilter.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.btnFilter.Timer_Effect_1 = 5;
            this.btnFilter.Timer_RGB = 300;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
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
            this.btnRename.Location = new System.Drawing.Point(-3, -3);
            this.btnRename.Name = "btnRename";
            this.btnRename.PenWidth = 15;
            this.btnRename.Rounding = true;
            this.btnRename.RoundingInt = 70;
            this.btnRename.Size = new System.Drawing.Size(176, 55);
            this.btnRename.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnRename.TabIndex = 10;
            this.btnRename.Tag = "Cyber";
            this.btnRename.TextButton = "Đổi tên file";
            this.btnRename.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnRename.Timer_Effect_1 = 5;
            this.btnRename.Timer_RGB = 300;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // HomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1179, 733);
            this.Controls.Add(this.sidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 11.07692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NM Studio Service";
            this.Load += new System.EventHandler(this.HomeFrm_Load);
            this.sidebar.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel panel6;
        private ReaLTaiizor.Controls.CyberButton btnFilter;
        private System.Windows.Forms.Panel panel5;
        private ReaLTaiizor.Controls.CyberButton btnRename;
    }
}

