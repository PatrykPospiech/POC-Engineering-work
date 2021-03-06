﻿using AppKit;
using Microsoft.MobileBlazorBindings.WebView.macOS;

namespace POC.Calc.API.Client.macOS
{
    internal static class MainClass
    {
        private static void Main(string[] args)
        {
            BlazorHybridMacOS.Init();
            NSApplication.Init();
            NSApplication.SharedApplication.Delegate = new AppDelegate();
            NSApplication.Main(args);
        }
    }
}
