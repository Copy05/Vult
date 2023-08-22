using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace vltguard
{
    public class VultGuard
    {
        public void CheckForVult()
        {
            // https://emn178.github.io/online-tools/md5_checksum.html
            // To get Vult's hash.
            string VultMD5Hash = "0b47065143c4c585c32e2efac70e7e38";

            foreach (var process in Process.GetProcesses())
            {
                try
                {
                    string processPath = process.MainModule.FileName;
                    byte[] processHash = null;

                    using (var md5 = MD5.Create())
                    {
                        using (var stream = File.OpenRead(processPath))
                        {
                            processHash = md5.ComputeHash(stream);
                        }
                    }

                    string processMD5Hash = BitConverter.ToString(processHash).Replace("-", string.Empty).ToLower();

                    if (processMD5Hash == VultMD5Hash)
                    {
                        Environment.Exit(1);
                    }
                }
                catch (Exception)
                {
                    // Ignore any processes that we can't access
                }
            }
        }
    }
}
