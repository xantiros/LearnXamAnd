using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;

namespace PhoneWorld
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            EditText phoneNumber = FindViewById<EditText>(Resource.Id.phoneNumber);
            Button callButton = FindViewById<Button>(Resource.Id.callButton);

            callButton.Click += (object sender, EventArgs e) =>
            {
                var callIntent = new Intent(Intent.ActionCall);
                callIntent.SetData(Android.Net.Uri.Parse("tel: " + phoneNumber));
                StartActivity(callIntent);
            };


        }

        //[Export("Call")]
        //public void Call(View view)
        //{
        //    EditText phoneNumber = FindViewById<EditText>(Resource.Id.phoneNumber);

        //    var callIntent = new Intent(Intent.ActionCall);
        //    callIntent.SetData(Android.Net.Uri.Parse("tel:" + phoneNumber.Text));
        //    StartActivity(callIntent);
        //}
        
    }
}

