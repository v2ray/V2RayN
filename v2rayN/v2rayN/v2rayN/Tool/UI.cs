using System.Windows.Forms;

namespace v2rayN
{
    class UI
    {
        public static void Show(string msg)
        {
            MessageBox.Show(msg);
        }

        public static DialogResult ShowYesNo(string msg)
        {
            return MessageBox.Show(msg, "YesNo", MessageBoxButtons.YesNo);
        }
    }
}
