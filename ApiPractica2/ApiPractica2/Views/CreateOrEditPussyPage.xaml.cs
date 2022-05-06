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
    public partial class CreateOrEditPussyPage : ContentPage
    {
        bool IsNewCat { get; set; }
        public CreateOrEditPussyPage(bool isNewCat = true)
        {
            InitializeComponent();
            IsNewCat = isNewCat;
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var CatItem = (CatModel)BindingContext;
            await App.CatManager.SaveItemAsync(CatItem, IsNewCat);
            await Navigation.PopAsync();
        }

        private async void DeleteButton_Clicked(object sender, EventArgs e)
        {
            var CatItem = (CatModel)BindingContext;
            await App.CatManager.DeleteTodoAsync(CatItem);
            await Navigation.PopAsync();
        }

    }
}