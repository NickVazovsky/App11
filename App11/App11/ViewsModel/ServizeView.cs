using App11.Models;
using App11.Views;
using DLToolkit.Forms.Controls;
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
   public class ServizeView
    {
        private readonly Page _page;
        public ICommand OpenStol { get; set; }
     
        public ObservableCollection<ServizeModel> Serviz = new ObservableCollection<ServizeModel>
                    {

                        new ServizeModel {Image = "el1.jpg", Title = "Столовые сервизы"},
                        new ServizeModel {Image = "el.jpg", Title="Чайные сервизы" },
                        new ServizeModel {Image = "el3.jpg",Title="Кофейные сервизы" }

                    };
        public ServizeView(Page page) {
            _page = page;

         /*   var value = (string)Application.Current.Properties["key"];
            switch (value)
            {
                case "":
                    Serviz = new ObservableCollection<ServizeModel>
                    {

                        new ServizeModel {Image = "el1.jpg", Title = "Столовые сервизы"},
                        new ServizeModel {Image = "el.jpg", Title="Чайные сервизы" },
                        new ServizeModel {Image = "el3.jpg",Title="Кофейные сервизы" }

                    };
                    break;
            }Здесь мы принимаем этот массив с ключом кеу и создаем свитч со значением*/
          
            //  OpenStol = new Command(OpenStols);
            //OpenDetail = new Command(OpenDet);
            OpenStol = new Command(async () =>
            {
                await _page.Navigation.PushAsync(new StolPage());
            });


        }
       /* public async void OpenStols() {


        }*/
    }
}
