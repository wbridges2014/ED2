using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace ChildAlert
{
    [Activity(Label = "Child Alert", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        //TextView welcomeText;
        Button pairButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Pair);

            //welcomeText = FindViewById<TextView>(Resource.Id.welcomeText);
            pairButton = FindViewById<Button>(Resource.Id.pairButton);

            pairButton.Click += OnPairButtonClick;
        }

        void OnPairButtonClick(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }
    }
}

