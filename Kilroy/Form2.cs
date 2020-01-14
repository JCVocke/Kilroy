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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            numericUpDown1.Focus();
            numericUpDown1.Select();
            this.Text = "Numba Numba Who got da Numba";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        
        private void SoIfYouSeeMeActingStrangely(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                    break;
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
