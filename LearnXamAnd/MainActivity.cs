using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace LearnXamAnd
{
    [Activity(Label = "Phone Word", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            EditText phoneNumberText = FindViewById<EditText>(Resource.Id.PhoneNumberText);
            TextView translatedPhoneWord = FindViewById<TextView>(Resource.Id.TranslatePhoneWord);
            Button translateButton = FindViewById<Button>(Resource.Id.TranslateButton);

            translateButton.Click += (sender, e) =>
            {
                string translatedNumber = Core.PhoneWordTranslator.ToNumber(phoneNumberText.Text);
                if (string.IsNullOrWhiteSpace(translatedNumber))
                {
                    translatedPhoneWord.Text = string.Empty;
                }
                else
                {
                    translatedPhoneWord.Text = translatedNumber;
                }
            };

        }
    }
}

