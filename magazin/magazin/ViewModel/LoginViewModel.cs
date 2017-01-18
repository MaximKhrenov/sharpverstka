using magazin.Serves;
using magazin.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace magazin.ViewModel
{
    public class LoginViewModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public ICommand LoginCommand { get; set; }

        private Page _page;

        public LoginViewModel(Page page)
        {
            _page = page;
            LoginCommand = new Command(OpenTovar);
        }

        private async void OpenTovar()
        {
            var dataService = DataService.GetInstance();
            var status = await dataService.LoginAsync(UserName, Password);
            if (status == HttpStatusCode.OK)
            {
                var app = (App)Application.Current;
                app.MainPage = new NavigationPage(new TovarPage());
            }
            else
            {
                await _page.DisplayAlert("Ошибка", "Не удалось выполнить вход", "Закрыть");
            }

        }
    }
}