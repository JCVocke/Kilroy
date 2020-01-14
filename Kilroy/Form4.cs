using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kilroy
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.Text = "Pryor";
        }
        public void setTitle(string t)
        {
            label1.Text = t;
        }
        public void clrTB()
        {
            richTextBox1.Clear();
        }
        public void addTB(string s)
        {
            richTextBox1.AppendText("\n" + s);
        }
        public string RichTextboxText 
        {
            get { return this.richTextBox1.Text; }
            set { this.richTextBox1.Text = value; }
        }
    }
}
