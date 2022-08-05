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
using System.IO;

namespace MorseCodeTranslator
{
    public partial class MorseCodeTranslator : Form
    {
        // List of allowed symbols
        List<char> registeredSymbols = new List<char>();

        // Dictionary of Letter and combination of symbols of Morse Code
        Dictionary<char, string> morseCode = new Dictionary<char, string>();

        // Dictionary of possible errors
        List<string> errors = new List<string>();

        public MorseCodeTranslator()
        {
            InitializeComponent();
        }

        #region Private methods

        private string PlainTextInputCorrection(string writtenInput)
        {
            return writtenInput.ToUpper();
        }

        // Translate method
        private void Translate()
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
                    if (morseCode.ContainsKey(letter))
                        outputText += morseCode[letter];
                    else
                    {
                        // If the input contains a character different of letters, numbers and spaces, show #ERROR01
                        MessageBox.Show(errors[1], errors[0], MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
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
                    // Verify if the input contains Dots (.), dashes (-) slashes (/) or spaces ( )
                    if (registeredSymbols.Contains(character))
                    {
                        // Characters are added to morseInput
                        morseInput += character;

                        // Evaluate the combinations of symbols only when the character is a space between combinations
                        if (character == ' ')
                        {
                            // If a special combination of dots and dashes is identified in dictionary (value)
                            if (morseCode.ContainsValue(morseInput))
                            {
                                // Add letter/number (key) to outputText
                                outputText += morseCode.FirstOrDefault(symbol => symbol.Value == morseInput).Key;
                                // Reset morseInput each time the combination is stored to outputText
                                morseInput = "";
                            }
                            else
                            {
                                // If morseInput contains an unregistered combination of symbol, print #ERROR03
                                MessageBox.Show(errors[3], errors[0], MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                        }
                    }
                    else
                    {
                        // If the input contains a symbol different of the registered list, print #ERROR02
                        MessageBox.Show(errors[2], errors[0], MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                        return;
                    }
                }
            }

            // Final output is set to the outputTextBox field
            outputTextBox.Text = outputText;

            textCopiedLabel.Visible = false;
            copyOutputButton.Enabled = true;
        }

        private void ClearInput()
        {
            inputTextBox.Text = "";
        }

        #endregion

        #region Load Form

        private void MorseCodeTranslator_Load(object sender, EventArgs e)
        {
            // Project path
            string projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            // Files paths
            string registeredSymbolsPath = projectPath + @"\registeredSymbols.txt";
            string morseCodePath = projectPath + @"\morseCode.txt";
            string errorsPath = projectPath + @"\errors.txt";

            // Array to Read File input Lines
            string[] readLines;


            // Allowed symbols for Morse Code
            readLines = File.ReadAllLines(registeredSymbolsPath);
            
            foreach(string line in readLines)
                registeredSymbols.Add(line.ToCharArray()[0]);


            // Morse Code Dictionary
            // Note: Each value has a space at the end to make every combination unique and to prevent errors
            readLines = File.ReadAllLines(morseCodePath);

            foreach (string line in readLines)
            {
                string[] splitLines = line.Split(',');
                morseCode.Add(splitLines[0].ToCharArray()[0], splitLines[1]);
            }

            // Assign errors to dictionary

            readLines = File.ReadAllLines(errorsPath);

            foreach (string line in readLines)
                errors.Add(line);

            // Set Enable false to translate button and copy button
            translateButton.Enabled = false;
            copyOutputButton.Enabled = false;
        }

        #endregion


        #region Clicks and text changes events
        // Translate when user clicks the translateButton
        private void translateButton_Click(object sender, EventArgs e)
        {
            Translate();
        }

        // Translate when user presses "Enter" key
        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && inputTextBox.Text != "")
                Translate();
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
