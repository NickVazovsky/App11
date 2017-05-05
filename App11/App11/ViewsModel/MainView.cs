using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App11.ViewsModel
{
    public class MainView
    {
        public ObservableCollection<MenuVIew> Menu { get; set; }
      
        public MainView()
        {
           Menu = new ObservableCollection<MenuVIew>();
            LoadMenu();
        }
        private void LoadMenu()
        {
            Menu.Add(new MenuVIew
            {
                Title = "Сервизы",
                PageName = "Servize"

            });
            Menu.Add(new MenuVIew
            {
                Title = "История",
                PageName = "History"

            });
            Menu.Add(new MenuVIew
            {
                Title = "Магазин",
                PageName = "Shop"

            });
            Menu.Add(new MenuVIew
            {
                Title = "Изделия на заказ",
                PageName = "Zakaz"

            });
            Menu.Add(new MenuVIew
            {
                Title = "Контакты",
                PageName = "Contact"

            });
            Menu.Add(new MenuVIew
            {
                Title = "Корзина",
                PageName = "Basket"

            });
            Menu.Add(new MenuVIew
            {
                Title = "Выйти",
                PageName = "Logout"

            });
        }


    }
}
