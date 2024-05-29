//using App2.ViewModels;
//using App2.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace App2
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
            BindingContext = new AppShellViewModel();
        }

    }
}
