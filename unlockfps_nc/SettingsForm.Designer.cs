namespace unlockfps_nc
{
    partial class SettingsForm
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
            components = new System.ComponentModel.Container();
            LabelAutoSave = new Label();
            TabCtrlSettings = new TabControl();
            TabGeneral = new TabPage();
            ComboPriority = new ComboBox();
            LabelPriority = new Label();
            CBPowerSave = new CheckBox();
            CBAutoClose = new CheckBox();
            CBStartMinimized = new CheckBox();
            TabLaunchOptions = new TabPage();
            CBUseHDR = new CheckBox();
            CBUseMobileUI = new CheckBox();
            InputMonitorNum = new NumericUpDown();
            LabelMonitor = new Label();
            ComboFullscreenMode = new ComboBox();
            LabelWindowMode = new Label();
            InputResY = new NumericUpDown();
            LabelX = new Label();
            InputResX = new NumericUpDown();
            LabelCustomRes = new Label();
            CBCustomRes = new CheckBox();
            CBFullscreen = new CheckBox();
            CBPopup = new CheckBox();
            TabDlls = new TabPage();
            CBSuspendLoad = new CheckBox();
            BtnRemoveDll = new Button();
            BtnAddDll = new Button();
            ListBoxDlls = new ListBox();
            label1 = new Label();
            ToolTipSettings = new ToolTip(components);
            DllAddDialog = new OpenFileDialog();
            TabCtrlSettings.SuspendLayout();
            TabGeneral.SuspendLayout();
            TabLaunchOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputMonitorNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputResY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputResX).BeginInit();
            TabDlls.SuspendLayout();
            SuspendLayout();
            // 
            // LabelAutoSave
            // 
            LabelAutoSave.AutoSize = true;
            LabelAutoSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelAutoSave.Location = new Point(19, 14);
            LabelAutoSave.Margin = new Padding(5, 0, 5, 0);
            LabelAutoSave.Name = "LabelAutoSave";
            LabelAutoSave.Size = new Size(212, 25);
            LabelAutoSave.TabIndex = 0;
            LabelAutoSave.Text = "所有设置都会自动保存";
            // 
            // TabCtrlSettings
            // 
            TabCtrlSettings.Controls.Add(TabGeneral);
            TabCtrlSettings.Controls.Add(TabLaunchOptions);
            TabCtrlSettings.Controls.Add(TabDlls);
            TabCtrlSettings.Location = new Point(19, 43);
            TabCtrlSettings.Margin = new Padding(5);
            TabCtrlSettings.Name = "TabCtrlSettings";
            TabCtrlSettings.SelectedIndex = 0;
            TabCtrlSettings.Size = new Size(409, 355);
            TabCtrlSettings.TabIndex = 1;
            // 
            // TabGeneral
            // 
            TabGeneral.Controls.Add(ComboPriority);
            TabGeneral.Controls.Add(LabelPriority);
            TabGeneral.Controls.Add(CBPowerSave);
            TabGeneral.Controls.Add(CBAutoClose);
            TabGeneral.Controls.Add(CBStartMinimized);
            TabGeneral.Location = new Point(4, 33);
            TabGeneral.Margin = new Padding(5);
            TabGeneral.Name = "TabGeneral";
            TabGeneral.Padding = new Padding(5);
            TabGeneral.Size = new Size(401, 318);
            TabGeneral.TabIndex = 0;
            TabGeneral.Text = "常规";
            TabGeneral.UseVisualStyleBackColor = true;
            // 
            // ComboPriority
            // 
            ComboPriority.FormattingEnabled = true;
            ComboPriority.Items.AddRange(new object[] { "实时", "高", "高于正常", "正常", "低于正常", "低" });
            ComboPriority.Location = new Point(196, 131);
            ComboPriority.Margin = new Padding(5);
            ComboPriority.Name = "ComboPriority";
            ComboPriority.Size = new Size(188, 32);
            ComboPriority.TabIndex = 5;
            ComboPriority.Text = "正常";
            // 
            // LabelPriority
            // 
            LabelPriority.AutoSize = true;
            LabelPriority.Location = new Point(5, 136);
            LabelPriority.Margin = new Padding(5, 0, 5, 0);
            LabelPriority.Name = "LabelPriority";
            LabelPriority.Size = new Size(136, 24);
            LabelPriority.TabIndex = 4;
            LabelPriority.Text = "游戏进程优先级";
            // 
            // CBPowerSave
            // 
            CBPowerSave.AutoSize = true;
            CBPowerSave.Location = new Point(9, 90);
            CBPowerSave.Margin = new Padding(5);
            CBPowerSave.Name = "CBPowerSave";
            CBPowerSave.Size = new Size(108, 28);
            CBPowerSave.TabIndex = 3;
            CBPowerSave.Text = "省电模式";
            ToolTipSettings.SetToolTip(CBPowerSave, "在游戏失去焦点时（如切换窗口）降低游戏优先级并将帧率设为10FPS");
            CBPowerSave.UseVisualStyleBackColor = true;
            // 
            // CBAutoClose
            // 
            CBAutoClose.AutoSize = true;
            CBAutoClose.Location = new Point(9, 50);
            CBAutoClose.Margin = new Padding(5);
            CBAutoClose.Name = "CBAutoClose";
            CBAutoClose.Size = new Size(108, 28);
            CBAutoClose.TabIndex = 2;
            CBAutoClose.Text = "自动关闭";
            ToolTipSettings.SetToolTip(CBAutoClose, "游戏关闭时自动关闭解锁器");
            CBAutoClose.UseVisualStyleBackColor = true;
            // 
            // CBStartMinimized
            // 
            CBStartMinimized.AutoSize = true;
            CBStartMinimized.Location = new Point(9, 10);
            CBStartMinimized.Margin = new Padding(5);
            CBStartMinimized.Name = "CBStartMinimized";
            CBStartMinimized.Size = new Size(126, 28);
            CBStartMinimized.TabIndex = 1;
            CBStartMinimized.Text = "启动最小化";
            ToolTipSettings.SetToolTip(CBStartMinimized, "解锁器启动时最小化");
            CBStartMinimized.UseVisualStyleBackColor = true;
            // 
            // TabLaunchOptions
            // 
            TabLaunchOptions.Controls.Add(CBUseHDR);
            TabLaunchOptions.Controls.Add(CBUseMobileUI);
            TabLaunchOptions.Controls.Add(InputMonitorNum);
            TabLaunchOptions.Controls.Add(LabelMonitor);
            TabLaunchOptions.Controls.Add(ComboFullscreenMode);
            TabLaunchOptions.Controls.Add(LabelWindowMode);
            TabLaunchOptions.Controls.Add(InputResY);
            TabLaunchOptions.Controls.Add(LabelX);
            TabLaunchOptions.Controls.Add(InputResX);
            TabLaunchOptions.Controls.Add(LabelCustomRes);
            TabLaunchOptions.Controls.Add(CBCustomRes);
            TabLaunchOptions.Controls.Add(CBFullscreen);
            TabLaunchOptions.Controls.Add(CBPopup);
            TabLaunchOptions.Location = new Point(4, 33);
            TabLaunchOptions.Margin = new Padding(5);
            TabLaunchOptions.Name = "TabLaunchOptions";
            TabLaunchOptions.Padding = new Padding(5);
            TabLaunchOptions.Size = new Size(401, 318);
            TabLaunchOptions.TabIndex = 1;
            TabLaunchOptions.Text = "启动选项";
            TabLaunchOptions.UseVisualStyleBackColor = true;
            // 
            // CBUseHDR
            // 
            CBUseHDR.AutoSize = true;
            CBUseHDR.Location = new Point(174, 10);
            CBUseHDR.Margin = new Padding(5);
            CBUseHDR.Name = "CBUseHDR";
            CBUseHDR.Size = new Size(112, 28);
            CBUseHDR.TabIndex = 4;
            CBUseHDR.Text = "使用HDR";
            ToolTipSettings.SetToolTip(CBUseHDR, "启用原生Windows HDR。\r\n要求显示器支持HDR，否则可能出现过曝。");
            CBUseHDR.UseVisualStyleBackColor = true;
            // 
            // CBUseMobileUI
            // 
            CBUseMobileUI.AutoSize = true;
            CBUseMobileUI.Location = new Point(9, 130);
            CBUseMobileUI.Margin = new Padding(5);
            CBUseMobileUI.Name = "CBUseMobileUI";
            CBUseMobileUI.Size = new Size(144, 28);
            CBUseMobileUI.TabIndex = 3;
            CBUseMobileUI.Text = "使用移动端UI";
            CBUseMobileUI.UseVisualStyleBackColor = true;
            // 
            // InputMonitorNum
            // 
            InputMonitorNum.Location = new Point(174, 269);
            InputMonitorNum.Margin = new Padding(5);
            InputMonitorNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            InputMonitorNum.Name = "InputMonitorNum";
            InputMonitorNum.Size = new Size(212, 30);
            InputMonitorNum.TabIndex = 8;
            InputMonitorNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // LabelMonitor
            // 
            LabelMonitor.AutoSize = true;
            LabelMonitor.Location = new Point(9, 272);
            LabelMonitor.Margin = new Padding(5, 0, 5, 0);
            LabelMonitor.Name = "LabelMonitor";
            LabelMonitor.Size = new Size(82, 24);
            LabelMonitor.TabIndex = 9;
            LabelMonitor.Text = "显示器：";
            // 
            // ComboFullscreenMode
            // 
            ComboFullscreenMode.FormattingEnabled = true;
            ComboFullscreenMode.Items.AddRange(new object[] { "无边框", "独占" });
            ComboFullscreenMode.Location = new Point(174, 222);
            ComboFullscreenMode.Margin = new Padding(5);
            ComboFullscreenMode.Name = "ComboFullscreenMode";
            ComboFullscreenMode.Size = new Size(210, 32);
            ComboFullscreenMode.TabIndex = 7;
            ComboFullscreenMode.Text = "无边框";
            // 
            // LabelWindowMode
            // 
            LabelWindowMode.AutoSize = true;
            LabelWindowMode.Location = new Point(9, 227);
            LabelWindowMode.Margin = new Padding(5, 0, 5, 0);
            LabelWindowMode.Name = "LabelWindowMode";
            LabelWindowMode.Size = new Size(100, 24);
            LabelWindowMode.TabIndex = 7;
            LabelWindowMode.Text = "全屏模式：";
            // 
            // InputResY
            // 
            InputResY.Location = new Point(300, 176);
            InputResY.Margin = new Padding(5);
            InputResY.Maximum = new decimal(new int[] { 4320, 0, 0, 0 });
            InputResY.Minimum = new decimal(new int[] { 200, 0, 0, 0 });
            InputResY.Name = "InputResY";
            InputResY.Size = new Size(86, 30);
            InputResY.TabIndex = 6;
            InputResY.Value = new decimal(new int[] { 1080, 0, 0, 0 });
            // 
            // LabelX
            // 
            LabelX.AutoSize = true;
            LabelX.Location = new Point(270, 179);
            LabelX.Margin = new Padding(5, 0, 5, 0);
            LabelX.Name = "LabelX";
            LabelX.Size = new Size(23, 24);
            LabelX.TabIndex = 5;
            LabelX.Text = "×";
            // 
            // InputResX
            // 
            InputResX.Location = new Point(174, 176);
            InputResX.Margin = new Padding(5);
            InputResX.Maximum = new decimal(new int[] { 7680, 0, 0, 0 });
            InputResX.Minimum = new decimal(new int[] { 200, 0, 0, 0 });
            InputResX.Name = "InputResX";
            InputResX.Size = new Size(86, 30);
            InputResX.TabIndex = 5;
            InputResX.Value = new decimal(new int[] { 1920, 0, 0, 0 });
            // 
            // LabelCustomRes
            // 
            LabelCustomRes.AutoSize = true;
            LabelCustomRes.Location = new Point(9, 179);
            LabelCustomRes.Margin = new Padding(5, 0, 5, 0);
            LabelCustomRes.Name = "LabelCustomRes";
            LabelCustomRes.Size = new Size(82, 24);
            LabelCustomRes.TabIndex = 3;
            LabelCustomRes.Text = "分辨率：";
            // 
            // CBCustomRes
            // 
            CBCustomRes.AutoSize = true;
            CBCustomRes.Location = new Point(9, 90);
            CBCustomRes.Margin = new Padding(5);
            CBCustomRes.Name = "CBCustomRes";
            CBCustomRes.Size = new Size(144, 28);
            CBCustomRes.TabIndex = 2;
            CBCustomRes.Text = "自定义分辨率";
            CBCustomRes.UseVisualStyleBackColor = true;
            CBCustomRes.CheckStateChanged += LaunchOptionsChanged;
            // 
            // CBFullscreen
            // 
            CBFullscreen.AutoSize = true;
            CBFullscreen.Location = new Point(9, 50);
            CBFullscreen.Margin = new Padding(5);
            CBFullscreen.Name = "CBFullscreen";
            CBFullscreen.Size = new Size(72, 28);
            CBFullscreen.TabIndex = 1;
            CBFullscreen.Text = "全屏";
            CBFullscreen.UseVisualStyleBackColor = true;
            CBFullscreen.CheckStateChanged += LaunchOptionsChanged;
            // 
            // CBPopup
            // 
            CBPopup.AutoSize = true;
            CBPopup.Location = new Point(9, 10);
            CBPopup.Margin = new Padding(5);
            CBPopup.Name = "CBPopup";
            CBPopup.Size = new Size(144, 28);
            CBPopup.TabIndex = 0;
            CBPopup.Text = "无边框窗口化";
            CBPopup.UseVisualStyleBackColor = true;
            CBPopup.CheckStateChanged += LaunchOptionsChanged;
            // 
            // TabDlls
            // 
            TabDlls.Controls.Add(CBSuspendLoad);
            TabDlls.Controls.Add(BtnRemoveDll);
            TabDlls.Controls.Add(BtnAddDll);
            TabDlls.Controls.Add(ListBoxDlls);
            TabDlls.Controls.Add(label1);
            TabDlls.Location = new Point(4, 33);
            TabDlls.Margin = new Padding(5);
            TabDlls.Name = "TabDlls";
            TabDlls.Padding = new Padding(5);
            TabDlls.Size = new Size(401, 318);
            TabDlls.TabIndex = 2;
            TabDlls.Text = "DLLs";
            TabDlls.UseVisualStyleBackColor = true;
            // 
            // CBSuspendLoad
            // 
            CBSuspendLoad.AutoSize = true;
            CBSuspendLoad.Location = new Point(217, 126);
            CBSuspendLoad.Margin = new Padding(5);
            CBSuspendLoad.Name = "CBSuspendLoad";
            CBSuspendLoad.Size = new Size(126, 28);
            CBSuspendLoad.TabIndex = 4;
            CBSuspendLoad.Text = "注入时暂停";
            ToolTipSettings.SetToolTip(CBSuspendLoad, "这可以保证所有dll都在游戏启动前完成注入\r\n它可能不总是有效\r\n如果游戏崩溃，取消选中此项");
            CBSuspendLoad.UseVisualStyleBackColor = true;
            // 
            // BtnRemoveDll
            // 
            BtnRemoveDll.Location = new Point(207, 80);
            BtnRemoveDll.Margin = new Padding(5);
            BtnRemoveDll.Name = "BtnRemoveDll";
            BtnRemoveDll.Size = new Size(179, 37);
            BtnRemoveDll.TabIndex = 3;
            BtnRemoveDll.Text = "移除";
            BtnRemoveDll.UseVisualStyleBackColor = true;
            BtnRemoveDll.Click += BtnRemoveDll_Click;
            // 
            // BtnAddDll
            // 
            BtnAddDll.Location = new Point(207, 34);
            BtnAddDll.Margin = new Padding(5);
            BtnAddDll.Name = "BtnAddDll";
            BtnAddDll.Size = new Size(179, 37);
            BtnAddDll.TabIndex = 2;
            BtnAddDll.Text = "添加";
            BtnAddDll.UseVisualStyleBackColor = true;
            BtnAddDll.Click += BtnAddDll_Click;
            // 
            // ListBoxDlls
            // 
            ListBoxDlls.FormattingEnabled = true;
            ListBoxDlls.ItemHeight = 24;
            ListBoxDlls.Location = new Point(9, 34);
            ListBoxDlls.Margin = new Padding(5);
            ListBoxDlls.Name = "ListBoxDlls";
            ListBoxDlls.Size = new Size(186, 268);
            ListBoxDlls.TabIndex = 1;
            ListBoxDlls.Format += ListBoxDlls_Format;
            ListBoxDlls.MouseMove += ListBoxDlls_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 5);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 24);
            label1.TabIndex = 0;
            label1.Text = "dll会按照列表的顺序注入";
            // 
            // ToolTipSettings
            // 
            ToolTipSettings.AutoPopDelay = 5000;
            ToolTipSettings.InitialDelay = 500;
            ToolTipSettings.ReshowDelay = 500;
            // 
            // DllAddDialog
            // 
            DllAddDialog.Filter = "DLL (*.dll)|*.dll|所有文件 (*.*)|*.*";
            DllAddDialog.Multiselect = true;
            DllAddDialog.RestoreDirectory = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 418);
            Controls.Add(TabCtrlSettings);
            Controls.Add(LabelAutoSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "设置";
            FormClosing += SettingsForm_FormClosing;
            Load += SettingsForm_Load;
            TabCtrlSettings.ResumeLayout(false);
            TabGeneral.ResumeLayout(false);
            TabGeneral.PerformLayout();
            TabLaunchOptions.ResumeLayout(false);
            TabLaunchOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InputMonitorNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputResY).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputResX).EndInit();
            TabDlls.ResumeLayout(false);
            TabDlls.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelAutoSave;
        private TabControl TabCtrlSettings;
        private TabPage TabGeneral;
        private TabPage TabLaunchOptions;
        private TabPage TabDlls;
        private ComboBox ComboPriority;
        private Label LabelPriority;
        private CheckBox CBPowerSave;
        private CheckBox CBAutoClose;
        private CheckBox CBStartMinimized;
        private NumericUpDown InputResY;
        private Label LabelX;
        private NumericUpDown InputResX;
        private Label LabelCustomRes;
        private CheckBox CBCustomRes;
        private CheckBox CBFullscreen;
        private NumericUpDown InputMonitorNum;
        private Label LabelMonitor;
        private ComboBox ComboFullscreenMode;
        private Label LabelWindowMode;
        private Label label1;
        private ListBox ListBoxDlls;
        private Button BtnRemoveDll;
        private Button BtnAddDll;
        private ToolTip ToolTipSettings;
        private CheckBox CBSuspendLoad;
        private CheckBox CBUseMobileUI;
        private OpenFileDialog DllAddDialog;
        private CheckBox CBUseHDR;
        private CheckBox CBPopup;
    }
}