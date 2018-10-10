using Android.OS;
using Android.App;
using Android.Widget;
using Android.Content.PM;
using Plugin.Permissions;
using System;

namespace ChildAlert
{
    [Activity(Label = "MainActivity")]
    public class LocateActivity : Activity
    {
        /*public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }*/

        TextView sampleText;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Location);

            initialize();


            /*TabLayoutResource = Resource.Layout.Location;
            ToolbarResource = Resource.Layout.Toolbar;

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            Plugin.CurrentActivity.CrossCurrentActivity.Current.Init(this, savedInstanceState);

            //LoadApplication(new );*/
        }

        void initialize()
        {
            sampleText = FindViewById<TextView>(Resource.Id.sampleText);
        }
     }
}