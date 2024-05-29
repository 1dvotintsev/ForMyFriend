using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;
using Xamarin.Forms;

namespace App2
{
    public class AppShellViewModel
    {
        public ICommand SignOutCommand { get => new Command(async () => await SignOut()) ;}

        private async Task SignOut()
        {
            await Shell.Current.DisplayAlert("todo", "you have been logged out.", "Ok");
        }
    }
}
