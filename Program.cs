using System;
using System.IO;
using System.Diagnostics;

namespace Google
{
    class Program
    {
 
        static void Main(string[] args)
        {
            string link = "";
            if(!File.Exists("cfg.txt")){
                File.Create("cfg.txt");
                return;
            }
            else{
                FileStream fs = new FileStream("cfg.txt",FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                link = sr.ReadLine();
            }

            if(link == null) return;

            try{
                System.Diagnostics.Process.Start(link);
            }
            catch (System.Exception){
                Process process = new Process();
                process.StartInfo.UseShellExecute = true; 
                process.StartInfo.FileName = link;
                process.Start();
            }
            
        }
    }
}
