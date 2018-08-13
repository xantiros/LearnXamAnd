using Android.App;
using Android.Widget;
using Android.OS;

namespace SimpleApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        TextView txtNumber;
        int number;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.GridLayout);
            //SetContentView(Resource.Layout.activity_main);

            //txtNumber = FindViewById<TextView>(Resource.Id.txtNumber);

            //FindViewById<Button>(Resource.Id.btnIncrement).Click += (o, e) =>
            //txtNumber.Text = (++number).ToString();

            //FindViewById<Button>(Resource.Id.btnDecrement).Click += (o, e) =>
            //txtNumber.Text = (--number).ToString();
        }
    }
}

