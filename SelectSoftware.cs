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


        string downloadsPath = "thanks_abrar_vai";

        public SelectSoftware()
        {
            InitializeComponent();
        }


        void AddApp(string name, string id, bool areUGay = false)
        {
            string CornHubDotKom = "winget install --id " + id + " --source winget";

            if ( downloadsPath != "thanks_abrar_vai")
            {
                string location = downloadsPath + id;
                CornHubDotKom = "winget install --id " + id + " --location \"" + location + "\" --source winget";
            }


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

            if (downloadsPath != "thanks_abrar_vai")
            {
                if (!Directory.Exists(downloadsPath))
                {
                    MessageBox.Show("Inavlid path, nice try baby 😉 (Agerbar eita handel na korai crush dicilo jevabe ami tar upor crush kheyecilam, ahhh life :(  )");
                    return;
                }
            }

            Mahbub69.Clear();
            makeThatShittyDick("Ki Obostha :(");
            CheckSwitchPosition();

            if (WhatSelected.Count == 0)
            {
                MessageBox.Show("Select atleast one item , baby. 💩");
                return;
            }

            if (WhatSelected.Contains("Rufus") || WhatSelected.Contains("GeekUninstaller"))
            {
                string saki_bal_hasan = WhatSelected.Contains("Rufus") ? "rufus" : "geek";
                MessageBox.Show("U are installing " + (WhatSelected.Contains("Rufus") ? "Rufus" : "GeekUninstaller") + " which is a portable app, to run this portable app open cmd and type: " + saki_bal_hasan);
            }

            foreach (string JohnnyJohnnyYesPapa in WhatSelected)
            {



                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/k " + Mahbub69[JohnnyJohnnyYesPapa],
                    WindowStyle = ProcessWindowStyle.Normal
                };

                Process.Start(psi);


            }


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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Path_Click(object sender, EventArgs e)
        {
            string s = textBox1_Path.Text.ToString();

            if (Directory.Exists(s))
            {
                MessageBox.Show("Path set to: " + s);
                label11.Text = s;
                downloadsPath = s;
            }
            else
            {
                MessageBox.Show("Invalid path, Nice try baby. 💩");
            }
        }
    }
}