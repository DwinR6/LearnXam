using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CarouselView.ViewModels
{
    public class MainViewModel
    {
        public Command NavigateCommand { get; set; }
        public Type pageType { get; set; }
        public MainViewModel()
        {
            NavigateCommand = new Command<Type>(NavigatePage);
        }

        private async void NavigatePage(Type obj)
        {
            Page page = (Page)Activator.CreateInstance(obj);
            await App.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}
