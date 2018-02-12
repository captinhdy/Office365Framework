//Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license.
//See LICENSE in the project root for license information.

using Microsoft.Identity.Client;
using O365Mobile.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace O365Mobile
{
    public class App : Application
    {
        public static PublicClientApplication IdentityClientApp = null;
        public static string ClientID = "842fbafb-90e3-49de-8b46-e6109dcb1c33";
        public static string RedirectUri = "msal" + ClientID + "://auth";
        public static string[] Scopes = { "User.Read", "Mail.Send","Files.Read", "Files.ReadWrite", "Files.Read.All", "Files.ReadWrite.All", "Calendars.Read", "Calendars.Read.Shared", "Sites.Read.All", "Sites.ReadWrite.All" };
        public static byte[] ProfilePicture = new byte[0];

        public static UIParent UiParent = null;
        public App()
        {
            IdentityClientApp = new PublicClientApplication(ClientID);
            MainPage = new Main();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
