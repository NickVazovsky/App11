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
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {

        public StartPage()
        {
            InitializeComponent();
            this.BindingContext = new StartView(this);
       
            // this.NavigationController.NavigationBar.BarTintColor = UIColor.Yellow;
        }
        /*
         <StackLayout HorizontalOptions="Center"
                 VerticalOptions="Center">
        <Label Text="Ваше имя:"
               HorizontalOptions="Center"
               VerticalOptions="Center"/>
        <Entry Placeholder="...."
               HorizontalOptions="FillAndExpand"
               VerticalOptions="FillAndExpand"/>
        <Label Text="Ваш Email:"
               HorizontalOptions="Center"
               VerticalOptions="Center"/>
        <Entry Placeholder="...."
               HorizontalOptions="FillAndExpand"
               VerticalOptions="FillAndExpand"/>
        <Label Text="Введите пароль:"
               HorizontalOptions="Center"
               VerticalOptions="Center"/>
        <Entry Placeholder="...."
               HorizontalOptions="FillAndExpand"
               VerticalOptions="FillAndExpand"
               IsPassword="True"/>
        <Button Text="Зарегестрироваться"
                HorizontalOptions="Center"
                VerticalOptions="Center"
                BorderRadius="15"/>
        <Button  Text="Войти"
                BorderRadius="15"
                Command="{Binding OpenDetail}"/>
    </StackLayout>
    */
    }
}
