using ArmySOF.MenuItems;
using ArmySOF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ArmySOF
{
	public partial class MainPage : MasterDetailPage
	{
        public List<MasterPageItem> menuList{ get; set; }
        public MainPage()
		{
			InitializeComponent();

            menuList = new List<MasterPageItem>();

            menuList.Add(new MasterPageItem { Title = "Inicio", Icon = "home.png", TargetType = typeof(HomePage) });
            menuList.Add(new MasterPageItem { Title = "Partidas", Icon = "announce.png", TargetType = typeof(GamesPage) });            
            menuList.Add(new MasterPageItem { Title = "Ajustes", Icon = "setting.png", TargetType = typeof(SettingsPage) });
            menuList.Add(new MasterPageItem { Title = "Desconectar", Icon = "logout.png", TargetType = typeof(LogoutPage) });

            navigationDrawerList.ItemsSource = menuList;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
	}
}
