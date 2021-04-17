﻿using System;
using System.Windows.Forms;
using AutoUpdate;

namespace racman
{
    static class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main(string[] args)
        {
            Updater.GitHubRepo = "/MichaelRelaxen/racman";
            if (Updater.AutoUpdate(args))
            {
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AttachPS3Form());

        }
    }
}
