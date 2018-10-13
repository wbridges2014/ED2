using Android.App;
using Android.Widget;
using Android.OS;
using Android.Bluetooth;
using Android.Views;
using System;
using Android.Content;
using System.Collections;
using System.Collections.Generic;


namespace ChildAlert
{
    [Activity(Label = "ChildAlert", MainLauncher = true, Icon = "@mipmap/icon")]
    public class PairActivity : Activity
    {
        TextView welcomeText;
        Button pairButton;
        Button bluetoothEnable;
        BluetoothAdapter bt;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Pair);

            initialize();

            pairButton.Click += OnPairButtonClick;
            bluetoothEnable.Click += OnBluetoothEnableAndPairClick;
        }

        private void initialize()
        {
            bt = BluetoothAdapter.DefaultAdapter;

            welcomeText = FindViewById<TextView>(Resource.Id.welcomeText);
            pairButton = FindViewById<Button>(Resource.Id.pairButton);
            bluetoothEnable = FindViewById<Button>(Resource.Id.bluetoothEnable);
        }

        void OnBluetoothEnableAndPairClick(object sender, EventArgs e)
        {
            StartActivity(new Intent(Android.Provider.Settings.ActionBluetoothSettings));
        }

        void OnPairButtonClick(object sender, EventArgs e)
        {
            if(!bt.Enable())
            {
                Toast.MakeText(ApplicationContext, "Test", ToastLength.Short);
            }
            else
            {
                StartActivity(typeof(MainAcitivty));
            }
        }
    }
}