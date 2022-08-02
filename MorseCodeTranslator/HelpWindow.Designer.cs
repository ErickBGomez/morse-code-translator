namespace MorseCodeTranslator
{
    partial class HelpWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWindow));
            this.helpTabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.exampleMorseTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.howToUseLabel = new System.Windows.Forms.Label();
            this.morseCodeChartTab = new System.Windows.Forms.TabPage();
            this.helpTabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpTabControl
            // 
            this.helpTabControl.Controls.Add(this.tabPage2);
            this.helpTabControl.Controls.Add(this.morseCodeChartTab);
            this.helpTabControl.Location = new System.Drawing.Point(2, 2);
            this.helpTabControl.Name = "helpTabControl";
            this.helpTabControl.SelectedIndex = 0;
            this.helpTabControl.Size = new System.Drawing.Size(515, 445);
            this.helpTabControl.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.exampleMorseTextBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.howToUseLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(507, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "How to use";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // exampleMorseTextBox
            // 
            this.exampleMorseTextBox.Location = new System.Drawing.Point(72, 304);
            this.exampleMorseTextBox.Name = "exampleMorseTextBox";
            this.exampleMorseTextBox.ReadOnly = true;
            this.exampleMorseTextBox.Size = new System.Drawing.Size(196, 20);
            this.exampleMorseTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 168);
            this.label3.TabIndex = 3;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Translate from Morse Code to Plain Text";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // howToUseLabel
            // 
            this.howToUseLabel.AutoSize = true;
            this.howToUseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToUseLabel.Location = new System.Drawing.Point(7, 7);
            this.howToUseLabel.Name = "howToUseLabel";
            this.howToUseLabel.Size = new System.Drawing.Size(235, 13);
            this.howToUseLabel.TabIndex = 0;
            this.howToUseLabel.Text = "Translate from Plain Text to Morse Code";
            // 
            // morseCodeChartTab
            // 
            this.morseCodeChartTab.Location = new System.Drawing.Point(4, 22);
            this.morseCodeChartTab.Name = "morseCodeChartTab";
            this.morseCodeChartTab.Padding = new System.Windows.Forms.Padding(3);
            this.morseCodeChartTab.Size = new System.Drawing.Size(486, 399);
            this.morseCodeChartTab.TabIndex = 2;
            this.morseCodeChartTab.Text = "Morse Code Chart";
            this.morseCodeChartTab.UseVisualStyleBackColor = true;
            // 
            // HelpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.helpTabControl);
            this.Name = "HelpWindow";
            this.Text = "Help";
            this.helpTabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl helpTabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label howToUseLabel;
        private System.Windows.Forms.TabPage morseCodeChartTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox exampleMorseTextBox;
    }
}