using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.Diagnostics;
using InterCapstone.FormApp.Models;
using System.Xml.Serialization;
using System.Xml;

namespace InterCapstone.FormApp
{
    public class CommandController
    {
        public string PythonEnvironmentName = "capstone";
        public string PythonScriptsPath = "Scripts/";
        public string XMLPath = "Scripts/results.xml";
        List<Package> packageList = new List<Package>();

        public bool ExecutePythonScript(string fileName)
        {
            //Modifying the File's Access Permissions
            File.SetAttributes($"Scripts/{fileName}.py", FileAttributes.Normal);

            var pyEngine = Python.CreateEngine();
            ScriptScope scriptScope = pyEngine.CreateScope(); // you need this to get the variables

            try
            {
                pyEngine.CreateScriptSourceFromFile($"Scripts/{fileName}.py").Execute(scriptScope);
                var result = pyEngine.Execute("x", scriptScope);

                Console.WriteLine($"Variable Output:{scriptScope.GetVariable("x")}");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops! Error Message:{ex.Message}");
                return false;
            }
        }

        public void ExecutePythonScriptFromCMD(string fileName, CapstoneFormApp DashboardForm)
        {
            Package myPackage = new Package();

            //Setup CMD
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            //Activate Python Environment and run Script
            Console.WriteLine("Activating Environment...");
            cmd.StandardInput.WriteLine($"activate {PythonEnvironmentName}");
            cmd.StandardInput.WriteLine($"cd {PythonScriptsPath}");
            cmd.StandardInput.WriteLine($"python {fileName}.py");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            myPackage = XMLResultsDeserializer(myPackage, XMLPath);
            DashboardForm.ShapeDetectedLabel.Text = $"Shape Detected: {myPackage.Shape}";
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());

        }
        

        private static Package XMLResultsDeserializer(Package pckg, string path)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Package));          
            using (XmlReader reader = XmlReader.Create(path))
            {
                pckg = (Package)ser.Deserialize(reader);
            }
            return pckg;
        }


    }
}
