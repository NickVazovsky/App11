using App11.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App11
{
    public partial class App : Application
    {
        internal static MasterPage Master;

        public static NavigationPage Navigator { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EnterPage());
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
