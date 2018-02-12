using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O365Mobile.ViewModels
{
    public class SignInViewModel : BaseViewModel
    {
        string profileName = "Please Sign In";
        public string ProfileName
        {
            get { return profileName; }
            set { SetProperty(ref profileName, value); }
        }

        string profileEmail = "";
        public string ProfileEmail
        {
            get { return profileEmail; }
            set { SetProperty(ref profileEmail, value); }
        }
    }
}
