using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Program28
{
   public class BaseFile
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public BaseFile(string filePath,string fileName) 
        {
            this.FileName = fileName;
            this.FilePath = FilePath;
        }
        public void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.FilePath + "\\" + this.FileName);
            Process pro = new Process();
            pro.StartInfo = psi;
            pro.StartInfo.UseShellExecute = true;
            pro.Start();
        }
    }
}
