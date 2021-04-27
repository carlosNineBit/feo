﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FEOAPP.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FEOAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        //private async void OnLoginClicked(object sender, EventArgs e)
        //{            
        //    await Shell.Current.GoToAsync("//AppShell");            
        //}
    }
}