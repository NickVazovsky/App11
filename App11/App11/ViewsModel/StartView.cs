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
    public class StartView
    {
        private readonly Page _page;
        public ICommand OpenDetail { get; set; }
        public ICommand OpenEnter { get; set; }
        /* public static MasterDetailPage MasterDetail { get; set; }
         public async static Task NavigateMasterDetail(Page page)
         {

             await StartView.MasterDetail.Detail.Navigation.PushAsync(page);

         }*/
        public StartView(Page page)
        {
            _page = page;
            OpenDetail = new Command(OpenDet);
            OpenEnter = new Command(OpenEnt);
            NavigationPage.SetHasNavigationBar(page, false);
       
            /*    OpenDetail = new Command(async () =>
           {
               await _page.Navigation.PushAsync(new MasterPage());
           });*/
        }
        private void OpenDet()
        {

            var app = (App)Application.Current;
            app.MainPage = new MasterPage();

        }
        private void OpenEnt() {
            var app = (App)Application.Current;
            app.MainPage = new EnterPage();

        }
    }
    }
