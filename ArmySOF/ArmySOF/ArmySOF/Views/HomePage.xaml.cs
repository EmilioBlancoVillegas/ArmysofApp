using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArmySOF.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
            webView.Source = "http://www.armysof.es/";

        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            if (webView.CanGoBack)
                webView.GoBack();
            else
                this.Navigation.PopAsync();
        }

        private void ForwardButton_Clicked(object sender, EventArgs e)
        {
            if (webView.CanGoForward)
                webView.GoForward();            
        }
    }
}