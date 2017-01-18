using magazin.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace magazin.Views
{
    public partial class KartochkaPage : ContentPage
    {
        public KartochkaPage()
        {
            InitializeComponent();
            this.BindingContext = new KartochkaViewModel();
        }
    }
}
