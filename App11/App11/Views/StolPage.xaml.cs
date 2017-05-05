using App11.ViewsModel;
using DLToolkit.Forms.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App11.Views
{
    //  [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StolPage : ContentPage
    {
        StolViewModel StolViewModel;

        public StolPage()
        {
            FlowListView.Init();
            InitializeComponent();
            StolViewModel = new StolViewModel(this);
            flowListView.ItemsSource = StolViewModel.Stols;
            this.BindingContext = StolViewModel;
        }
        private void ItemTappedCommand(object sender, ItemTappedEventArgs e)
        {
           // flowListView.FlowTappedBackgroundColor("Black");
            StolViewModel.OpenCards.Execute(null);
        }
        
    }
}
