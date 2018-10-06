using System;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace ChildAlert
{
    [Activity(Label = "MainActivity")]
    public class MainActivity : Activity
    {
        TextView maintext;
        Button alertButton;
        Button locationButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Pair);

            maintext = FindViewById<TextView>(Resource.Id.mainText);
            alertButton = FindViewById<Button>(Resource.Id.alertButton);
            locationButton = FindViewById<Button>(Resource.Id.locationButton);

            alertButton.Click += OnAlertButtonClick;
            locationButton.Click += OnLocationButtonClick;
        }

        void OnAlertButtonClick(object sender, EventArgs e)
        {

            maintext.Text = "*Beep*";
        }

        void OnLocationButtonClick(object sender, EventArgs e)
        {
            maintext.Text = "*Location*";

            /*GPS location is shown
             * moves into GPS view
             */
        }
    }
}
