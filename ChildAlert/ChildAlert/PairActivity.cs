using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Bluetooth;

namespace ChildAlert
{
    [Activity(Label = "ChildAlert", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        TextView welcomeText;
        Button pairButton;
        Button bluetoothPair;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Pair);

            welcomeText = FindViewById<TextView>(Resource.Id.welcomeText);
            pairButton = FindViewById<Button>(Resource.Id.pairButton);
            bluetoothPair = FindViewById<Button>(Resource.Id.bluetoothPair);

            pairButton.Click += OnPairButtonClick;
            bluetoothPair.Click += OnBluetoothPairClick;
        }

        void OnPairButtonClick(object sender, EventArgs e)
        {
            StartActivity(typeof(MainAcitivty));
        }

        void OnBluetoothPairClick(object sender, EventArgs e)
        {
            //BluetoothAdapter.ActionRequestEnable();
            welcomeText.Text = "Request Enable";
        }

    }
}

