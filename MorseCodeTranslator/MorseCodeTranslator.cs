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

        #region Private Methods

        private void ChangeOutputStyles()
        {
            // Cambiar el estilo de la fuente una vez que se traduce en el output
        }

        #endregion


        #region Click Events
        // Translate Button
        private void translateButton_Click(object sender, EventArgs e)
        {
            string typeInput;
            if (plainTextRadioButton.Checked)
                typeInput = "Plain Text: ";
            else
                typeInput = "Morse Code: ";

            string input = inputTextBox.Text;
            outputTextBox.Text = typeInput + input;
        }

        // Credits Link Label
        private void creditsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ErickBGomez");
        }

        private void copyOutputButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(outputTextBox.Text);

            textCopiedLabel.Visible = true;
        }

        #endregion
    }
}
