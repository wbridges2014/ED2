using System;

using Android;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.App;
using Android.Gms.Maps;

namespace ChildAlert
{
    [Activity(Label = "Location Test")]
    public class LocationActivity : Activity, IOnMapReadyCallback
    {
        private GoogleMap gMap;

       
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Location);

            StartMap();
        }

        private void StartMap()
        {
            if (gMap == null)
            {
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map).GetMapAsync(this);
            }
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            gMap = googleMap;
        }

    }


}