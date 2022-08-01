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
            // Note: Each value has a space at the end to make every combination unique and to prevent errors
            // A - Z
            morse.Add('A', ".- ");
            morse.Add('B', "-... ");
            morse.Add('C' ,"-.-. ");
            morse.Add('D', "-.. ");
            morse.Add('E', ". ");
            morse.Add('F', "..-. ");
            morse.Add('G', "--. ");
            morse.Add('H', ".... ");
            morse.Add('I', ".. ");
            morse.Add('J', ".--- ");
            morse.Add('K', "-.- ");
            morse.Add('L', ".-.. ");
            morse.Add('M', "-- ");
            morse.Add('N', "-. ");
            morse.Add('O', "--- ");
            morse.Add('P', ".--. ");
            morse.Add('Q', "--.- ");
            morse.Add('R', ".-. ");
            morse.Add('S', "... ");
            morse.Add('T', "- ");
            morse.Add('U', "..- ");
            morse.Add('V', "...- ");
            morse.Add('W', ".-- ");
            morse.Add('X', "-..- ");
            morse.Add('Y', "-.-- ");
            morse.Add('Z', "--.. ");
            // 0 - 9
            morse.Add('0', "----- ");
            morse.Add('1', ".---- ");
            morse.Add('2', "..--- ");
            morse.Add('3', "...-- ");
            morse.Add('4', "....- ");
            morse.Add('5', "..... ");
            morse.Add('6', "-.... ");
            morse.Add('7', "--... ");
            morse.Add('8', "---.. ");
            morse.Add('9', "----. ");
            // Space between words
            morse.Add(' ', "/ ");

            InitializeComponent();
        }

        #region Private methods

        private void ClearInput()
        {
            inputTextBox.Text = "";
        }

        #endregion


        #region Click Events
        // Translate Button
        private void translateButton_Click(object sender, EventArgs e)
        {
            string outputText = "";
            string morseInput = "";

            // Plain Text Input selected
            if (plainTextRadioButton.Checked)
            {
                // Reads the input, checks if each letter/number (key) exists in dictionary, and then adds each Morse symbol (value) to the output
                foreach (char letter in inputTextBox.Text)
                    if (morse.ContainsKey(letter))
                        outputText += morse[letter];
            }
            // Morse Code Input selected
            else
            {
                // Add a space at the end of the input to prevent errors with the dictionary
                inputTextBox.Text += " ";
                
                for (int i = 0; i < inputTextBox.Text.Length; i++)
                {
                    // Dots (.), dashes (-) and slashes (/) are added to morseInput
                    morseInput += inputTextBox.Text[i];

                    // If a special combination of dots and dashes is identified in dictionary (value)
                    if (morse.ContainsValue(morseInput))
                    {
                        // Add letter/number (key) to outputText
                        outputText += morse.FirstOrDefault(symbol => symbol.Value == morseInput).Key;
                        morseInput = "";
                    }
                }
            }

            // Final output is set to the outputTextBox field
            outputTextBox.Text = outputText;



            // Hide textCopiedLabel
            textCopiedLabel.Visible = false;

            // Enable copyOutputButton
            copyOutputButton.Enabled = true;
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

        private void plainTextRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void morseCodeGroupBox_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
        }
    }
}
