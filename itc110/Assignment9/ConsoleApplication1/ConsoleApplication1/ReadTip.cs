using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace WpfAppTipForm
{
    class ReadTip
    {
        private StreamReader reader;
        public string filePath;

        public ReadTip(string path)
        {
            filePath = path;
        }

        public string GetFile()
        {
            reader = new StreamReader(filePath);
            string line = reader.ReadToEnd();
            return line;
        }
        
    }
}
