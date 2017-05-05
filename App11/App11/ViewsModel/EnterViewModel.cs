using App11.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App11.ViewsModel
{
    public class EnterViewModel
    {
        private readonly Page _page;
        public ICommand OpenDetail { get; set; }
        public ICommand OpenEnter { get; set; }

        public EnterViewModel(Page page)
        {
            _page = page;
            OpenDetail = new Command(OpenDet);
            OpenEnter = new Command(OpenEnt);
            NavigationPage.SetHasNavigationBar(page, false);
        }
        private void OpenDet()
        {

            var app = (App)Application.Current;
            app.MainPage = new StartPage();

        }
        private void OpenEnt()
        {
            var app = (App)Application.Current;
            app.MainPage = new MasterPage();

        }
    }
}