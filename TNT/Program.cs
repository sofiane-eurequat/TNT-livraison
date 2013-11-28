using System;
using System.IO;
using ComponentPro.Net;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using TNT.login;

namespace TNT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
           
            Application.Run(new authentification());
        }
    }
}