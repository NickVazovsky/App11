using App11.Models;
using App11.ViewsModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App11.Views
{
  //  [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private MainsViews MainsViews;
         protected internal ObservableCollection<MainsModels> Mains { get; set; }
        public MainPage()
        {

            InitializeComponent();
            Mains = new ObservableCollection<MainsModels>
            {
                new MainsModels {Images = "cha11.gif",Images1 ="el.jpg",Titles = "Набор Подсолнухи",Descs = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",Prices =15000 },
            new MainsModels {Images = "el.jpg",Images1 ="el1.jpg", Titles = "Набор Какой-то",Descs = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",Prices = 13000 },
             new MainsModels {Images = "el1.jpg", Images1 ="cha11.gif",Titles = "Набор Какой-то 2",Descs = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",Prices =20000 }



            };
            
            ListView.BindingContext = Mains;
           
        }
        private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args) {

            MainsModels selectedMainsModels = args.SelectedItem as MainsModels;
            if (selectedMainsModels != null)
            {
                ListView.SelectedItem = null;
                await Navigation.PushAsync(new CardPage(selectedMainsModels));
            }
        }
    }
}
