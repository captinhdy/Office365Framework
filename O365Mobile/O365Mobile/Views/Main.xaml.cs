using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using O365Mobile.Models;
using O365Mobile.Views;
using O365Mobile.ViewModels;
using Microsoft.Graph;

namespace O365Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Main : MasterDetailPage
    {
        MainMasterViewModel mainMasterViewModel;
        SignInViewModel signInViewModel;
        MainMaster masterPage;
        public Main()
        {
            LoginUser().Wait();
            InitializeComponent();
            mainMasterViewModel = new MainMasterViewModel();
            
            masterPage = new MainMaster(mainMasterViewModel);
            masterPage.ListView.ItemSelected += ListView_ItemSelected;
            Master = masterPage;

            IsPresentedChanged += Main_IsPresentedChanged;

            
        }

        protected override void OnAppearing()
        {
            Task t = mainMasterViewModel.GetUserInfo();
            
            t.ContinueWith(task=>
            {
                masterPage.ListView.SelectedItem = mainMasterViewModel.MenuItems[0];
            }, TaskScheduler.FromCurrentSynchronizationContext()); 
            
        }

        
        private void Main_IsPresentedChanged(object sender, EventArgs e)
        {
            if (IsPresented)
            {
                mainMasterViewModel.IconSrc = "";
            }
            else
            {
                mainMasterViewModel.IconSrc = "slideout.png";
            }
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var item = e.SelectedItem as MainMenuItem;
                if (item == null)
                    return;

                var page = (Page)Activator.CreateInstance(item.TargetType);
                page.Title = item.Title;

                Detail = new NavigationPage(page);
                IsPresented = false;

                masterPage.ListView.SelectedItem = null;
            }
            catch(Exception ex)
            {
                var exception = ex.Message;
            }
        }
        
        private async Task LoginUser()
        {
            AuthenticationHelper.GetAuthenticatedClient();
            
        }
    }
}