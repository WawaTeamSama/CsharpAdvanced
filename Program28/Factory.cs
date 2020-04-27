using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Program28
{
    class Factory
    {
        public static BaseFile GetFile(string filePath,string fileName)
        {
            BaseFile bf = null;
            string extension = Path.GetExtension(fileName);

            switch (extension) 
            {
                case ".txt":
                    bf = new TxTFile(filePath, fileName);
                    break;
                case ".mp4":
                    bf = new Mp4File(filePath, fileName);
                    break;
                case ".gif":
                    bf = new GIFFile(filePath, fileName);
                    break;

            }
            return bf;
            
        }
    }
}
