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
	public partial class NewGamePage : ContentPage
	{
		public NewGamePage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string place = txtPlace.Text;
            string script = txtScript.Text;
            DateTime dt = DateTime.UtcNow;
            DateTime datePicked = date.Date;
            TimeSpan timePicked = time.Time;
            DateTime finalDate = new DateTime(datePicked.Year, datePicked.Month, datePicked.Day, timePicked.Hours, timePicked.Minutes, timePicked.Seconds);
            Game game = new Game
            {
                Name = name,
                Place = place,
                Date = finalDate,
                Script = script,
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Game>();
                int numRows = conn.Insert(game);
                if (numRows > 0)
                    DisplayAlert("Correcto", $"Nombre de la partida: {name} \nLugar de la partida: {place} \nFecha: {finalDate.ToString()}", "Correcto", "Cancelar");
                else
                    DisplayAlert("Error", "No se ha podido agregar la partida", "OK!");
            }
        }
    }
}