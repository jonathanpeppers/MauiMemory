﻿using MauiMemory.Services;
using System.Diagnostics;

namespace MauiMemory
{
    public partial class MainPage : ContentPage
    {
        private readonly INavigationService _navigation;
        public MainPage(INavigationService navigation)
        {
            InitializeComponent();
            _navigation = navigation;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            var totalMemory = GC.GetTotalMemory(true);
            memTxt.Text = $"Memory: {totalMemory}";
        }

        private async void CounterBtn_Clicked(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            await _navigation.navigateToAsync(NavigationService.Page1);
        }

        private async void CounterBtn2_Clicked(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            await _navigation.navigateToAsync(NavigationService.Page2);
        }

        private async void CounterBtn3_Clicked(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            await _navigation.navigateToAsync(NavigationService.Page3);
        }
    }

}
