using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.Identity.Client;
using Xamarin.Forms.Platform.Android;
using O365Mobile;
using Xamarin.Forms;
using O365Mobile.Droid;
using O365Mobile.Views;
using System;

[assembly: ExportRenderer(typeof(SignIn), typeof(MainPageRenderer))]
namespace O365Mobile.Droid
{
    class MainPageRenderer : PageRenderer
    {
        SignIn page;

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            try
            {
                base.OnElementChanged(e);
                page = e.NewElement as SignIn;
                var activity = this.Context as Activity;
            }
            catch(Exception ex)
            {

                var err = ex.Message;
            }
        }

    }
}