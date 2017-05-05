using App11.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App11.ViewsModel
{
    public class CardView
    {
        private readonly Page _page;

      
       
     /*   CardModel cards = new CardModel
        {
            Image = "cha11.gif",
            Title = "Набор чайный Кофейный",
            Desc = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
            Price = 13000,
        };

        public string Image { get { return cards.Image; } }
        public string Title { get { return cards.Title; } }
        public string Desc { get { return cards.Desc; } }
        public int Price { get { return cards.Price; } }
        */
 

        public  CardView(Page page) {
            _page = page;


        }

    }
}
