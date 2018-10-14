using Android.OS;
using Android.App;
using Android.Widget;
using Android.Content.PM;
using Plugin.Permissions;
using System;
using Android.Locations;
using Android.Runtime;
using System.Collections.Generic;
using Android.Util;
using System.Linq;

namespace ChildAlert
{
    [Activity(Label = "MainActivity")]
    public class LocateActivity : Activity, ILocationListener
    {

        TextView sampleText;
        Android.Locations.LocationProvider fusedLocationProviderClient;

        public void OnLocationChanged(Location location)
        {
            throw new NotImplementedException();
        }

        public void OnProviderDisabled(string provider)
        {
            throw new NotImplementedException();
        }

        public void OnProviderEnabled(string provider)
        {
            throw new NotImplementedException();
        }

        public void OnStatusChanged(string provider, [GeneratedEnum] Availability status, Bundle extras)
        {
            throw new NotImplementedException();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Location);

            initialize();

            Android.Locations.ILocationListener locationRequest = new PackageInstallLocation.SetPriority(LocationRequest.PriorityHighAccuracy)
                                  .SetInterval(60 * 1000 * 5)
                                  .SetFastestInterval(60 * 1000 * 2);
        }

        void initialize()
        {
            sampleText = FindViewById<TextView>(Resource.Id.sampleText);
        }
     }
}