using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Vult
{
    internal class VNMSecurity
    {
        public static void ScanDownloadFolder()
        {
            var un = Environment.UserName;
            //var dir = new DirectoryInfo(@"C:\Users\" + un + @"\Downloads");
            var dir = new DirectoryInfo(@"P:\Downloads\Example");
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
                } catch (Exception e)
                {
                    new VNMError("Scanning the Download Folder has failed.", "Security Error").Show();
                    MessageBox.Show(e.ToString());
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
                catch (Exception e)
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
                catch (Exception e)
                {
                    // Nothing
                }
            }
        }
    }
}
