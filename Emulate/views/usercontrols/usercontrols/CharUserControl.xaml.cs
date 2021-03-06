﻿using Emulate.entities;
using System;
using System.Collections.Generic;
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

namespace Emulate.views.usercontrols.usercontrols
{
    /// <summary>
    /// Logique d'interaction pour CharUserControlUserControl.xaml
    /// </summary>
    public partial class CharUserControl : UserControlBase
    {

        private Character personnage;

        public Character Personnage
        {
            get { return personnage; }
            set {
                personnage = value;
                base.OnPropertyChanged("Personnage"); }
        }

        public CharUserControl()
        {
            InitializeComponent();
            base.DataContext = this;
        }
    }
}
