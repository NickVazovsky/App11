using App11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App11.ViewsModel
{
  public  class PersoneViewModel
    {
        private readonly Page _page;
        public Persone Person = new Persone
        {
            Image = "Persone.png"

        };
        public string Image { get { return Person.Image; } }
        public PersoneViewModel(Page page) {
            _page = page;

        }
    }
}
