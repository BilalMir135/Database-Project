using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Standard_Books
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if(File.Exists(path+"\\SB settings"))
            {
                Application.Run(new Splash_Screen());
            }
            else
            {
                Application.Run(new Default_Settings());
            }
           
        }
    }
}
