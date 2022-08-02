using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCodeTranslator
{
    internal class PublicMethods
    {
        public static void CopyToClipboard(TextBox text, Label textCopiedLabel)
        {
            Clipboard.SetText(text.Text);
            textCopiedLabel.Visible = true;
        }
    }
}
