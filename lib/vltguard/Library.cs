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
            string VultMD5Hash = "219383a9712c7c42e057332ea0d1038c";

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
