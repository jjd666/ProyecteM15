using PRJM15MVCJesusJuanDavid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class Controller
    {
        MainForm f1 = new MainForm();
        FormVistaAdmin f2 = new FormVistaAdmin();
        FormVistaClient f3 = new FormVistaClient();

        public void init()
        {
            run();
        }
        public void run()
        {
            Application.Run(f1);
        }

    }
}
