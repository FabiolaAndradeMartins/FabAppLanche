﻿using FabAppLanche.Pages;
using FabAppLanche.Services;

namespace FabAppLanche
{
    public partial class App : Application
    {
        private readonly ApiService _apiService;

        public App(ApiService apiService)
        {
            InitializeComponent();
            _apiService = apiService;
            MainPage = new NavigationPage(new InscricaoPage(_apiService));

        }
    }
}
