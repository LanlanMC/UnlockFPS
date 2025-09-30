using System.Diagnostics;

namespace unlockfps
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void LinkLabelSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://github.com/LanlanMC/UnlockFPS");
        }

        private void LinkLabelIssues_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://github.com/LanlanMC/UnlockFPS/issues");
        }

        private void OpenLink(string url)
        {
            var psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            Process.Start(psi);
        }

        private string GetVersionText(int versionNumber)
        {
            string version = versionNumber.ToString();
            string major = version[0].ToString();
            string minor = version[1].ToString();
            string build = int.Parse(version.Substring(2)).ToString();
            string originalBuild = version.Substring(2);
            if (originalBuild.Length > 1 && !originalBuild.EndsWith("0"))
                build = originalBuild;

            return $"{major}.{minor}.{build}";
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            LabelTitle.Text += GetVersionText(Program.Version);
        }
    }
}
