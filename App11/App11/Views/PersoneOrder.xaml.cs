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
 //   [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersoneOrder : ContentPage
    {
        public PersoneOrder()
        {
            InitializeComponent();
            this.BindingContext = new PersoneViewModel(this);
        }
    }
}
