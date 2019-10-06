using LearnXam.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearnXam
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterDetail { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
