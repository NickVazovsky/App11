using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11.Models
{
    public class MainsModels 
    {
        private string Image;
        public string Image1;
        private string Title;
        private string Desc;
        private int Price;

        public string Images
        {

            get { return Image; }
            set
            {

                if (Image != value)
                {
                    Image = value;
                  

                }

            }
        }
        public string Images1
        {

            get { return Image1; }
            set
            {

                if (Image1 != value)
                {
                    Image1 = value;


                }

            }
        }
        public string Titles
        {
            get { return Title; }
            set
            {
                if (Title != value)
                {
                    Title = value;
                  

                }


            }
        }
        public string Descs
        {
            get { return Desc; }
            set
            {
                if (Desc != value)
                {
                    Desc = value;
                
                }

            }


        }
        public int Prices
        {
            get { return Price; }
            set {
                if (Price != value)
                {
                    Price = value;
              
    

            }

            }
       }
    
    }
}
