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
    public partial class Form5 : Form
    {
        public int res = 0;

        public Form5()
        {
            InitializeComponent();
            this.Text = "Sortadorka";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            res = 1;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            res = 2;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            res = 0;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void SoIfYouSeeMeActingStrangely(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
