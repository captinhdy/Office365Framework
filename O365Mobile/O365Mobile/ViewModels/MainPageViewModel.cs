using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using O365Mobile.Helpers;
using O365Mobile.Models;
using Xamarin.Forms;
using System.Net.Http;
using Microsoft.Graph;

namespace O365Mobile.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ObservableRangeCollection<TrendingItem> SharePointSites { get; set; }
        public Command LoadCardsCommand { get; set; }
        public MainPageViewModel()
        {
            SharePointSites = new ObservableRangeCollection<TrendingItem>();
            LoadCardsCommand = new Command(async () => await GetCards());
        }
        public async Task GetCards()
        {
            try
            {
                List<TrendingItem> items = new List<TrendingItem>();
                IsBusy = true;
                SharePointSites.Clear();

                var graphClient = AuthenticationHelper.GetAuthenticatedClient();
                string requestUrlToGetSiteRootInfo = String.Format("{0}{1}", "https://graph.microsoft.com/beta/me", "/insights/trending");
                HttpRequestMessage hrm = new HttpRequestMessage(HttpMethod.Get, requestUrlToGetSiteRootInfo);

                // Authenticate (add access token) to our HttpRequestMessage
                await graphClient.AuthenticationProvider.AuthenticateRequestAsync(hrm);

                HttpResponseMessage response = await graphClient.HttpProvider.SendAsync(hrm);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var insites = graphClient.HttpProvider.Serializer.DeserializeObject<TrendingInsights>(content);
                    for(var i = 0; i < insites.value.Length; i++)
                    {
                        var site = insites.value[i];
                        var item = new TrendingItem()
                        {
                            Text = site.resourceVisualization.title,
                            Description = site.resourceVisualization.previewText,
                            Id = site.resourceVisualization.previewImageUrl,
                            PreviewImage = new Xamarin.Forms.Image() { Source = site.resourceVisualization.previewImageUrl }
                        };

                        item.PreviewImage = await GetPreviewImage(graphClient, site.resourceVisualization.previewImageUrl);
                        items.Add(item);
                    }

                    SharePointSites.AddRange(items);
                }
                IsBusy = false;
            }
            catch(Exception ex)
            {
                var msg = ex.Message;
            }
        }

        private async Task<Xamarin.Forms.Image> GetPreviewImage(GraphServiceClient graphClient, string ImageUrl)
        {
            int crop_x = 0;
            int crop_y = 0;
            int width = 160;
            int height = 160;
            try
            {

                Xamarin.Forms.Image img = new Xamarin.Forms.Image();

                string requestUrlToGetSiteRootInfo = String.Format("{0}{1}", graphClient.Sites.Request().RequestUrl, "/root/drive/root:" + ImageUrl);
                HttpRequestMessage hrm = new HttpRequestMessage(HttpMethod.Get, requestUrlToGetSiteRootInfo);

                // Authenticate (add access token) to our HttpRequestMessage
                await graphClient.AuthenticationProvider.AuthenticateRequestAsync(hrm);

                HttpResponseMessage response = await graphClient.HttpProvider.SendAsync(hrm);
                if (response.IsSuccessStatusCode)
                {
                    
                        // Deserialize Site object.
                        var content = await response.Content.ReadAsStringAsync();
                        var file = graphClient.HttpProvider.Serializer.DeserializeObject<DriveItem>(content);
                    img.Source = "";
                    img.WidthRequest = width;
                    img.HeightRequest = height;
                }

                return img;
            }
            catch(Exception ex)
            {
                var msg = ex.Message;
                return null;
            }
        }
    }
}
