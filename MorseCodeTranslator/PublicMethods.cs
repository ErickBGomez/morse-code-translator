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
