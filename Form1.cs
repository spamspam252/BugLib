using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bug {
    public partial class Form1 : Form {
        public Form1() {
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();


            //ADD open dialog here
            //Read r = new Read("d1a.cpp");
            Controller c = new Controller();
            c.makeHTML("Day7.cs");


        }


        

    }
}
