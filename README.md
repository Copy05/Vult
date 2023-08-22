# Vult

Vult is a service that works in the background for your safety and optimizes your workflow.

# Features

- Temporary File Cleaning
- Observing
- Blacklist Download Folder Scanning
- Regular Scanning
- Blocking Cheat Software

# Requirements

- Windows 10 or Later
- .NET 3.5 or Newer

# Protect your software with Vult:
**NOTE: I'm Working on a dedicated dll file for this**

**C++**
```cpp
    const wchar_t* processName = L"specific_program_name.exe";

    // Check if Vult is running
    if (GetProcessesByName(processName) > 0)
        // Run your program here
    else
        // Display an error message & exit the program
```


**C#**

```cs
if (Process.GetProcessesByName("Vult.exe").Length > 0)
        new ProgramForm().Show()
else
    MessageBox.Show("Error Message");
```