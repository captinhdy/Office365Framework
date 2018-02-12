using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.Graph;
using O365Mobile;
using System.IO;
using O365Mobile.ViewModels;
using O365Mobile.Helpers;

namespace O365Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignIn : ContentPage
    {
        private static GraphServiceClient graphClient = null;
        SignInViewModel viewModel;

        public SignIn()
        {
            InitializeComponent();
        }

        public SignIn(SignInViewModel ViewModel)
        {
            InitializeComponent();
            viewModel = ViewModel;
            this.BindingContext = viewModel;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                graphClient = AuthenticationHelper.GetAuthenticatedClient();
                var currentUserObject = await graphClient.Me.Request().GetAsync();
                viewModel.ProfileName = currentUserObject.DisplayName;
                viewModel.ProfileEmail = currentUserObject.UserPrincipalName;
                
            }
            catch(Exception ex)
            {
                await DisplayAlert("Error connecting to O365", ex.Message, "Close");
            }
        }
    }
}