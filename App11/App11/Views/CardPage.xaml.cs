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
    public partial class CardPage : ContentPage
    {
        
       
        public MainsModels MainsModels { get; set; }
        public CardPage(MainsModels MainsModels)
        {
            MainsModels = MainsModels;
            InitializeComponent();
            this.BindingContext = MainsModels;
            carousel.ItemSource = MainsModels;
        }
        private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {


            if (header != null)
            {
                header.Text = String.Format("Количество: {0}", e.NewValue);
                
            }
          // var valuePrice = price + price;
           

        }

    }
}
