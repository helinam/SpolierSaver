using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SpoilerSaverApp
{
    [Activity(Label = "SpoilerSaver", MainLauncher = true, Icon = "@drawable/spoilersaver")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            ImageView logo = FindViewById<ImageView>(Resource.Id.MyImage);
        }
    }
}

