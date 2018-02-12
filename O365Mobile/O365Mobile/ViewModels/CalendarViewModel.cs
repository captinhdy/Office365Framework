using O365Mobile.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using O365Mobile.Models;

namespace O365Mobile.ViewModels
{
    public class CalendarViewModel:BaseViewModel
    {
        public ObservableRangeCollection<Item> CalendarEvents { get; set; }
        public Command LoadEventsCommand { get; set; }
        public CalendarViewModel()
        {
            CalendarEvents = new ObservableRangeCollection<Item>();
            LoadEventsCommand = new Command(async () => await GetCalendarEvents());
        }
        async Task GetCalendarEvents()
        {
            try
            {
                List<Item> events = new List<Item>();
                IsBusy = true;
                CalendarEvents.Clear();
                var graphRequest = AuthenticationHelper.GetAuthenticatedClient();
                var sites = await graphRequest.Me.Calendar.Events.Request().GetAsync();
                foreach (var site in sites)
                {
                    events.Add(new Item()
                    {
                        Text = site.Subject,
                        Description = site.Start.DateTime
                    });
                }

                CalendarEvents.AddRange(events);
                IsBusy = false;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
    }
}
