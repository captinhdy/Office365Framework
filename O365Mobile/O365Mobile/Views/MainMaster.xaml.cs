using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using O365Mobile.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using O365Mobile.ViewModels;

namespace O365Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMaster : ContentPage
    {
        public ListView ListView;
        MainMasterViewModel viewModel;

        public MainMaster()
        {
            InitializeComponent();
        }
        public MainMaster(MainMasterViewModel ViewModel)
        {
            InitializeComponent();
            viewModel = ViewModel;
            BindingContext = viewModel;
            ListView = MenuItemsListView;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }
    }
}