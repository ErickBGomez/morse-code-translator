namespace MorseCodeTranslator
{
    partial class MorseCodeTranslator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MorseCodeTranslator));
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.enterInputGroupBox = new System.Windows.Forms.GroupBox();
            this.translateButton = new System.Windows.Forms.Button();
            this.typeOfInputGroupBox = new System.Windows.Forms.GroupBox();
            this.morseCodeGroupBox = new System.Windows.Forms.RadioButton();
            this.plainTextRadioButton = new System.Windows.Forms.RadioButton();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.textCopiedLabel = new System.Windows.Forms.Label();
            this.copyOutputButton = new System.Windows.Forms.Button();
            this.outputBGPanel = new System.Windows.Forms.Panel();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.creditsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.helpButton = new System.Windows.Forms.Button();
            this.enterInputGroupBox.SuspendLayout();
            this.typeOfInputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.outputBGPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            resources.ApplyResources(this.inputTextBox, "inputTextBox");
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // enterInputGroupBox
            // 
            this.enterInputGroupBox.Controls.Add(this.translateButton);
            this.enterInputGroupBox.Controls.Add(this.inputTextBox);
            resources.ApplyResources(this.enterInputGroupBox, "enterInputGroupBox");
            this.enterInputGroupBox.Name = "enterInputGroupBox";
            this.enterInputGroupBox.TabStop = false;
            // 
            // translateButton
            // 
            this.translateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.translateButton, "translateButton");
            this.translateButton.Name = "translateButton";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // typeOfInputGroupBox
            // 
            this.typeOfInputGroupBox.Controls.Add(this.morseCodeGroupBox);
            this.typeOfInputGroupBox.Controls.Add(this.plainTextRadioButton);
            this.typeOfInputGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.typeOfInputGroupBox, "typeOfInputGroupBox");
            this.typeOfInputGroupBox.Name = "typeOfInputGroupBox";
            this.typeOfInputGroupBox.TabStop = false;
            // 
            // morseCodeGroupBox
            // 
            resources.ApplyResources(this.morseCodeGroupBox, "morseCodeGroupBox");
            this.morseCodeGroupBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.morseCodeGroupBox.Name = "morseCodeGroupBox";
            this.morseCodeGroupBox.UseVisualStyleBackColor = true;
            this.morseCodeGroupBox.CheckedChanged += new System.EventHandler(this.morseCodeGroupBox_CheckedChanged);
            // 
            // plainTextRadioButton
            // 
            resources.ApplyResources(this.plainTextRadioButton, "plainTextRadioButton");
            this.plainTextRadioButton.Checked = true;
            this.plainTextRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plainTextRadioButton.Name = "plainTextRadioButton";
            this.plainTextRadioButton.TabStop = true;
            this.plainTextRadioButton.UseVisualStyleBackColor = true;
            this.plainTextRadioButton.CheckedChanged += new System.EventHandler(this.plainTextRadioButton_CheckedChanged);
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.textCopiedLabel);
            this.outputGroupBox.Controls.Add(this.copyOutputButton);
            this.outputGroupBox.Controls.Add(this.outputBGPanel);
            resources.ApplyResources(this.outputGroupBox, "outputGroupBox");
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.TabStop = false;
            // 
            // textCopiedLabel
            // 
            resources.ApplyResources(this.textCopiedLabel, "textCopiedLabel");
            this.textCopiedLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textCopiedLabel.Name = "textCopiedLabel";
            // 
            // copyOutputButton
            // 
            resources.ApplyResources(this.copyOutputButton, "copyOutputButton");
            this.copyOutputButton.Name = "copyOutputButton";
            this.copyOutputButton.UseVisualStyleBackColor = true;
            this.copyOutputButton.Click += new System.EventHandler(this.copyOutputButton_Click);
            // 
            // outputBGPanel
            // 
            this.outputBGPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.outputBGPanel.Controls.Add(this.outputTextBox);
            resources.ApplyResources(this.outputBGPanel, "outputBGPanel");
            this.outputBGPanel.Name = "outputBGPanel";
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.outputTextBox, "outputTextBox");
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            // 
            // creditsLabel
            // 
            resources.ApplyResources(this.creditsLabel, "creditsLabel");
            this.creditsLabel.Name = "creditsLabel";
            // 
            // creditsLinkLabel
            // 
            this.creditsLinkLabel.ActiveLinkColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.creditsLinkLabel, "creditsLinkLabel");
            this.creditsLinkLabel.LinkColor = System.Drawing.Color.SeaGreen;
            this.creditsLinkLabel.Name = "creditsLinkLabel";
            this.creditsLinkLabel.TabStop = true;
            this.creditsLinkLabel.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            this.creditsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditsLinkLabel_LinkClicked);
            // 
            // helpButton
            // 
            resources.ApplyResources(this.helpButton, "helpButton");
            this.helpButton.Name = "helpButton";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // MorseCodeTranslator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.creditsLinkLabel);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.typeOfInputGroupBox);
            this.Controls.Add(this.enterInputGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MorseCodeTranslator";
            this.Load += new System.EventHandler(this.MorseCodeTranslator_Load);
            this.enterInputGroupBox.ResumeLayout(false);
            this.enterInputGroupBox.PerformLayout();
            this.typeOfInputGroupBox.ResumeLayout(false);
            this.typeOfInputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.outputBGPanel.ResumeLayout(false);
            this.outputBGPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.GroupBox enterInputGroupBox;
        private System.Windows.Forms.GroupBox typeOfInputGroupBox;
        private System.Windows.Forms.RadioButton morseCodeGroupBox;
        private System.Windows.Forms.RadioButton plainTextRadioButton;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.LinkLabel creditsLinkLabel;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.Panel outputBGPanel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label textCopiedLabel;
        private System.Windows.Forms.Button copyOutputButton;
        private System.Windows.Forms.Button helpButton;
    }
}

