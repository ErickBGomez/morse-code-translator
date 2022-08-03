using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MorseCodeTranslator
{
    public partial class MorseCodeTranslator : Form
    {
        // List of Letter to Morse Code
        Dictionary<char, string> morse = new Dictionary<char, string>();

        // Dictionary of possible errors
        Dictionary<int, string> error = new Dictionary<int, string>();

        public MorseCodeTranslator()
        {
            InitializeComponent();
        }

        #region Private methods

        string PlainTextInputCorrection(string writtenInput)
        {
            return writtenInput.ToUpper();
        }

        private void ClearInput()
        {
            inputTextBox.Text = "";
        }

        #endregion

        #region Load Form

        private void MorseCodeTranslator_Load(object sender, EventArgs e)
        {
            // Note: Each value has a space at the end to make every combination unique and to prevent errors
            // A - Z
            morse.Add('A', ".- ");
            morse.Add('B', "-... ");
            morse.Add('C', "-.-. ");
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

            // Assign errors to dictionary
            error.Add(1, "#ERROR01: Plain Text Input contains an invalid character (Use only letters and numbers)");
            error.Add(2, "#ERROR02: Morse Code Input contains an invalid character (Use only '.', '-' and '/')");
            error.Add(3, "#ERROR03: Morse Code Input contains an unregistered combination (See Morse Code Chart in the Help Window [?] for allowed symbol combinations)");

            // Set Enable false to translate button and copy button
            translateButton.Enabled = false;
            copyOutputButton.Enabled = false;
        }

        #endregion


        #region Clicks and text changes events
        // Translate Button
        private void translateButton_Click(object sender, EventArgs e)
        {
            string userInput = "";
            string outputText = "";
            string morseInput = "";

            // Plain Text Input selected
            if (plainTextRadioButton.Checked)
            {
                userInput = PlainTextInputCorrection(inputTextBox.Text);

                // Reads the input, checks if each letter/number (key) exists in dictionary, and then adds each Morse symbol (value) to the output
                foreach (char letter in userInput)
                    if (morse.ContainsKey(letter))
                        outputText += morse[letter];
                    else
                    {
                        // If the input contains a character different of letters, numbers and spaces, print #ERROR01
                        outputText = error[1];
                        break;
                    }

                // Delete the last space of the string
                outputText = outputText.Trim();
            }
            // Morse Code Input selected
            else
            {
                // Add a space at the end of the input to prevent errors with the dictionary
                userInput = inputTextBox.Text.Trim() + " ";

                foreach (char character in userInput)
                {
                    // Dots (.), dashes (-) and slashes (/) are added to morseInput
                    morseInput += character;

                    // Evaluate the combinations of symbols only when the character is a space between combinations
                    if (character == ' ')
                    {
                        // If a special combination of dots and dashes is identified in dictionary (value)
                        if (morse.ContainsValue(morseInput))
                        {
                            // Add letter/number (key) to outputText
                            outputText += morse.FirstOrDefault(symbol => symbol.Value == morseInput).Key;
                            morseInput = "";
                        }
                        else
                            // If morseInput contains an unregistered combination of symbol, print #ERROR03
                            outputText = error[3];
                    }
                }
            }

            // Final output is set to the outputTextBox field
            outputTextBox.Text = outputText;

            textCopiedLabel.Visible = false;

            // Enable copyOutputButton if there are no errors
            bool enableCopyOutputButton = (outputText[0] != '#') ? true : false;
            copyOutputButton.Enabled = enableCopyOutputButton;
        }

        // Don't translate when input is empty
        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            bool enableButton = (inputTextBox.Text != "") ? true : false;
            translateButton.Enabled = enableButton;
        }

        // Credits Link Label
        private void creditsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/ErickBGomez");
        }

        // Copy text button
        private void copyOutputButton_Click(object sender, EventArgs e)
        {
            PublicMethods.CopyToClipboard(outputTextBox, textCopiedLabel);
        }

        // Clear Input TextBox each time the user selects an different Type of Input
        private void plainTextRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void morseCodeGroupBox_CheckedChanged(object sender, EventArgs e)
        {
            ClearInput();
        }

        // Show HelpWindow form
        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpWindow help = new HelpWindow();
            help.Show();
        }

        #endregion
    }
}
