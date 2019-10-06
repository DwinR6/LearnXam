using LearnXam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearnXam.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);    
        }

        async private void BtnLogIn_Clicked(object sender, EventArgs e)
        {
            LoginModel login = new LoginModel(EntryUser.Text, EntryPass.Text);
            
            if(login.Validate() == "")
            {
                await Navigation.PushAsync(new Menu());
            }
            else
            {
                LblError.Text = login.Validate();                
            }
           
        }

        private void EntryUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            LblError.Text = "";
        }
    }
}