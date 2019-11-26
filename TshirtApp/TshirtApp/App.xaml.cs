using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TshirtApp
{
    public partial class App : Application
    {
        private static ShirtDatabase shirtsDatabase;


        public static ShirtDatabase ShirtsDb
        {

            get
            {
                if (shirtsDatabase == null)
                {
                    shirtsDatabase = new ShirtDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "shirts.db3"));
                }
                return shirtsDatabase;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LandingPage());
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
