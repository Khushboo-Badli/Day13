using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Linq_to_Object
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //defining a string array
            string[] books =
            {
                "Harry Potter",
                "Don't give a fuck to anyone",
                "The fault in our stars",
                "Secert",
                "Every one you hate is going to die"
            };

            //ling query
            IEnumerable<string> FavBooks = from name in books
                                           where name.Length > 15
                                           select name;

            // foreach to display objects
            foreach (var item in FavBooks)
            {
                richTextBox1.AppendText(item + "\n");
            }

        }
    }
}
