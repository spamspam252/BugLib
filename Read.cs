using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bug {
    public class Read {
        private string path;
        public Read(string path) {
            this.path = path;
        }

        public void read(List<string> str) {
            string line;
            try {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(path)) {
                    // Read the stream to a string, and write the string to the console.
                    while (!sr.EndOfStream) {
                        line = sr.ReadLine() + "\n";

                        line = line.Replace("<", "&lt;");
                        line = line.Replace(">", "&gt;");

                        str.Add(line);
                    }
                }
            } catch (Exception e) {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }





    }
}
