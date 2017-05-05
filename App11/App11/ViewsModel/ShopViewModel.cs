using App11.Models;
using App11.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App11.ViewsModel
{
   public class ShopViewModel
    {
        private readonly Page _page;
        public ICommand OpenCategory { get; set; }
        public ICommand OpenTea { get; set; }
        public ObservableCollection<ShopModel> Shops { get; set; } = new ObservableCollection<ShopModel>
        {

            new ShopModel {Image = "el1.jpg", Title = "Сервизы",Pages="Stol"},
            new ShopModel {Image = "el.jpg", Title="Наборы",Pages="Nabors" },
            new ShopModel {Image = "el3.jpg",Title="Изделия на заказ",Pages="izdZakaz" }

        };
        public ShopViewModel(Page page)
        {
            _page = page;

            //  OpenStol = new Command(OpenStols);
            //OpenDetail = new Command(OpenDet);
            OpenCategory = new Command(async () =>
            {
                await _page.Navigation.PushAsync(new ServizePage());
            });
            OpenTea = new Command(async () =>
            {
                await _page.Navigation.PushAsync(new Kofeyniy());
            });

        }
    }
}
