using System.Diagnostics;

namespace AllUNeed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Hide();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label3.Show();
            MessageBox.Show("Please wait a few seconds while we are checking....");

            if (CheckWinget.IsWinGetInstalled())
            {
                SelectSoftware installerForm = new SelectSoftware();
                installerForm.Show();
                this.Hide();

            }
            else
            {
                DialogResult result = MessageBox.Show("WinGet is not installed. Do you want to install it now?", "WinGet Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    CheckWinget.InstallWinGet();
                    MessageBox.Show("Please restart the application after installing WinGet.", "Installation Started", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
