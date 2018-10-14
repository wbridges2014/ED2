using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Bluetooth;



namespace ChildAlert
{
    [Activity(Label = "MainAcitivty")]
    public class MainAcitivty : Activity

    {
        TextView welcomeText;
        Button beepButton;
        Button locationButton;
        Android.Media.ToneGenerator toneG;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            initialize();

            beepButton.Click += OnBeepButtonClick;
            locationButton.Click += OnLocationButtonClick;

        }

        void initialize()
        {
            welcomeText = FindViewById<TextView>(Resource.Id.welcomeText);
            beepButton = FindViewById<Button>(Resource.Id.beepButton);
            locationButton = FindViewById<Button>(Resource.Id.locationButton);
        }

        void OnBeepButtonClick(object sender, EventArgs e)
        {
            toneG = new Android.Media.ToneGenerator(Android.Media.Stream.Alarm, 500);
            toneG.StartTone(Android.Media.Tone.CdmaAlertCallGuard);
        }

        void OnLocationButtonClick(object sender, EventArgs e)
        {
            StartActivity(typeof(LocateActivity));
        }

    }
}
