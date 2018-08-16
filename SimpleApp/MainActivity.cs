using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;

namespace SimpleApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        //TextView txtNumber;
        //int number;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Toolbar);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Tutorial Toolbar";


            //SetContentView(Resource.Layout.activity_main);

            //txtNumber = FindViewById<TextView>(Resource.Id.txtNumber);

            //FindViewById<Button>(Resource.Id.btnIncrement).Click += (o, e) =>
            //txtNumber.Text = (++number).ToString();

            //FindViewById<Button>(Resource.Id.btnDecrement).Click += (o, e) =>
            //txtNumber.Text = (--number).ToString();
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.toolbar_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            string textToShow;

            if (item.ItemId == Resource.Id.menu_info)
                textToShow = "Learn more about us on our website :)";
            else if (item.ItemId == Resource.Id.menu_overflow)
                textToShow = "Overfloooow";
            else
                textToShow = "tst";

            Android.Widget.Toast.MakeText(this, item.TitleFormatted + ": " + textToShow,
                Android.Widget.ToastLength.Long).Show();

            return base.OnOptionsItemSelected(item);
        }
    }
}

