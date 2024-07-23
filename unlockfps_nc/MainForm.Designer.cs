namespace unlockfps_nc
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            OptionsMenuStrip = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            SettingsMenuItem = new ToolStripMenuItem();
            SetupMenuItem = new ToolStripMenuItem();
            AboutMenuItem = new ToolStripMenuItem();
            LabelFPS = new Label();
            InputFPS = new NumericUpDown();
            SliderFPS = new TrackBar();
            CBAutoStart = new CheckBox();
            BtnStartGame = new Button();
            ToolTipMain = new ToolTip(components);
            NotifyIconMain = new NotifyIcon(components);
            ContextNotify = new ContextMenuStrip(components);
            ExitMenuItem = new ToolStripMenuItem();
            OptionsMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputFPS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SliderFPS).BeginInit();
            ContextNotify.SuspendLayout();
            SuspendLayout();
            // 
            // OptionsMenuStrip
            // 
            OptionsMenuStrip.ImageScalingSize = new Size(24, 24);
            OptionsMenuStrip.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            OptionsMenuStrip.Location = new Point(0, 0);
            OptionsMenuStrip.Name = "OptionsMenuStrip";
            OptionsMenuStrip.Padding = new Padding(9, 3, 0, 3);
            OptionsMenuStrip.Size = new Size(446, 34);
            OptionsMenuStrip.TabIndex = 0;
            OptionsMenuStrip.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SettingsMenuItem, SetupMenuItem, AboutMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(62, 28);
            optionsToolStripMenuItem.Text = "选项";
            // 
            // SettingsMenuItem
            // 
            SettingsMenuItem.Name = "SettingsMenuItem";
            SettingsMenuItem.Size = new Size(270, 34);
            SettingsMenuItem.Text = "设置";
            SettingsMenuItem.Click += SettingsMenuItem_Click;
            // 
            // SetupMenuItem
            // 
            SetupMenuItem.Name = "SetupMenuItem";
            SetupMenuItem.Size = new Size(270, 34);
            SetupMenuItem.Text = "游戏路径";
            SetupMenuItem.Click += SetupMenuItem_Click;
            // 
            // AboutMenuItem
            // 
            AboutMenuItem.Name = "AboutMenuItem";
            AboutMenuItem.Size = new Size(270, 34);
            AboutMenuItem.Text = "关于";
            AboutMenuItem.Click += AboutMenuItem_Click;
            // 
            // LabelFPS
            // 
            LabelFPS.AutoSize = true;
            LabelFPS.Location = new Point(19, 53);
            LabelFPS.Margin = new Padding(5, 0, 5, 0);
            LabelFPS.Name = "LabelFPS";
            LabelFPS.Size = new Size(64, 24);
            LabelFPS.TabIndex = 1;
            LabelFPS.Text = "帧率：";
            // 
            // InputFPS
            // 
            InputFPS.Location = new Point(74, 50);
            InputFPS.Margin = new Padding(5, 5, 5, 5);
            InputFPS.Maximum = new decimal(new int[] { 420, 0, 0, 0 });
            InputFPS.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            InputFPS.Name = "InputFPS";
            InputFPS.Size = new Size(354, 30);
            InputFPS.TabIndex = 2;
            InputFPS.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // SliderFPS
            // 
            SliderFPS.Location = new Point(19, 96);
            SliderFPS.Margin = new Padding(5, 5, 5, 5);
            SliderFPS.Maximum = 420;
            SliderFPS.Minimum = 1;
            SliderFPS.Name = "SliderFPS";
            SliderFPS.Size = new Size(409, 69);
            SliderFPS.TabIndex = 3;
            SliderFPS.TickStyle = TickStyle.None;
            SliderFPS.Value = 120;
            // 
            // CBAutoStart
            // 
            CBAutoStart.AutoSize = true;
            CBAutoStart.Location = new Point(19, 144);
            CBAutoStart.Margin = new Padding(5, 5, 5, 5);
            CBAutoStart.Name = "CBAutoStart";
            CBAutoStart.Size = new Size(144, 28);
            CBAutoStart.TabIndex = 4;
            CBAutoStart.Text = "自动启动游戏";
            ToolTipMain.SetToolTip(CBAutoStart, "这将在下次启动时生效");
            CBAutoStart.UseVisualStyleBackColor = true;
            // 
            // BtnStartGame
            // 
            BtnStartGame.Location = new Point(310, 139);
            BtnStartGame.Margin = new Padding(5, 5, 5, 5);
            BtnStartGame.Name = "BtnStartGame";
            BtnStartGame.Size = new Size(118, 41);
            BtnStartGame.TabIndex = 5;
            BtnStartGame.Text = "原神，启动!";
            BtnStartGame.UseVisualStyleBackColor = true;
            BtnStartGame.Click += BtnStartGame_Click;
            // 
            // NotifyIconMain
            // 
            NotifyIconMain.BalloonTipIcon = ToolTipIcon.Info;
            NotifyIconMain.BalloonTipText = "最小化至托盘";
            NotifyIconMain.BalloonTipTitle = "原神FPS解锁器";
            NotifyIconMain.ContextMenuStrip = ContextNotify;
            NotifyIconMain.Icon = (Icon)resources.GetObject("NotifyIconMain.Icon");
            NotifyIconMain.Text = "原神FPS解锁器";
            NotifyIconMain.Visible = true;
            NotifyIconMain.DoubleClick += NotifyIconMain_DoubleClick;
            // 
            // ContextNotify
            // 
            ContextNotify.ImageScalingSize = new Size(24, 24);
            ContextNotify.Items.AddRange(new ToolStripItem[] { ExitMenuItem });
            ContextNotify.Name = "ContextNotify";
            ContextNotify.Size = new Size(112, 34);
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(111, 30);
            ExitMenuItem.Text = "退出";
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 194);
            Controls.Add(BtnStartGame);
            Controls.Add(CBAutoStart);
            Controls.Add(SliderFPS);
            Controls.Add(InputFPS);
            Controls.Add(LabelFPS);
            Controls.Add(OptionsMenuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = OptionsMenuStrip;
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "原神FPS解锁器";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Resize += MainForm_Resize;
            OptionsMenuStrip.ResumeLayout(false);
            OptionsMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InputFPS).EndInit();
            ((System.ComponentModel.ISupportInitialize)SliderFPS).EndInit();
            ContextNotify.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip OptionsMenuStrip;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem SettingsMenuItem;
        private ToolStripMenuItem SetupMenuItem;
        private ToolStripMenuItem AboutMenuItem;
        private Label LabelFPS;
        private NumericUpDown InputFPS;
        private TrackBar SliderFPS;
        private CheckBox CBAutoStart;
        private Button BtnStartGame;
        private ToolTip ToolTipMain;
        private NotifyIcon NotifyIconMain;
        private ContextMenuStrip ContextNotify;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem ExitMenuItem;
    }
}
