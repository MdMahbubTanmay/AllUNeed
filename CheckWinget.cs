using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace AllUNeed
{
    internal class CheckWinget
    {
        public static bool IsWinGetInstalled()
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "winget",
                    Arguments = "--version",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true
                };
                using (Process p = Process.Start(psi))
                {
                    p.WaitForExit();
                    return p.ExitCode == 0;
                }
            }
            catch { return false; }
        }
    


        public static void InstallWinGet()
        {
       
            string script = @"
            $progressPreference = 'silentlyContinue'
            Write-Host 'Downloading WinGet...'
            $latestRelease = Invoke-RestMethod -Uri 'https://api.github.com/repos/microsoft/winget-cli/releases/latest'
            $asset = $latestRelease.assets | Where-Object { $_.name -like '*msixbundle' } | Select-Object -First 1
            Invoke-WebRequest -Uri $asset.browser_download_url -OutFile 'winget.msixbundle'
            Write-Host 'Installing...'
            Add-AppxPackage -Path 'winget.msixbundle'
            Remove-Item 'winget.msixbundle'
        ";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{script}\"",
                UseShellExecute = true, 
                Verb = "runas"        
            };

            try
            {
                using (Process p = Process.Start(psi))
                {
                    p.WaitForExit();
                    Console.WriteLine("Installation process finished.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to start installer: {ex.Message}");
            }
        }
    }
}



