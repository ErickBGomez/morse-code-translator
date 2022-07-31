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
            this.translateButton = new System.Windows.Forms.Button();
            this.enterInputGroupBox = new System.Windows.Forms.GroupBox();
            this.typeOfInputGroupBox = new System.Windows.Forms.GroupBox();
            this.plainTextRadioButton = new System.Windows.Forms.RadioButton();
            this.morseCodeGroupBox = new System.Windows.Forms.RadioButton();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.enterInputGroupBox.SuspendLayout();
            this.typeOfInputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.backgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            resources.ApplyResources(this.inputTextBox, "inputTextBox");
            this.inputTextBox.Name = "inputTextBox";
            // 
            // translateButton
            // 
            resources.ApplyResources(this.translateButton, "translateButton");
            this.translateButton.Name = "translateButton";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // enterInputGroupBox
            // 
            this.enterInputGroupBox.Controls.Add(this.inputTextBox);
            this.enterInputGroupBox.Controls.Add(this.translateButton);
            resources.ApplyResources(this.enterInputGroupBox, "enterInputGroupBox");
            this.enterInputGroupBox.Name = "enterInputGroupBox";
            this.enterInputGroupBox.TabStop = false;
            // 
            // typeOfInputGroupBox
            // 
            this.typeOfInputGroupBox.Controls.Add(this.morseCodeGroupBox);
            this.typeOfInputGroupBox.Controls.Add(this.plainTextRadioButton);
            resources.ApplyResources(this.typeOfInputGroupBox, "typeOfInputGroupBox");
            this.typeOfInputGroupBox.Name = "typeOfInputGroupBox";
            this.typeOfInputGroupBox.TabStop = false;
            // 
            // plainTextRadioButton
            // 
            resources.ApplyResources(this.plainTextRadioButton, "plainTextRadioButton");
            this.plainTextRadioButton.Checked = true;
            this.plainTextRadioButton.Name = "plainTextRadioButton";
            this.plainTextRadioButton.TabStop = true;
            this.plainTextRadioButton.UseVisualStyleBackColor = true;
            // 
            // morseCodeGroupBox
            // 
            resources.ApplyResources(this.morseCodeGroupBox, "morseCodeGroupBox");
            this.morseCodeGroupBox.Name = "morseCodeGroupBox";
            this.morseCodeGroupBox.UseVisualStyleBackColor = true;
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.backgroundPanel);
            resources.ApplyResources(this.outputGroupBox, "outputGroupBox");
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.TabStop = false;
            // 
            // outputLabel
            // 
            resources.ApplyResources(this.outputLabel, "outputLabel");
            this.outputLabel.Name = "outputLabel";
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.backgroundPanel.Controls.Add(this.outputLabel);
            resources.ApplyResources(this.backgroundPanel, "backgroundPanel");
            this.backgroundPanel.Name = "backgroundPanel";
            // 
            // MorseCodeTranslator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.typeOfInputGroupBox);
            this.Controls.Add(this.enterInputGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MorseCodeTranslator";
            this.enterInputGroupBox.ResumeLayout(false);
            this.enterInputGroupBox.PerformLayout();
            this.typeOfInputGroupBox.ResumeLayout(false);
            this.typeOfInputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.GroupBox enterInputGroupBox;
        private System.Windows.Forms.GroupBox typeOfInputGroupBox;
        private System.Windows.Forms.RadioButton morseCodeGroupBox;
        private System.Windows.Forms.RadioButton plainTextRadioButton;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Panel backgroundPanel;
    }
}

