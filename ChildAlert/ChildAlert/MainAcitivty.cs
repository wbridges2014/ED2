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

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            welcomeText = FindViewById<TextView>(Resource.Id.welcomeText);
            beepButton = FindViewById<Button>(Resource.Id.beepButton);
            locationButton = FindViewById<Button>(Resource.Id.locationButton);

            beepButton.Click += OnBeepButtonClick;
            locationButton.Click += OnLocationButtonClick;

            //var enableBtIntent = new Intent(BluetoothAdapter.ACTION_REQUEST_ENABLE);
            //startActivityForResult(enableBtIntent, REQUEST_ENABLE_BT);
            //StartActivityForResult(BluetoothAdapter.ActionRequestEnable, 0000);

            //BluetoothAdapter mBluetoothAdapter = BluetoothAdapter.DefaultAdapter;

            //BluetoothAdapter.Enable();
        }

        void OnBeepButtonClick(object sender, EventArgs e)
        {
            welcomeText.Text = "*Beep*";
        }

        void OnLocationButtonClick(object sender, EventArgs e)
        {
            welcomeText.Text = "*GPS Location*";
        }

    }
}
