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
    
    public class MainsViews

    {
        private readonly Page _page;
        public ICommand OpenCard { get; set; }
    /*   public ObservableCollection<MainsModels> pop { get; set; } = new ObservableCollection<MainsModels>
        {
            new MainsModels {Image = "cha11.gif",Title = "Набор Подсолнухи",Desc = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",Price ="13000 рублей" },
            new MainsModels {Image = "el.jpg",Title = "Набор Какой-то",Desc = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",Price ="13000 рублей" },
             new MainsModels {Image = "el1.jpg",Title = "Набор Какой-то 2",Desc = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",Price ="13000 рублей" }
          
        };*/

        public MainsViews(Page page) {

            _page = page;
           
        
        }
     

    }
}
