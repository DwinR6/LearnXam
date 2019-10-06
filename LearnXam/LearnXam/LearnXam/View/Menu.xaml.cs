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
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
            Master = new MenuMaster();
            Detail = new NavigationPage(new MenuDetail());
            App.MasterDetail = this;
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            
        }
    }
}