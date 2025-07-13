// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) Matula Marton. All rights reserved.
// </copyright>
namespace Huszonegy
{
    using System;
    using System.Windows.Forms;

    /// <summary>Class for the application running.</summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Huszonegy());
        }
    }
}
