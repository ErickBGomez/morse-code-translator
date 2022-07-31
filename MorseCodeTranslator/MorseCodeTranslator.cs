using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCodeTranslator
{
    public partial class MorseCodeTranslator : Form
    {
        public MorseCodeTranslator()
        {
            InitializeComponent();
        }


        private void translateButton_Click(object sender, EventArgs e)
        {

        }


        private void creditsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ErickBGomez");
        }
    }
}
