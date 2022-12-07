# OSEP

-------------------------------------\_~~__(··)_~~_/-------------------------------------------

This repository contains couple of scripts i had used to identity bypass Applocker rules.



- InstallNishangReverse:
  - Uses uninstall method of InstallUtil to invoke a remote powershell script in a new powershell runspace.
  - Powershell sciript should contain the function to execute when invoked / loaded or modify the String cmd with function to be invoked.
 
- InstallSharpUp:
  - Uses uninstall method of InstallUtil to run privilege escalation enumeration script sharpup  new powershell runspace.
  - As default the all check flag of Sharup - "audit" is choosen. Feel free to modify any other flags of SharpUp.

- Acknowledgments:
  - [SharpUp](https://github.com/GhostPack/SharpUp#readme)
  - [Nishang](https://github.com/samratashok/nishang)
