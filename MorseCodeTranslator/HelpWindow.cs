﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
