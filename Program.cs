﻿using PTC2024.View.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTC2024.formularios.login;

namespace PTC2024
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Dashboard newDa = new Dashboard();
            Application.Run(newDa);
=======
            Application.Run(new Login());
>>>>>>> Fernando-Login
        }
    }
}
