using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppExer2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //evitando de crashar
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
