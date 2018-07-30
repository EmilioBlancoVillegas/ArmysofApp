using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressPCL;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArmySOF.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            var client = new WordPressClient("http://www.armysof.es/wp-json/");
            string uri = client.WordPressUri;
            client.AuthMethod = WordPressPCL.Models.AuthMethod.JWT;
            string user = txtUsr.Text;
            string password = txtPwd.Text;
            client.RequestJWToken(user, password).GetAwaiter().GetResult();
            var isValidToken = client.IsValidJWToken().GetAwaiter().GetResult();
            if (isValidToken)
            {
                Application.Current.Properties["Token"] = client.GetToken();
                Application.Current.MainPage = new MainPage();
            }
        }
    }
}