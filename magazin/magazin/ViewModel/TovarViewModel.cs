using magazin.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using magazin.Views;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace magazin.ViewModel
{
    public class TovarViewModel 
    {
        public ObservableCollection<TovarModel> Tovar { get; set; } = new ObservableCollection<TovarModel>
        {
            new TovarModel
            {
                Name ="Бутсы Tiempo Legend 5",
                Price = "6000 руб",
                Image ="http://www.soccercleatsau.com.au/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/n/i/nike-tiempo-legend-wolf-grey-2016.jpg",

            }
        };
        public Command ExitCommand { get;  set; }

        private Page _page;

        public TovarViewModel(Page page)
        {
            _page = page;
            ExitCommand = new Command(Exit);
        }
        public async void Exit()
        {
           
            await _page.Navigation.PopToRootAsync();
        }
        public async Task OpenKartochka()
        {
            await _page.Navigation.PushAsync(new KartochkaPage());
        }
    }

}
