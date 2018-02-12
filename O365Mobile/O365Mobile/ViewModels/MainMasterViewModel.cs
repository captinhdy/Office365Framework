using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using O365Mobile.Models;
using O365Mobile.Views;
using System.IO;
using O365Mobile.Helpers;
using Xamarin.Forms;
using System.Net.Http;
using Microsoft.Graph;

namespace O365Mobile.ViewModels
{
    public class MainMasterViewModel : BaseViewModel
    {
        public ObservableCollection<MainMenuItem> MenuItems { get; set; }

        public MainMasterViewModel()
        {
            MenuItems = new ObservableCollection<MainMenuItem>(new[]
            {
                    new MainMenuItem { Id = 0, Title = "Home", TargetType= typeof(MainPage) },
                    new MainMenuItem { Id = 1, Title = "Intranet", TargetType=typeof(Intranet) },
                    new MainMenuItem { Id = 2, Title = "My Drive", TargetType=typeof(OneDrive) },
                    new MainMenuItem { Id = 3, Title = "Calendar", TargetType=typeof(CalendarEvents) },
                    new MainMenuItem { Id=4, Title= "My Tasks", TargetType=typeof(Tasks)},
                    new MainMenuItem { Id = 5, Title = "About", TargetType = typeof(AboutPage) },
                });
        }

        ImageSource profilePicture = "profile_generic.png";
        public ImageSource ProfilePicture
        {
            get { return profilePicture; }
            set{ SetProperty(ref profilePicture, value);}
        }

        string profileName = "Please Login";
        public string ProfileName
        {
            get { return profileName; }
            set { SetProperty(ref profileName, value); }
        }

        string iconSrc = "slideout.png";
        public string IconSrc
        {
            get { return iconSrc; }
            set { SetProperty(ref iconSrc, value); }
        }
        

        public async Task GetUserInfo()
        {
            var graphClient = AuthenticationHelper.GetAuthenticatedClient();
            var currentUserObject = await graphClient.Me.Request().GetAsync();
            ProfileName = currentUserObject.DisplayName;
            Stream photo = await graphClient.Me.Photo.Content.Request().GetAsync();
            ProfilePicture = ImageSource.FromStream(() => { return photo; });
            GetRootSite();
        }

        public async Task GetRootSite()
        {
            var graphClient = AuthenticationHelper.GetAuthenticatedClient();
            string requestUrlToGetSiteRootInfo = String.Format("{0}{1}", graphClient.Sites.Request().RequestUrl, "/root");
            HttpRequestMessage hrm = new HttpRequestMessage(HttpMethod.Get, requestUrlToGetSiteRootInfo);

            // Authenticate (add access token) to our HttpRequestMessage
            await graphClient.AuthenticationProvider.AuthenticateRequestAsync(hrm);

            HttpResponseMessage response = await graphClient.HttpProvider.SendAsync(hrm);

            Site site;
            if (response.IsSuccessStatusCode)
            {
                // Deserialize Site object.
                var content = await response.Content.ReadAsStringAsync();
                site = graphClient.HttpProvider.Serializer.DeserializeObject<Site>(content);
                MenuItems[1].Title = site.DisplayName;
            }
            
            
        }

    }
}
