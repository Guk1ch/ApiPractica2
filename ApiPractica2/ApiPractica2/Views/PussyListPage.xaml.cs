using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiPractica2.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApiPractica2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PussyListPage : ContentPage
    {
        public PussyListPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            CatLV.ItemsSource = await App.CatManager.GetCatItemModels();
        }

        private void CatLV_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new CreateOrEditPussyPage(false)
            {
                BindingContext = e.SelectedItem as CatModel
            });
        }
        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateOrEditPussyPage()
            {
                BindingContext = new CatModel()
                {
                    Id = Guid.NewGuid().ToString(),
                }
            });
        }

    }
}