using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace ChildAlert
{
    [Activity(Label = "MainActivity")]
    public class MainActivity : Activity
    {
        TextView welcomeText;
        Button pingButton;
        Button locateButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            Initialize();

            pingButton.Click += OnPingButtonClick;
            locateButton.Click += OnLocateButtonClick;
        }

        void Initialize()
        {
            //welcomeText = FindViewById<TextView>(Resource.Id.welcomeText);
            pingButton = FindViewById<Button>(Resource.Id.pingButton);
            locateButton = FindViewById<Button>(Resource.Id.locateButton);
        }

        void OnPingButtonClick(object sender, EventArgs e)
        {
            welcomeText.Text = "*Beep*";
        }

        void OnLocateButtonClick(object sender, EventArgs e)
        {
            //welcomeText.Text = "*GPS Location*";
            StartActivity(typeof(LocationActivity));
        }
    }
}
