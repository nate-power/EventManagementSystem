using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCEventManagementSystem
{
    static class Program
    {
        /*
         * Justin Bartlett - 101246661
         * Nathan Power - 101247770
         * Alberto Dos Reis - 101232584
         * Roberto Borges - 101255891
         */

        [STAThread]
        static void Main()
        {         
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainMenu());            
        }
    }
}
