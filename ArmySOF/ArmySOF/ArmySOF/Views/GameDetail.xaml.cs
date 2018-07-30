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
	public partial class GameDetail : ContentPage
	{
        public Game Game { get; set; }
        public GameDetail()
        {
            InitializeComponent();
        }
        public GameDetail (Game game)
		{
			InitializeComponent ();
            this.Game = game;
            this.BindingContext = this.Game;

        }

        private void btnGo_Clicked(object sender, EventArgs e)
        {

        }

        private void btnTemporal_Clicked(object sender, EventArgs e)
        {

        }
    }
}