using App11.Models;
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
   public class CategoryViewModel
    {
        private Page _page;
        public ICommand OpenTov { get; set; }
        public ObservableCollection<CategoryModel> Categorys { get; set; } = new ObservableCollection<CategoryModel>
        {
            new CategoryModel {Image = "el1.jpg", Title="Столовые сервизы" },
            new CategoryModel {Image = "el.jpg", Title="Кофейные сервизы" },
            new CategoryModel {Image = "el3.jpg", Title="Чайные сервизы" }
        };
        public CategoryViewModel(Page page) {
            _page = page;

        }
    }
}
