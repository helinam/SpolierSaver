using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SpoilerSaver;

namespace SpoilerSaverApp
{
    [Activity(Label = "SpoilerSaver", MainLauncher = true, Icon = "@drawable/spoilersaver")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            SetContentView(Resource.Layout.Main);

            ImageView logo = FindViewById<ImageView>(Resource.Id.MyImage);
            ImageButton book1 = FindViewById<ImageButton>(Resource.Id.imageButton1);
            ImageButton book2 = FindViewById<ImageButton>(Resource.Id.imageButton2);

            var imageButton1 = FindViewById<ImageButton>(Resource.Id.imageButton1);
            imageButton1.Click += (sender, e) => {
                StartActivity(typeof(gotButtonPage));
            };
        }
    }
}
