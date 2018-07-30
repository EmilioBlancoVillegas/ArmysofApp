using ArmySOF.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace ArmySOF
{
	public partial class App : Application
	{
        public static string DB_PATH = string.Empty;
        public App ()
		{
			InitializeComponent();

            MainPage = new LoginPage();
		}

        public App(string DB_Path)
        {
            InitializeComponent();

            DB_PATH = DB_Path;

            MainPage = new LoginPage();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
