﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;

namespace ArmySOF.Droid
{
    [Activity(Label = "ArmySOF", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            string fileName = "games_db.sqlite";
            string fileLocation = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string fullPath = Path.Combine(fileLocation, fileName);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            
            LoadApplication(new App(fullPath));
        }
    }
}

