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
        Button pairedDevicesButton;
        ListView listDevices;
        BluetoothAdapter bt;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Pair);

            initialize();

            pairButton.Click += OnPairButtonClick;
            bluetoothEnable.Click += OnBluetoothEnableClick;
            pairedDevicesButton.Click += OnPairedDevicesButtonClicked;
        }

        void initialize()
        {
            bt = BluetoothAdapter.DefaultAdapter;

            welcomeText = FindViewById<TextView>(Resource.Id.welcomeText);
            pairButton = FindViewById<Button>(Resource.Id.pairButton);
            bluetoothEnable = FindViewById<Button>(Resource.Id.bluetoothEnable);
            pairedDevicesButton = FindViewById<Button>(Resource.Id.pairedDevicesButton);
            listDevices = FindViewById<ListView>(Resource.Id.listDevices);
        }


        void OnPairButtonClick(object sender, EventArgs e)
        {
            StartActivity(typeof(MainAcitivty));
        }

        void OnBluetoothEnableClick(object sender, EventArgs e)
        {
            if(!bt.Enable())
            {
                Intent enable = new Intent(BluetoothAdapter.ActionRequestEnable);
                StartActivityForResult(enable, 0); 
            }

            Toast.MakeText(this, "Bluetooth Enabled", ToastLength.Short).Show();
        }

        void OnPairedDevicesButtonClicked(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            foreach (BluetoothDevice b in bt.BondedDevices)
            {
                list.Add(b.Name);
            }

            ArrayAdapter adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, list);
            listDevices.SetAdapter(adapter);
        }

    }
}

