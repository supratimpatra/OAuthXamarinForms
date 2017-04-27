using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Auth;

namespace OAuthXamarinForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Appearing += InitializeOauth;
        }

        private void InitializeOauth(object sender, EventArgs e)
        {
            new OAuth2Authenticator()
        }
    }
}
