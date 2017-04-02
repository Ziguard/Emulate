using ClassLibrary2.Entities.Generator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Emulate.database;
using Emulate.entities;
using Emulate.json;

namespace Emulate.views.administration
{
    /// <summary>
    /// Logique d'interaction pour Example.xaml
    /// </summary>
    public partial class Example : Page
    {
        ObservableCollection<Donjon> DonjonList = new ObservableCollection<Donjon>();
        ObservableCollection<Boss> BossList = new ObservableCollection<Boss>();
        public Example()
        {
            InitializeComponent();
            this.UCDonjonList.ItemsList.SelectionChanged += ItemsList_SelectionChanged;
            InitLists();
            //AsyncExample();
        }

        //private void AsyncExample()
        //{
        //    MySQLManager<Address> addMan = new MyS
        //    Task.Factory.StartNew(() =>
        //    {
        //        EntityGenerator<Address> generator = new EntityGenerator<Address>();
        //        while (true)
        //        {
        //            System.Windows.Application.Current.Dispatcher.Invoke(DispatcherPriority.Background, new D);
        //            this.UCAddressList.Obs.Add(generator.GenerateItem());
        //        }
        //    });
        //}

        private void ItemsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                Classe item = (e.AddedItems[0] as Classe);

            }
        }

        private async void InitLists()
        {
            MySQLManager<Donjon> donjonManager = new MySQLManager<Donjon>();
            this.UCDonjonList.LoadItems((await donjonManager.Get()).ToList());

            //MySQLManager <Personnage> bossManager = new MySQLManager<Personnage>();
            //this.UCBossList.LoadItem((await bossManager.Get()).ToList());
        }

        private void UCAddressList_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
