﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics.Drawables;

namespace CardHolder_MobileApp.Droid
{
    [Activity(Label = "CardHolder_MobileApp", Icon = "@drawable/icon", 
        Theme = "@style/Theme.Material.Light.DarkActionBar", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());


            //ActionBar.SetIcon(
             // new ColorDrawable(Resources.GetColor(Android.Resource.Color.Transparent)));
        }
    }
}

