using System;
using System.Windows.Forms;
using Cosmatic_Shop_Management.Forms;

namespace Cosmatic_Shop_Management
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginForm());
        }
    }
}