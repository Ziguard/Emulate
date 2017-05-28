﻿using Emulate.entities;
using Emulate.views.administration;
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
using Emulate.viewsmodel.administration;

namespace Emulate.views.administration
{
    /// <summary>
    /// Logique d'interaction pour AdministrationViews.xaml
    /// </summary>
    public partial class AdministrationViews : Page
    {  
        public AdministrationViews()
        {
            InitializeComponent();
            this.DataContext = new AdministrationAdminVM(this);
        }
    }
}
