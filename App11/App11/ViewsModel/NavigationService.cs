using App11.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11.ViewsModel
{
    public class NavigationService
    {
        public async Task Navigate(string PageName) {

            App.Master.IsPresented =  false;
            switch(PageName)
            {
                case "Servize":
                await App.Navigator.PushAsync(new ServizePage());
                    break;
                case "History":
                    await App.Navigator.PushAsync(new HistoryPage());
                    break;
                case "Shop":
                    await App.Navigator.PushAsync(new ShopPage());
                    break;
                case "Zakaz":
                    await App.Navigator.PushAsync(new PersoneOrder());
                    break;
                case "Contact":
                    await App.Navigator.PushAsync(new Kofeyniy());
                    break;
                case "Logout":
                    await App.Navigator.PushAsync(new Kofeyniy());
                    break;
                default:
                    break;

            }


        }
    }
}
