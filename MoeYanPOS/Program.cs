using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MoeYanPOS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for t  application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UI.frmLogin());
        }
    }
}
