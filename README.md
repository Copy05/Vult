# Vult

Vult is a service that works in the background for your safety and optimizes your workflow.

# Features

- AntiVirus Scanning.
- Temporary File Cleaning
- Observing
- Blacklist Download Folder Scanning
- Regular Scanning
- Blocking Cheat Software

# Requirements

- Windows 10 or Later
- .NET 3.5 or Newer
- Visual Studio 2022 or Newer

# Protect your software with Vult:
For C# you can use `vltguard.dll` to implement VultGuard to your application
<br>
**C#**

```cs
using vltguard;

namespace YourApplication
{
    class Program
    {
        // our hypertheoretical "REAL" Application
        static void RealApplication(){
            Console.WriteLine("Hello World!");
        }

        static void Main(string[] args)
        {
            VultGuard vg = new VultGuard();

            // https://emn178.github.io/online-tools/md5_checksum.html To get Vult's hash.
            string vultHash = "601adb42ea61350b6f951894430a7966"
            vg.SetVultHash(vultHash);

            // if it returns true the application can start since vult is running.
            if(vg.CheckForVult())
                RealApplication();
            else
                return;
        }
    }
}
```

**C++**
```cpp
    const wchar_t* processName = L"specific_program_name.exe";

    // Check if Vult is running
    if (GetProcessesByName(processName) > 0)
        // Run your program here
    else
        // Display an error message & exit the program
```
