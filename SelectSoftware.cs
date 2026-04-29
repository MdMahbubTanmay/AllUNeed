using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AllUNeed
{
    public partial class SelectSoftware : Form
    {
        List<string> WhatSelected = new List<string>();
        Dictionary<string, string> Mahbub69 = new Dictionary<string, string>();


        string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

        public SelectSoftware()
        {
            InitializeComponent();
            makeThatShittyDick("Ki Obostha :(");
        }


        void AddApp(string name, string id, bool areUGay = false)
        {
            string CornHubDotKom =  $"winget install --id {id} --silent --force --accept-package-agreements --accept-source-agreements ";

            Mahbub69.Add(name, CornHubDotKom);
        }



        private void makeThatShittyDick(string dick_mean_dictionary)
        {


            // 1. Web Browsers
            AddApp("Chrome", "Google.Chrome");
            AddApp("Brave", "Brave.Brave");
            AddApp("Firefox", "Mozilla.Firefox");
            AddApp("OperaGX", "Opera.OperaGX");

            // 2. Development & Coding
            AddApp("VSCode", "Microsoft.VisualStudioCode");
            AddApp("Git", "Git.Git");
            AddApp("Notepad++", "Notepad++.Notepad++");
            AddApp("Postman", "Postman.Postman");
            AddApp("Docker", "Docker.DockerDesktop");
            AddApp("DBeaver", "dbeaver.dbeaver");
            AddApp("Python", "Python.Python.3"); 
            AddApp("JDK21", "Oracle.JDK.21");

            // 3. Productivity & Office
            AddApp("PowerToys", "Microsoft.PowerToys");
            AddApp("Everything", "voidtools.Everything");
            AddApp("Obsidian", "Obsidian.Obsidian");
            AddApp("Notion", "Notion.Notion");
            AddApp("LibreOffice", "LibreOffice.LibreOffice");
            AddApp("Acrobat", "Adobe.Acrobat.Reader.GZ"); 
            AddApp("Zoom", "Zoom.Zoom");

            // 4. Utilities & System 
            AddApp("7Zip", "7zip.7zip");
            AddApp("Rufus", "Rufus.Rufus");
            AddApp("TreeSize", "JAMSoftware.TreeSizeFree");
            AddApp("CrystalDisk", "CrystalDewWorld.CrystalDiskInfo");
            AddApp("HWInfo", "REALiX.HWiNFO64"); 
            AddApp("BleachBit", "BleachBit.BleachBit");
            AddApp("GeekUninstaller", "GeekUninstaller.GeekUninstaller");

            // 5. Graphics & Media
            AddApp("VLC", "VideoLAN.VLC");
            AddApp("Handbrake", "Handbrake.Handbrake");
            AddApp("OBS", "OBSProject.OBSStudio");
            AddApp("ShareX", "ShareX.ShareX");
            AddApp("GIMP", "GIMP.GIMP"); 
            AddApp("Inkscape", "Inkscape.Inkscape");
            AddApp("Spotify", "Spotify.Spotify");

            // 6. Communication & Social
            AddApp("Discord", "Discord.Discord");
            AddApp("WhatsApp", "WhatsApp.WhatsApp");
            AddApp("Telegram", "Telegram.TelegramDesktop");
            AddApp("Slack", "SlackTechnologies.Slack");

            // 7. Security & Internet
            AddApp("Bitwarden", "Bitwarden.Bitwarden");
            AddApp("ProtonVPN", "Proton.ProtonVPN");
            AddApp("qBittorrent", "qBittorrent.qBittorrent");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckSwitchPosition();

            if (WhatSelected.Count == 0)
            {
                MessageBox.Show("Select atleast one item baby. 💩");
                return;
            }

            foreach (string software in WhatSelected)
            {
                if (!Mahbub69.ContainsKey(software)) continue;

                string command = Mahbub69[software];
                bool isPortable = (software == "Rufus" || software == "GeekUninstaller");
                //

                if (isPortable)
                {
                    command += $" --location \"{downloadsPath}\"";

                }

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + command,
                    WindowStyle = ProcessWindowStyle.Normal
                };

                using (Process proc = Process.Start(psi))
                {
                    if (isPortable)
                    {
                        
                        proc.WaitForExit();

                       
                        Process.Start("explorer.exe", downloadsPath);
                    }
                    else
                    {
                      
                        proc.WaitForExit();
                    }
                }
            }

            MessageBox.Show("Congratulations, Downloaded All the 4k 8 tin Plus video for you :)");
            MessageBox.Show("Just Kidding, downloded all the software u selected :\\ ");
        }

        private void CheckSwitchPosition()
        {
            WhatSelected.Clear();

            if (checkBox1.Checked) WhatSelected.Add("Chrome");
            if (checkBox2.Checked) WhatSelected.Add("Brave");
            if (checkBox3.Checked) WhatSelected.Add("OperaGX");
            if (checkBox4.Checked) WhatSelected.Add("Firefox");
            if (checkBox5.Checked) WhatSelected.Add("VSCode");
            if (checkBox12.Checked) WhatSelected.Add("Git");
            if (checkBox11.Checked) WhatSelected.Add("Notepad++");
            if (checkBox10.Checked) WhatSelected.Add("Python");
            if (checkBox7.Checked) WhatSelected.Add("JDK21");
            if (checkBox15.Checked) WhatSelected.Add("Docker");
            if (checkBox16.Checked) WhatSelected.Add("Postman");
            if (checkBox17.Checked) WhatSelected.Add("DBeaver");
            if (checkBox14.Checked) WhatSelected.Add("PowerToys");
            if (checkBox6.Checked) WhatSelected.Add("Everything");
            if (checkBox8.Checked) WhatSelected.Add("Obsidian");
            if (checkBox9.Checked) WhatSelected.Add("Notion");
            if (checkBox13.Checked) WhatSelected.Add("LibreOffice");
            if (checkBox18.Checked) WhatSelected.Add("Acrobat");
            if (checkBox19.Checked) WhatSelected.Add("Zoom");
            if (checkBox20.Checked) WhatSelected.Add("Slack");
            if (checkBox21.Checked) WhatSelected.Add("7Zip");
            if (checkBox22.Checked) WhatSelected.Add("Rufus");
            if (checkBox23.Checked) WhatSelected.Add("TreeSize");
            if (checkBox24.Checked) WhatSelected.Add("CrystalDisk");
            if (checkBox25.Checked) WhatSelected.Add("HWInfo");
            if (checkBox26.Checked) WhatSelected.Add("BleachBit");
            if (checkBox27.Checked) WhatSelected.Add("GeekUninstaller");
            if (checkBox28.Checked) WhatSelected.Add("VLC");
            if (checkBox29.Checked) WhatSelected.Add("Handbrake");
            if (checkBox30.Checked) WhatSelected.Add("OBS");
            if (checkBox31.Checked) WhatSelected.Add("ShareX");
            if (checkBox32.Checked) WhatSelected.Add("GIMP");
            if (checkBox33.Checked) WhatSelected.Add("Inkscape");
            if (checkBox34.Checked) WhatSelected.Add("Spotify");
            if (checkBox35.Checked) WhatSelected.Add("Discord");
            if (checkBox36.Checked) WhatSelected.Add("WhatsApp");
            if (checkBox37.Checked) WhatSelected.Add("Telegram");
            if (checkBox39.Checked) WhatSelected.Add("Bitwarden");
            if (checkBox40.Checked) WhatSelected.Add("ProtonVPN");
            if (checkBox41.Checked) WhatSelected.Add("qBittorrent");
        }
    }
}