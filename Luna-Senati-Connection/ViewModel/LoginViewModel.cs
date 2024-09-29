using LunaSenatiConnection.Views;
using System.Windows.Input;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LunaSenatiConnection.ViewModel
{
	public class LoginViewModel : BaseViewModel
	{
        private string _email;
        private string _password;

        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked()
        {
            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Debe completar los campos", "OK");
                return;
            }

            await Application.Current.MainPage.Navigation.PushAsync(new MainPage());
        }
    }
}
