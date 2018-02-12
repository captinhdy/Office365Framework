using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using O365Mobile.Helpers;
using O365Mobile.Models;
using System.Net.Http;
using Microsoft.Graph;
using Xamarin.Forms;

namespace O365Mobile.ViewModels
{
    public class ListViewModel:BaseViewModel
    {
        public ObservableRangeCollection<Item> SharePointLists { get; set; }
        public Command LoadListsCommand { get; set; }
        public ListViewModel()
        {
            SharePointLists = new ObservableRangeCollection<Item>();
            LoadListsCommand = new Command(async () => await GetLists());
        }

        private async Task GetLists()
        {
            try
            {
                IsBusy = true;
                List<Item> sharePointLists = new List<Item>();
                var graphClient = AuthenticationHelper.GetAuthenticatedClient();
                string requestUrlToGetSiteRootInfo = String.Format("{0}{1}", graphClient.Sites.Request().RequestUrl, "/root/lists?$filter=list/template eq 'documentLibrary'");
                HttpRequestMessage hrm = new HttpRequestMessage(HttpMethod.Get, requestUrlToGetSiteRootInfo);

                // Authenticate (add access token) to our HttpRequestMessage
                await graphClient.AuthenticationProvider.AuthenticateRequestAsync(hrm);

                HttpResponseMessage response = await graphClient.HttpProvider.SendAsync(hrm);

                if (response.IsSuccessStatusCode)
                {
                    // Deserialize Site object.
                    var content = await response.Content.ReadAsStringAsync();
                    var lists = graphClient.HttpProvider.Serializer.DeserializeObject<SiteListsCollectionResponse>(content);

                    foreach (var list in lists.Value)
                    {
                        sharePointLists.Add(new Item()
                        {
                            Text = list.DisplayName,
                            Description = list.Description
                        });
                    }

                }

                SharePointLists.AddRange(sharePointLists);

                IsBusy = false;
            }
            catch(Exception ex)
            {
                var msg = ex.Message;
                IsBusy = false;
            }
        }
    }
}
