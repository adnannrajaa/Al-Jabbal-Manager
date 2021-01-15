using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASDBFramework.Windows
{
    public class ASMessageBox 
    {
        public static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message , "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public static void ShowErrorMessage(string message,string title)
        {
            MessageBox.Show(message,title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowSucessMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowSucessMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowClosingMessage(string message)
        {
            MessageBox.Show(message, "Exit", MessageBoxButtons.YesNo);
        }
        public static void ShowClosingMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.YesNo);
        }
    }
}
