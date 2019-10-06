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
    public partial class MenuMaster : ContentPage
    {
        public MenuMaster()
        {
            InitializeComponent();
            var masterPageItems = new List<MasterPageItem>();

            masterPageItems.Add(new MasterPageItem
            {
                Title = "Calculadoras",
                TargetType = typeof (Calculadoras)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Calculadoras",
                TargetType = typeof(Calculadoras)
            });

            LvOptions.ItemsSource = masterPageItems;

            

        }

        private void LvOptions_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if(item != null)
            {
                App.MasterDetail.Detail.Navigation.PushAsync((Page)Activator.CreateInstance(item.TargetType));

                LvOptions.SelectedItem = null;
                App.MasterDetail.IsPresented = false;
            }

        }
    }
}