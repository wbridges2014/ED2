using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace ChildAlert
{
    [Activity(Label = "MainAcitivty")]
    public class Location : Activity
    {
        TextView welcomeText;
        Button pingButton;
        Button locateButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            // welcomeText = FindViewById<TextView>(Resource.Id.welcomeText);
            pingButton = FindViewById<Button>(Resource.Id.pingButton);
            locateButton = FindViewById<Button>(Resource.Id.locateButton);

            pingButton.Click += OnPingButtonClick;
            locateButton.Click += OnLocateButtonClick;
        }

        void OnPingButtonClick(object sender, EventArgs e)
        {
            welcomeText.Text = "*Beep*";
        }

        void OnLocateButtonClick(object sender, EventArgs e)
        {
            welcomeText.Text = "*GPS Location*";
            StartActivity(typeof(Location));
        }
    }
}
