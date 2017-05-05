using App11.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11.Infrastructure
{
    public class InstanceLocator
    {
        public MainView Main { get; set; }
        public InstanceLocator()
        {
            Main = new MainView();
        }
    }
 

}
