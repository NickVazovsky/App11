using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App11.ViewsModel
{
   public class MenuVIew
    {
        private NavigationService navigationService;
        public string Title { get; set; }
        public string PageName { get; set; }
        public MenuVIew() {
            navigationService = new NavigationService();
            
        }
        public ICommand NavigateCommand { get { return new RelayCommand(Navigate); } }

        private async void Navigate()
        {
            await navigationService.Navigate(PageName);


        }
    }
    
}
