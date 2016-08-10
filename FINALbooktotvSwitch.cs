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
    [Activity(Label = "SpoilerSaver")]

public class booktotvSwitch : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            SetContentView(Resource.Layout.booktotv);
            
            ImageView logo = FindViewById<ImageView>(Resource.Id.MyImage);
            SeekBar _seekBar = FindViewById<SeekBar>(Resource.Id.seekBar1);
            TextView episode = FindViewById<TextView>(Resource.Id.textView1);
            TextView chapterNumber = FindViewById<TextView>(Resource.Id.chapterNumber);
            ImageButton backButton = FindViewById<ImageButton>(Resource.Id.backButton);
            backButton.Click += delegate { StartActivity(typeof(gotButtonSwitch)); };

            _seekBar.ProgressChanged += (object sender, SeekBar.ProgressChangedEventArgs e) => {
                string str;
                if (e.FromUser)
                {
                    if (e.Progress < 11)
                    {
                        str = GetString(Resource.String.Group_1);
                    }
                    else if (e.Progress >= 11 && e.Progress < 23)
                    {
                        str = GetString(Resource.String.Group_2);
                      }
                    else if (e.Progress >= 23 && e.Progress < 36)
                    {
                        str = GetString(Resource.String.Group_3);
                    }
                    else if (e.Progress >= 36 && e.Progress < 50)
                    {
                        str = GetString(Resource.String.Group_4);
                    }
                    else if (e.Progress >= 50 && e.Progress < 54)
                    {
                        str = GetString(Resource.String.Group_5);
                   }
                    else if (e.Progress >= 54 && e.Progress < 61)
                    {
                        str = GetString(Resource.String.Group_6);
                  }
                    else if (e.Progress >= 61 && e.Progress < 65)
                    {
                        str = GetString(Resource.String.Group_7);
                 }
                    else if (e.Progress == 65)
                    {
                        str = GetString(Resource.String.Group_8);
                  }
                    else
                    {
                        str = GetString(Resource.String.Group_9);
                   }
                    string number = e.Progress.ToString();
                    _seekBar.ProgressChanged += delegate { chapterNumber.Text = number; };
                    _seekBar.ProgressChanged += delegate { episode.Text = str; };
                }
            };
        }
    }
}
