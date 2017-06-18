using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Emulate.views.administration;
using Emulate.logger;
using Emulate.entities;
using Emulate.database.entitieslinks;

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
            //AppDBTest();
        }

        //private async void AppDBTest()
        //{
            //#region AppDBTest
            //Items item1 = new Items();
            //item1.Name = "Cape des échos faiblissants";
            //item1.Ilvl = 155;

            //Items item2 = new Items();
            //item2.Name = "Un Anneau Pour les gourverners tous!";
            //item2.Ilvl = 155;

            //Items item3 = new Items();
            //item3.Name = "Cape d'invisibilité";
            //item3.Ilvl = 155;

            //Items item4 = new Items();
            //item4.Name = "Collier des milles perles";
            //item4.Ilvl = 155;

            //Boss boss1 = new Boss();
            //boss1.Name = "Dresaron";
            //boss1.ListLoot.Add(item1);
            //boss1.ListLoot.Add(item2);

            //Boss boss2 = new Boss();
            //boss2.Name = "Ombre de Xavius";
            //boss2.ListLoot.Add(item3);
            //boss2.ListLoot.Add(item4);

            //Donjon donjon = new Donjon();
            //donjon.Name = "Fourré Sombre Coeur";
            //donjon.IlvlLuck = 160;
            //donjon.ListeBoss.Add(boss1);
            //donjon.ListeBoss.Add(boss2);

            //Items item5 = new Items();
            //item5.Name = "TEST eh non c est vraiment un item...";
            //item5.Ilvl = 160;

            //Items item6 = new Items();
            //item6.Name = "Cape de Deuille Givre";
            //item6.Ilvl = 160;

            //Items item7 = new Items();
            //item7.Name = "Anneau des deux tours";
            //item2.Ilvl = 160;

            //Items item8 = new Items();
            //item8.Name = "Collier des sans ames";
            //item8.Ilvl = 160;



            //Boss boss3 = new Boss();
            //boss3.Name = "Dresaron";
            //boss3.ListLoot.Add(item5);
            //boss3.ListLoot.Add(item6);

            //Boss boss4 = new Boss();
            //boss4.Name = "Ombre de Xavius";
            //boss4.ListLoot.Add(item7);
            //boss4.ListLoot.Add(item8);

            //Donjon donjon1 = new Donjon();
            //donjon1.Name = "ICC";
            //donjon1.IlvlLuck = 170;
            //donjon1.ListeBoss.Add(boss3);
            //donjon1.ListeBoss.Add(boss4);


            //MySQLDonjonManager donjonManager = new MySQLDonjonManager();

            //Donjon test = await donjonManager.Insert(donjon);
            //Donjon test2 = await donjonManager.Insert(donjon1); 
            //#endregion
        //}

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
