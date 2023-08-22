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

        public static void EraseMalware()
        {
            var MD5Signs = File.ReadAllLines("BlacklistHashes.txt");

            try
            {
                var un = Environment.UserName;
                var dir = new DirectoryInfo(@"C:\");
                List<string> search = Directory.GetFiles(dir.ToString(), "*.*", SearchOption.AllDirectories).ToList();

                foreach (string file in search)
                {
                    try
                    {
                        string fileMD5Hash = Crypto.GetMD5(file);

                        if (Array.Exists(MD5Signs, hash => hash.Equals(fileMD5Hash)))
                        {
                            new VNMDetection(file).Show();
                            //new Form1().SendNotification("A Malicious File " + file + " has been removed.", "Vult");
                            //File.Delete(file);
                        }

                    }
                    catch (Exception)
                    {
                        new VNMError("Something went from while protecting you", "Security Error");
                    }
                }
            } catch (Exception)
            {
                new VNMError("Something went from while scanning your device. process aborted", "Security Scan Error");
                return;
            }

        }

        public static void ScanAllProcesses()
        {
            List<string> blacklist = File.ReadAllLines("BlacklistHashes.txt").ToList();
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                try
                {
                    string processHash = Crypto.GetMD5(process.MainModule.FileName);

                    // Check if the process has an MD5 hash that is in the blacklist
                    if (blacklist.Contains(processHash))
                    {
                        process.Kill();
                        new Form1().SendNotification("A Malicious process " + process + " has been killed.", "Vult");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur
                    Console.WriteLine($"Error getting MD5 hash for process {process.ProcessName}: {ex.Message}");
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
