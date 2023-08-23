using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace vltguard
{
    public class VultGuard
    {
        public string m_VultHash = "601adb42ea61350b6f951894430a7966";

        // https://emn178.github.io/online-tools/md5_checksum.html
        // To get Vult's hash.
        public void SetVultHash(string hash)
        {
            m_VultHash = hash;
        }

        public bool CheckForVult()
        {
            // https://emn178.github.io/online-tools/md5_checksum.html
            // To get Vult's hash.
            string VultMD5Hash = m_VultHash;

            bool vultFound = false;

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
                        vultFound = true;
                        break;
                    }
                }
                catch (Exception)
                {
                    // Ignore
                }
            }

            return vultFound;
        }
    }
}
