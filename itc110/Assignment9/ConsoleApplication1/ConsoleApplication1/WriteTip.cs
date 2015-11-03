using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace WpfAppTipForm
{
  /* BLAKE SCHWARTZ     ITC 110     SECTION 3192        11/16/2014
   * For this assignment we are going use what we did in assignment 8 and add one feature:
   * We will write the tip information to a text file. This should be done in a separate class.  
   * Create a separate console program to read the tip file (This can all just be done in Main 
   * if you wish)
  */
    class WriteTip
    {
        private StreamWriter writer;
        public WriteTip(string path)
        {
            writer = new StreamWriter(path, true);
        }
        public void AddToFile(string line)
        {
            writer.WriteLine(line);
        }
        public void CloseFile()
        {
            writer.Close();
        }
    }
}
