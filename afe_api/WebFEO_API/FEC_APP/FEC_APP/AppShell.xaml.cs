﻿using FEC_APP.Services;
using FEC_APP.ViewModels;
using FEC_APP.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FEC_APP
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public string UsuarionNome => "Usuário Nome";
        public string UsuarioLogin => AppService.UsuarioRegistrado().Login;
        public string UsuarioTipo => AppService.UsuarioRegistrado().Tipo;

        public AppShell()
        {
            InitializeComponent();
            lbNome.Text = UsuarioLogin;
            lbTipo.Text = UsuarioTipo;
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
        private async void OnSairClicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("SAIR?", "Deseja realmente sair o aplicativo?", "OK", "Cancelar");
            if (result)
                await Xamarin.Essentials.SecureStorage.SetAsync("isLogged", "0");

            Application.Current.MainPage = new NavigationPage(new LoginPage());
            await Application.Current.MainPage.Navigation.PopToRootAsync();

        }
    }
}
