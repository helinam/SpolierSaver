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
            ImageButton book1 = FindViewById<ImageButton>(Resource.Id.imageButton1);
            ImageButton book2 = FindViewById<ImageButton>(Resource.Id.imageButton2);
            ImageButton book3 = FindViewById<ImageButton>(Resource.Id.imageButton3);
            ImageButton book4 = FindViewById<ImageButton>(Resource.Id.imageButton4);
            ImageButton book5 = FindViewById<ImageButton>(Resource.Id.imageButton5);
            ImageButton book6 = FindViewById<ImageButton>(Resource.Id.imageButton6);
            ImageButton book_tv1 = FindViewById<ImageButton>(Resource.Id.booktotv1);
            ImageButton tv_book1 = FindViewById<ImageButton>(Resource.Id.tvtobook1);
            book1.Click += delegate { SetContentView(Resource.Layout.options1); };
            book2.Click += delegate { SetContentView(Resource.Layout.options2); };
            book_tv1.Click += delegate { SetContentView(Resource.Layout.book_tv1); };
            tv_book1.Click += delegate { SetContentView(Resource.Layout.tv_book1); };

            SeekBar _seekBar = FindViewById<SeekBar>(Resource.Id.seekBar1);
            TextView episode = FindViewById<TextView>(Resource.Id.textView1);

            _seekBar.ProgressChanged += (object sender, SeekBar.ProgressChangedEventArgs e) => {
                if (e.FromUser)
                {
                    if (e.Progress < 11)
                    {
                        _seekBar.ProgressChanged += delegate { episode.Text = "android:@string/Group_1"; };
                    }
                    else if (e.Progress >= 11 && e.Progress < 23){
                        _seekBar.ProgressChanged += delegate { episode.Text = "android:@string/Group_2"; };
                    }
                    else if (e.Progress >=23 && e.Progress < 36)
                    {
                        _seekBar.ProgressChanged += delegate { episode.Text = "android:@string/Group_3"; };
                    }
                    else if (e.Progress >= 36 && e.Progress < 50)
                    {
                        _seekBar.ProgressChanged += delegate { episode.Text = "android:@string/Group_4"; };
                    }
                    else if (e.Progress >= 50 && e.Progress < 54)
                    {
                        _seekBar.ProgressChanged += delegate { episode.Text = "android:@string/Group_5"; };
                    }
                    else if (e.Progress >= 54 && e.Progress < 61)
                    {
                        _seekBar.ProgressChanged += delegate { episode.Text = "android:@string/Group_6"; };
                    }
                    else if (e.Progress >= 61 && e.Progress < 65)
                    {
                        _seekBar.ProgressChanged += delegate { episode.Text = "android:@string/Group_7"; };
                    }
                    else if (e.Progress == 65)
                    {
                        _seekBar.ProgressChanged += delegate { episode.Text = "android:@string/Group_8"; };
                    }
                    else
                    {
                        _seekBar.ProgressChanged += delegate { episode.Text = "android:@string/Group_9"; };
                    }
                }
            };
        }
    }
}
