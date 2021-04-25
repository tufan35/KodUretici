using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodUretici
{
    public class FileManager
    {
        public void ClearTempDirectory()
        {
            string[] filePaths = Directory.GetFiles(@"C:\CodeGenerator\");
            foreach (string filePath in filePaths)
                File.Delete(filePath);
        }
        public void CreateFile(string FileName, string FileText)
        {
            

            string fileName = $@"C:\CodeGenerator\{FileName}.cs";

           
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine(FileText);
                   
                }

                //// Write file contents on console.     
                //using (StreamReader sr = File.OpenText(fileName))
                //{
                //    string s = "";
                //    while ((s = sr.ReadLine()) != null)
                //    {
                //        Console.WriteLine(s);
                //    }
                //}
           
        }
    }
}
