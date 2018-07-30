using ArmySOF.Classes;
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
	public partial class GamesPage : ContentPage
	{
		public GamesPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ReadFromDataBase();
        }

        private void ReadFromDataBase()
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Game>();
                var games = conn.Table<Game>().ToList();
                gamesListView.ItemsSource = games;
            }
        }

        private void TlbCreateGame_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewGamePage());
        }

        private void TextCell_Tapped(object sender, EventArgs e)
        {
            TextCell cell = (TextCell)sender;
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                Game g = conn.Table<Game>().Where(x => x.Name == cell.Text).FirstOrDefault();
                if (g != null)
                    Navigation.PushAsync(new GameDetail(g));
            }
        }
    }
}