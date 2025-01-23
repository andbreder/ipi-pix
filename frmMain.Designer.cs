namespace IPI_PIX
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            NIcon = new NotifyIcon(components);
            NIconContextMenuStrip = new ContextMenuStrip(components);
            MenuMonitor0 = new ToolStripMenuItem();
            MenuMonitor1 = new ToolStripMenuItem();
            MenuMonitor2 = new ToolStripMenuItem();
            MenuMonitor3 = new ToolStripMenuItem();
            MenuMonitor4 = new ToolStripMenuItem();
            MenuRefreshMonitor = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            MenuSwitchMode = new ToolStripMenuItem();
            MenuHideShow = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            MenuClose = new ToolStripMenuItem();
            TimerShow = new System.Windows.Forms.Timer(components);
            TimerHide = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            NIconContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 48);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(0, 533);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(5, 0, 5, 0);
            label1.Size = new Size(400, 30);
            label1.TabIndex = 1;
            label1.Text = "00020126360014BR.GOV.BCB.PIX0114605531200001485204000053039865802BR59112IPIB-TUPAN6007Barueri62070503***63045B05";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(0, 174, 239);
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Padding = new Padding(5, 0, 5, 0);
            label2.Size = new Size(400, 48);
            label2.TabIndex = 2;
            label2.Text = "DÍZIMOS E OFERTAS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(85, 447);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Padding = new Padding(5, 0, 5, 0);
            label3.Size = new Size(297, 46);
            label3.TabIndex = 3;
            label3.Text = "60.553.120/0001-48";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(85, 486);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Padding = new Padding(5, 0, 5, 0);
            label4.Size = new Size(281, 30);
            label4.TabIndex = 4;
            label4.Text = "2IPIB-TUPAN";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(26, 447);
            pictureBox2.Margin = new Padding(5, 0, 0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(5);
            pictureBox2.Size = new Size(67, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // NIcon
            // 
            NIcon.Text = "notifyIcon1";
            NIcon.Visible = true;
            NIcon.MouseDoubleClick += NIcon_MouseDoubleClick;
            // 
            // NIconContextMenuStrip
            // 
            NIconContextMenuStrip.AllowMerge = false;
            NIconContextMenuStrip.Items.AddRange(new ToolStripItem[] { MenuMonitor0, MenuMonitor1, MenuMonitor2, MenuMonitor3, MenuMonitor4, MenuRefreshMonitor, toolStripSeparator2, MenuSwitchMode, MenuHideShow, toolStripSeparator1, MenuClose });
            NIconContextMenuStrip.Name = "NIconContextMenuStrip";
            NIconContextMenuStrip.Size = new Size(181, 236);
            // 
            // MenuMonitor0
            // 
            MenuMonitor0.Name = "MenuMonitor0";
            MenuMonitor0.Size = new Size(180, 22);
            MenuMonitor0.Text = "Monitor 0";
            MenuMonitor0.ToolTipText = "Presents me on this screen";
            MenuMonitor0.Visible = false;
            MenuMonitor0.Click += MenuMonitor_Click;
            // 
            // MenuMonitor1
            // 
            MenuMonitor1.Name = "MenuMonitor1";
            MenuMonitor1.Size = new Size(180, 22);
            MenuMonitor1.Text = "Monitor 1";
            MenuMonitor1.ToolTipText = "Presents me on this screen";
            MenuMonitor1.Visible = false;
            MenuMonitor1.Click += MenuMonitor_Click;
            // 
            // MenuMonitor2
            // 
            MenuMonitor2.Name = "MenuMonitor2";
            MenuMonitor2.Size = new Size(180, 22);
            MenuMonitor2.Text = "Monitor 2";
            MenuMonitor2.ToolTipText = "Presents me on this screen";
            MenuMonitor2.Visible = false;
            MenuMonitor2.Click += MenuMonitor_Click;
            // 
            // MenuMonitor3
            // 
            MenuMonitor3.Name = "MenuMonitor3";
            MenuMonitor3.Size = new Size(180, 22);
            MenuMonitor3.Text = "Monitor 3";
            MenuMonitor3.ToolTipText = "Presents me on this screen";
            MenuMonitor3.Visible = false;
            MenuMonitor3.Click += MenuMonitor_Click;
            // 
            // MenuMonitor4
            // 
            MenuMonitor4.Name = "MenuMonitor4";
            MenuMonitor4.Size = new Size(180, 22);
            MenuMonitor4.Text = "Monitor 4";
            MenuMonitor4.ToolTipText = "Presents me on this screen";
            MenuMonitor4.Visible = false;
            MenuMonitor4.Click += MenuMonitor_Click;
            // 
            // MenuRefreshMonitor
            // 
            MenuRefreshMonitor.Image = Properties.Resources.refresh;
            MenuRefreshMonitor.Name = "MenuRefreshMonitor";
            MenuRefreshMonitor.Size = new Size(180, 22);
            MenuRefreshMonitor.Text = "Refresh";
            MenuRefreshMonitor.ToolTipText = "Updates the list of available screens";
            MenuRefreshMonitor.Click += MenuRefreshMonitor_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // MenuSwitchMode
            // 
            MenuSwitchMode.Image = Properties.Resources.sun;
            MenuSwitchMode.Name = "MenuSwitchMode";
            MenuSwitchMode.Size = new Size(180, 22);
            MenuSwitchMode.Text = "Switch Mode";
            MenuSwitchMode.ToolTipText = "Toggle Light/Dark modes";
            MenuSwitchMode.Click += MenuSwitchMode_Click;
            // 
            // MenuHideShow
            // 
            MenuHideShow.Image = Properties.Resources.arrow_to;
            MenuHideShow.Name = "MenuHideShow";
            MenuHideShow.Size = new Size(180, 22);
            MenuHideShow.Text = "Hide";
            MenuHideShow.ToolTipText = "Smoothly Toggle Show/Hide presentation";
            MenuHideShow.Click += MenuHideShow_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // MenuClose
            // 
            MenuClose.Image = Properties.Resources.exit;
            MenuClose.Name = "MenuClose";
            MenuClose.Size = new Size(180, 22);
            MenuClose.Text = "Close";
            MenuClose.ToolTipText = "Close the application";
            MenuClose.Click += MenuClose_Click;
            // 
            // TimerShow
            // 
            TimerShow.Interval = 10;
            TimerShow.Tick += TimerShow_Tick;
            // 
            // TimerHide
            // 
            TimerHide.Interval = 10;
            TimerHide.Tick += TimerHide_Tick;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 563);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmMain";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.Manual;
            Text = "IPI-PIX";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            NIconContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private NotifyIcon NIcon;
        private ContextMenuStrip NIconContextMenuStrip;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem MenuClose;
        private ToolStripMenuItem MenuHideShow;
        private ToolStripMenuItem MenuMonitor0;
        private ToolStripMenuItem MenuMonitor1;
        private ToolStripMenuItem MenuMonitor2;
        private ToolStripMenuItem MenuMonitor3;
        private ToolStripMenuItem MenuMonitor4;
        private ToolStripMenuItem MenuRefreshMonitor;
        private ToolStripMenuItem MenuSwitchMode;
        private System.Windows.Forms.Timer TimerShow;
        private System.Windows.Forms.Timer TimerHide;
    }
}