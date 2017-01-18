using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace magazin.ViewModel
{
    public class KartochkaViewModel 
    {
        public string Name { get; set; }

        public string Image { get; set; }

        public string Price { get; set; }

        public string Discription { get; set; }

        public ICommand ZakazCommand { get; set; }
    }
}
