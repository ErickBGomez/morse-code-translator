using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MorseCodeTranslator
{
    public partial class MorseCodeTranslator : Form
    {
        // List of Letter to Morse Code
        Dictionary<char, string> morse = new Dictionary<char, string>();

        public MorseCodeTranslator()
        {
            // A - Z
            morse.Add('A', ".-");
            morse.Add('B', "-...");
            morse.Add('C' ,"-.-.");
            morse.Add('D', "-..");
            morse.Add('E', ".");
            morse.Add('F', "..-.");
            morse.Add('G', "--.");
            morse.Add('H', "....");
            morse.Add('I', "..");
            morse.Add('J', ".---");
            morse.Add('K', "-.-");
            morse.Add('L', ".-..");
            morse.Add('M', "--");
            morse.Add('N', "-.");
            morse.Add('O', "---");
            morse.Add('P', ".--.");
            morse.Add('Q', "--.-");
            morse.Add('R', ".-.");
            morse.Add('S', "...");
            morse.Add('T', "-");
            morse.Add('U', "..-");
            morse.Add('V', "...-");
            morse.Add('W', ".--");
            morse.Add('X', "-..-");
            morse.Add('Y', "-.--");
            morse.Add('Z', "--..");
            // 0 - 9
            morse.Add('0', "-----");
            morse.Add('1', ".----");
            morse.Add('2', "..---");
            morse.Add('3', "...--");
            morse.Add('4', "....-");
            morse.Add('5', ".....");
            morse.Add('6', "-....");
            morse.Add('7', "--...");
            morse.Add('8', "---..");
            morse.Add('9', "----.");
            // Spaces between words
            morse.Add(' ', "/");

            InitializeComponent();
        }

        #region Private Methods

        #endregion


        #region Click Events
        // Translate Button
        private void translateButton_Click(object sender, EventArgs e)
        {
            bool firstTranslation = false;

            string outputText = "";


            // Plain Text Input selected
            if (plainTextRadioButton.Checked)
            {
                foreach (char letter in inputTextBox.Text)
                    if (morse.ContainsKey(letter))
                        outputText += morse[letter] + " ";

            }
            // Morse Code Input selected
            else
            {

            }

            outputTextBox.Text = outputText;



            if (firstTranslation)
            {
                // Hide textCopiedLabel
                textCopiedLabel.Visible = false;

                // Enable copyOutputButton
                copyOutputButton.Enabled = true;
            }
            else
                firstTranslation = true;
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
