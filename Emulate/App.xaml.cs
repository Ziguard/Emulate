﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Emulate.views.administration;
using Emulate.logger;

namespace Emulate
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        public Logger logger { get; set; }

        public Logger2 logger2 { get; set; }

        public App()
        {
            //logger = new Logger("Logger1", LogMode.CURRENT_FOLDER, AlertMode.CONSOLE);
            //logger.LifeCycle = true;
            //logger2 = new Logger2("ApplicationHundleExceptionLogger", LogMode.CURRENT_FOLDER, AlertMode.CONSOLE);
            //this.DispatcherUnhandledException += App_DispatcherUnhandledException1;
        }

        private void App_DispatcherUnhandledException1(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            logger2.Log(e.Exception);
        }

        private void App_NavigationStopped(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            logger.Log("App_NavigationStopped");
        }

        private void App_NavigationProgress(object sender, System.Windows.Navigation.NavigationProgressEventArgs e)
        {
            logger.Log("App_NavigationProgress");
        }

        private void App_NavigationFailed(object sender, System.Windows.Navigation.NavigationFailedEventArgs e)
        {
            logger.Log("App_NavigationFailed");
        }

        private void App_Navigating(object sender, System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            logger.Log("App_Navigating");
        }

        private void App_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            logger.Log("App_Navigated");
        }

        private void App_FragmentNavigation(object sender, System.Windows.Navigation.FragmentNavigationEventArgs e)
        {
            logger.Log("App_FragmentNavigation");
        }

        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            logger.Log("App_Deactivated");
        }

        private void App_Exit(object sender, ExitEventArgs e)
        {
            logger.Log("App_Exit");
        }

        private void App_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            logger.Log("App_LoadCompleted");
        }

        private void App_SessionEnding(object sender, SessionEndingCancelEventArgs e)
        {
            logger.Log("App_SessionEnding");
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            logger.Log("App_Startup");
        }

        private void App_Deactivated(object sender, EventArgs e)
        {
            logger.Log("App_Deactivated");
        }

        private void App_Activated(object sender, EventArgs e)
        {
            logger.Log("App_Activated");
        }
    }
}
