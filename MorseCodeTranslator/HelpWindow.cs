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
    public partial class HelpWindow : Form
    {
        public HelpWindow()
        {
            InitializeComponent();
        }

        private void copyOutputButton_Click(object sender, EventArgs e)
        {
            PublicMethods.CopyToClipboard(exampleMorseTextBox, textCopiedLabel);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
