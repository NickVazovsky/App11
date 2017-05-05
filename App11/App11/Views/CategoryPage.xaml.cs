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
    public partial class CategoryPage : ContentPage
    {
        private readonly CategoryViewModel CategoryViewModel;
        public CategoryPage()
        {
            InitializeComponent();
            CategoryViewModel = new CategoryViewModel(this);
            ListViewz.ItemsSource = CategoryViewModel.Categorys;
            this.BindingContext = CategoryViewModel;
        }
        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {

            CategoryViewModel.OpenTov.Execute(null);
        }
    }
}
