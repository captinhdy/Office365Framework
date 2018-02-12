using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using O365Mobile.ViewModels;

namespace O365Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        MainPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            viewModel = new MainPageViewModel();
            this.BindingContext = viewModel;
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.LoadCardsCommand.Execute(null);
        }
    }
}