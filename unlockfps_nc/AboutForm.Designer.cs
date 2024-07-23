namespace unlockfps_nc
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
            LinkLabelIssues = new LinkLabel();
            LinkLabelSource = new LinkLabel();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelTitle.Location = new Point(19, 14);
            LabelTitle.Margin = new Padding(5, 0, 5, 0);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(503, 58);
            LabelTitle.TabIndex = 0;
            LabelTitle.Text = "原神FPS解锁器\r\nv3.3.0";
            LabelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelDescription
            // 
            LabelDescription.Location = new Point(19, 72);
            LabelDescription.Margin = new Padding(5, 0, 5, 0);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new Size(503, 32);
            LabelDescription.TabIndex = 1;
            LabelDescription.Text = "此软件免费且开源";
            LabelDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LinkLabelIssues
            // 
            LinkLabelIssues.LinkArea = new LinkArea(19, 53);
            LinkLabelIssues.Location = new Point(5, 153);
            LinkLabelIssues.Margin = new Padding(5, 0, 5, 0);
            LinkLabelIssues.Name = "LinkLabelIssues";
            LinkLabelIssues.Size = new Size(522, 112);
            LinkLabelIssues.TabIndex = 3;
            LinkLabelIssues.TabStop = true;
            LinkLabelIssues.Text = "如果你遇到任何问题或有一些建议，请前往https://github.com/34736384/genshin-fps-unlock/issues提交一个Issue\r\n\r\n\r\n";
            LinkLabelIssues.TextAlign = ContentAlignment.MiddleCenter;
            LinkLabelIssues.UseCompatibleTextRendering = true;
            LinkLabelIssues.LinkClicked += LinkLabelIssues_LinkClicked;
            // 
            // LinkLabelSource
            // 
            LinkLabelSource.LinkArea = new LinkArea(3, 46);
            LinkLabelSource.Location = new Point(5, 104);
            LinkLabelSource.Margin = new Padding(5, 0, 5, 0);
            LinkLabelSource.Name = "LinkLabelSource";
            LinkLabelSource.Size = new Size(522, 49);
            LinkLabelSource.TabIndex = 2;
            LinkLabelSource.TabStop = true;
            LinkLabelSource.Text = "源码：https://github.com/34736384/genshin-fps-unlock";
            LinkLabelSource.TextAlign = ContentAlignment.MiddleCenter;
            LinkLabelSource.UseCompatibleTextRendering = true;
            LinkLabelSource.LinkClicked += LinkLabelSource_LinkClicked;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 244);
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
            ResumeLayout(false);
        }

        #endregion

        private Label LabelTitle;
        private Label LabelDescription;
        private LinkLabel LinkLabelIssues;
        private LinkLabel LinkLabelSource;
    }
}