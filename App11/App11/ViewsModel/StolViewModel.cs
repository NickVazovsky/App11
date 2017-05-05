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
    public class StolViewModel
    {
        public ICommand OpenCards { get; set; }
        private readonly Page _page;
        public ICommand ItemTappedCommand { get; set; }
        public ObservableCollection<StolModel> Stols { get; set; } = new ObservableCollection<StolModel>
        {
            new StolModel {Images = "el1.jpg", nameImages="Столовый сервиз1", Price="13000 рублей"},
            new StolModel {Images = "el.jpg", nameImages="Столовый сервиз2", Price="13000 рублей"},
            new StolModel {Images = "el3.jpg", nameImages="Столовый сервиз3", Price="13000 рублей"}

        };
        public  StolViewModel(Page page) {
            _page = page;

            ItemTappedCommand = new Command(async () =>
            {
                await _page.Navigation.PushAsync(new HistoryPage());
            });

        }
    }
}
