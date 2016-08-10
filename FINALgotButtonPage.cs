using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SpoilerSaver;

namespace SpoilerSaverApp
{
    [Activity(Label = "gotButtonPage")]
    public class gotButtonPage : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.gotButton);

            ImageView logo = FindViewById<ImageView>(Resource.Id.MyImage);
            ImageButton booktotv = FindViewById<ImageButton>(Resource.Id.booktotv);
            ImageButton backButton = FindViewById<ImageButton>(Resource.Id.backButton);
            backButton.Click += delegate { StartActivity(typeof(MainActivity)); };
            booktotv.Click += delegate { StartActivity(typeof(booktotvSwitch)); }; 
        }
    }
}
