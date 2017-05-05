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
   // [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServizePage : ContentPage
    {
       private  ServizeView ServizeView;
        public ServizePage()
        {
            
            InitializeComponent();
            ServizeView = new ServizeView(this);
            ListView.ItemsSource = ServizeView.Serviz;
       
            this.BindingContext = ServizeView;
        }
       /* public void FlowScrollTo(object item)
        {
            flowListView.FlowScrollTo(item, ScrollToPosition.MakeVisible, true);
        }*/
          private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
           {

               ServizeView.OpenStol.Execute(null);
           }
    }
}
