using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
// 
// Author Guy Matthew LaCrosse
// 
// This is just a simmple forms example, the C# equivalent of Hello World.
//
// Components:
//      Form
//      Label
//      Button
//
// If you have Visual Studio just create a New Project of type C#, Windows, Windows Forms Application
// drag and drop the label, button, copy the button. Double click the button to create an event
// handler for changing the Text of label1.


using System.Text;
using System.Windows.Forms;

namespace Example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = " ";
        }
    }
}
