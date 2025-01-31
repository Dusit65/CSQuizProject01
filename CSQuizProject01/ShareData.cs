using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSQuizProject01
{
    internal class ShareData
    {
        //Method show warning======================================
        public static void showWarningMSG(String msg)
        {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //Method show dialog======================================
        public static void showDialogMSG(String msg)
        {
            MessageBox.Show(msg, "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
