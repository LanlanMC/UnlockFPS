namespace unlockfps_nc
{
    partial class SetupForm
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
            LabelResult = new Label();
            LabelSelect = new Label();
            ComboResult = new ComboBox();
            LabelHint = new Label();
            BtnBrowse = new Button();
            BtnConfirm = new Button();
            LabelCurrentPath = new Label();
            BrowseDialog = new OpenFileDialog();
            SuspendLayout();
            // 
            // LabelResult
            // 
            LabelResult.AutoSize = true;
            LabelResult.Location = new Point(19, 77);
            LabelResult.Margin = new Padding(5, 0, 5, 0);
            LabelResult.Name = "LabelResult";
            LabelResult.Size = new Size(109, 24);
            LabelResult.TabIndex = 0;
            LabelResult.Text = "LabelResult";
            // 
            // LabelSelect
            // 
            LabelSelect.AutoSize = true;
            LabelSelect.Location = new Point(19, 101);
            LabelSelect.Margin = new Padding(5, 0, 5, 0);
            LabelSelect.Name = "LabelSelect";
            LabelSelect.Size = new Size(64, 24);
            LabelSelect.TabIndex = 1;
            LabelSelect.Text = "选择：";
            // 
            // ComboResult
            // 
            ComboResult.FormattingEnabled = true;
            ComboResult.Location = new Point(19, 130);
            ComboResult.Margin = new Padding(5, 5, 5, 5);
            ComboResult.Name = "ComboResult";
            ComboResult.Size = new Size(681, 32);
            ComboResult.TabIndex = 2;
            // 
            // LabelHint
            // 
            LabelHint.AutoSize = true;
            LabelHint.Location = new Point(19, 187);
            LabelHint.Margin = new Padding(5, 0, 5, 0);
            LabelHint.Name = "LabelHint";
            LabelHint.Size = new Size(426, 72);
            LabelHint.TabIndex = 3;
            LabelHint.Text = "如果游戏未在上方显示，你可以：\r\n1. 现在启动游戏，然后解锁器会尝试找到它的路径；\r\n2. 使用下面的浏览按钮。";
            // 
            // BtnBrowse
            // 
            BtnBrowse.Location = new Point(19, 282);
            BtnBrowse.Margin = new Padding(5, 5, 5, 5);
            BtnBrowse.Name = "BtnBrowse";
            BtnBrowse.Size = new Size(118, 37);
            BtnBrowse.TabIndex = 4;
            BtnBrowse.Text = "浏览";
            BtnBrowse.UseVisualStyleBackColor = true;
            BtnBrowse.Click += BtnBrowse_Click;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Location = new Point(585, 282);
            BtnConfirm.Margin = new Padding(5, 5, 5, 5);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(118, 37);
            BtnConfirm.TabIndex = 5;
            BtnConfirm.Text = "确定";
            BtnConfirm.UseVisualStyleBackColor = true;
            BtnConfirm.Click += BtnConfirm_Click;
            // 
            // LabelCurrentPath
            // 
            LabelCurrentPath.Location = new Point(19, 14);
            LabelCurrentPath.Margin = new Padding(5, 0, 5, 0);
            LabelCurrentPath.Name = "LabelCurrentPath";
            LabelCurrentPath.Size = new Size(684, 62);
            LabelCurrentPath.TabIndex = 6;
            LabelCurrentPath.Text = "LabelCurrentPath";
            // 
            // BrowseDialog
            // 
            BrowseDialog.Filter = "Executable Files (*.exe)|GenshinImpact.exe;YuanShen.exe";
            BrowseDialog.RestoreDirectory = true;
            BrowseDialog.Title = "Select GenshinImpact.exe or YuanShen.exe";
            // 
            // SetupForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 338);
            Controls.Add(LabelCurrentPath);
            Controls.Add(BtnConfirm);
            Controls.Add(BtnBrowse);
            Controls.Add(LabelHint);
            Controls.Add(ComboResult);
            Controls.Add(LabelSelect);
            Controls.Add(LabelResult);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SetupForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "游戏路径";
            FormClosing += SetupForm_FormClosing;
            Load += SetupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelResult;
        private Label LabelSelect;
        private ComboBox ComboResult;
        private Label LabelHint;
        private Button BtnBrowse;
        private Button BtnConfirm;
        private Label LabelCurrentPath;
        private OpenFileDialog BrowseDialog;
    }
}