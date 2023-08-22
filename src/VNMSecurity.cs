using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Vult
{
    internal class VNMSecurity
    {
        public static void CheckForCheats()
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (process.ProcessName.ToLower().Contains("cheat"))
                {
                    try
                    {
                        new Form1().SendNotification("A Cheat Programm called " + process.ProcessName + " has been closed.", "Vult");
                        process.Kill();
                    } catch (Exception)
                    {
                        new VNMError("Something Went wrong while processing a cheat software", "Security Error").Show();
                    }

                }
            }
        }

        public static void ScanDownloadFolder()
        {
            var un = Environment.UserName;
            var dir = new DirectoryInfo(@"C:\Users\" + un + @"\Downloads");
            List<string> search = Directory.GetFiles(dir.ToString(), "*.*", SearchOption.AllDirectories).ToList();
            var blacklist = @"BlackListSoftware.txt";

            foreach(var item in search)
            {
                try
                {
                    string fileName = Path.GetFileName(item);
                    string[] lines = File.ReadAllLines(blacklist);

                    foreach (string line in lines)
                    {
                        if (fileName.Equals(line, StringComparison.OrdinalIgnoreCase))
                        {
                            File.Delete(item);
                            new Form1().SendNotification("A Blacklisted File called " + line + " has been deleted", "Vult");
                            break;
                        }
                    }
                } catch (Exception)
                {
                    new VNMError("Scanning the Download Folder has failed.", "Security Error").Show();
                }
            }
        }

        public static void ClearTempFolder()
        {
            var un = Environment.UserName;
            var dir = new DirectoryInfo(@"C:\Users\" + un + @"\AppData\Local\Temp");

            foreach (var file in Directory.GetFiles(dir.ToString()))
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception)
                {
                    // Nothing
                }
            }

            foreach (var folder in Directory.GetDirectories(dir.ToString()))
            {
                try
                {
                    Directory.Delete(folder, true);
                }
                catch (Exception)
                {
                    // Nothing
                }
            }
        }
    }
}
