﻿using System;
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
using Emulate.viewsmodel;

namespace Emulate.views.game
{
    /// <summary>
    /// Logique d'interaction pour Page1.xaml
    /// </summary>
    public partial class CreateCharViews : Page
    {
        public CreateCharViews()
        {
            InitializeComponent();
            DataContext = new PersonnageAdminVM(this);
        }

        public CreateCharViews(ChoosePartyAdminVM choosePartyModel)
        {
            InitializeComponent();
            this.DataContext = choosePartyModel;
            choosePartyModel.LoadCreateCharPage(this);
        }
    }
}
