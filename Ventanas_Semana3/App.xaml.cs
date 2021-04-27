using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ventanas_Semana3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            ///login
            MainPage = new  NavigationPage(new Login());
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
