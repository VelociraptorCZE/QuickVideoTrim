/**
 * QuickVideoTrim
 * Copyright (c) Simon Raichl 2025
 */

using System;
using System.Windows.Forms;

namespace QuickVideoTrim
{
    internal static class AppRunner
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QuickVideoTrimApp());
        }
    }
}
