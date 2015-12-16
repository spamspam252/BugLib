using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug {
    public class Controller {
        private List<string> text;

        public Controller() {
            text = new List<string>();
        }
        public string makeHTML(string path) {
            string start = "<pre class=\"prettyprint\">\n";
            string end = "</pre>\n";
            string script = "<script src=\"https://google-code-prettify.googlecode.com/svn/loader/run_prettify.js?\"></script>";
            Read r = new Read(path);

            text.Add(start);
            r.read(text);
            text.Add(end);
            text.Add(script);

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter($"{path.Split('.')[0]}.html")) {
                foreach (string line in text) {
                    file.WriteLine(line);
                }
            }

            return null;


        }





    }
}
