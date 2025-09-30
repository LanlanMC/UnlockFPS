namespace unlockfps
{
    partial class AboutForm
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
            LabelTitle = new Label();
            LabelDescription = new Label();
            LinkLabelSource = new LinkLabel();
            LinkLabelIssues = new LinkLabel();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelTitle.Location = new Point(19, 14);
            LabelTitle.Margin = new Padding(5, 0, 5, 0);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(503, 58);
            LabelTitle.TabIndex = 0;
            LabelTitle.Text = "原神 FPS 解锁器\r\nv";
            LabelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelDescription
            // 
            LabelDescription.Location = new Point(19, 72);
            LabelDescription.Margin = new Padding(5, 0, 5, 0);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new Size(503, 32);
            LabelDescription.TabIndex = 1;
            LabelDescription.Text = "此程序免费且开源";
            LabelDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LinkLabelSource
            // 
            LinkLabelSource.LinkArea = new LinkArea(3, 37);
            LinkLabelSource.Location = new Point(19, 104);
            LinkLabelSource.Margin = new Padding(5, 0, 5, 0);
            LinkLabelSource.Name = "LinkLabelSource";
            LinkLabelSource.Size = new Size(503, 32);
            LinkLabelSource.TabIndex = 2;
            LinkLabelSource.TabStop = true;
            LinkLabelSource.Text = "源码：https://github.com/LanlanMC/UnlockFPS";
            LinkLabelSource.TextAlign = ContentAlignment.MiddleCenter;
            LinkLabelSource.UseCompatibleTextRendering = true;
            LinkLabelSource.LinkClicked += LinkLabelSource_LinkClicked;
            // 
            // LinkLabelIssues
            // 
            LinkLabelIssues.LinkArea = new LinkArea(17, 44);
            LinkLabelIssues.Location = new Point(19, 136);
            LinkLabelIssues.Margin = new Padding(5, 0, 5, 0);
            LinkLabelIssues.Name = "LinkLabelIssues";
            LinkLabelIssues.Size = new Size(503, 107);
            LinkLabelIssues.TabIndex = 3;
            LinkLabelIssues.TabStop = true;
            LinkLabelIssues.Text = "如果你遇到任何问题或有建议，请在\r\nhttps://github.com/LanlanMC/UnlockFPS/issues\r\n提交 Issue\r\n\r\n";
            LinkLabelIssues.TextAlign = ContentAlignment.MiddleCenter;
            LinkLabelIssues.UseCompatibleTextRendering = true;
            LinkLabelIssues.LinkClicked += LinkLabelIssues_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.LinkArea = new LinkArea(4, 46);
            linkLabel1.Location = new Point(0, 218);
            linkLabel1.Margin = new Padding(5, 0, 5, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(541, 32);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "复刻自 https://github.com/34736384/genshin-fps-unlock";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.UseCompatibleTextRendering = true;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 274);
            Controls.Add(linkLabel1);
            Controls.Add(LinkLabelIssues);
            Controls.Add(LinkLabelSource);
            Controls.Add(LabelDescription);
            Controls.Add(LabelTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "关于";
            Load += AboutForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label LabelTitle;
        private Label LabelDescription;
        private LinkLabel LinkLabelSource;
        private LinkLabel LinkLabelIssues;
        private LinkLabel linkLabel1;
    }
}