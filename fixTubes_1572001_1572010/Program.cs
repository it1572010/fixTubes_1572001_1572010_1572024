using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fixTubes_1572001_1572010
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyGLWindows GLSaya = new MyGLWindows(600, 600);
            GLSaya.Run(30.0f);
        }
    }
}
