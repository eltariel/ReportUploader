using System;
using System.Windows.Forms;

namespace ReportUploader.Gui
{
    public static class WinformsExtensions
    {
        public static void InvokeIfRequired<T>(this T control, Action<T> action) where T : Control
        {
            if (control.InvokeRequired)
            {
                control.Invoke((Action)(() => action(control)));
            }
            else
            {
                action(control);
            }
        }
    }
}