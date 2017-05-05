using App11.Models;
using App11.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App11.Views
{

   // [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShopPage : ContentPage
    {
        private ShopViewModel ShopViewModel;
        public ShopPage()
        {
            InitializeComponent();
            ShopViewModel = new ShopViewModel(this);
            ListViews.ItemsSource = ShopViewModel.Shops;
        
            this.BindingContext = ShopViewModel;

         

        }
       
        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var shopModel = (ShopModel)e.Item;
            switch (shopModel.Pages)
            {
                case "Stol":
                    ShopViewModel.OpenCategory.Execute(null); ;
                    break;
                case "Nabors":
                    ShopViewModel.OpenTea.Execute(null); ;
                    break;
            } /*здесь создается ассоциативный массив с ключом кеу и значением */


            
        }
    }
}
