﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppExer2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageJogo : ContentPage
    {
        public PageJogo()
        {
            InitializeComponent();
            Random r = new Random();
            int n = r.Next(1, 3);
            if (n == 1)
            {
                imgMoeda.Source = "moeda_cara";
            }
            else
            {
                imgMoeda.Source = "moeda_coroa";
            }
        }

        private async void btVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}