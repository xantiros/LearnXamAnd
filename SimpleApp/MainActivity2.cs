using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Support.Animation;
using Android.Util;

namespace SimpleApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity2 : Activity
    {

        bool shouldFlingUpwards = true;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            View viewSpring = FindViewById<View>(Resource.Id.view_spring);
            View viewFling = FindViewById<View>(Resource.Id.view_fling);

            viewSpring.Click += (o, e) =>
            {
                SpringAnimation springAnim = new SpringAnimation(viewSpring, DynamicAnimation.TranslationY, 0);
                springAnim.Spring.SetStiffness(SpringForce.StiffnessLow);
                springAnim.Spring.SetDampingRatio(SpringForce.DampingRatioHighBouncy);
                springAnim.SetStartVelocity(DpToPx(-2000));
                springAnim.Start();
            };

            viewFling.Click += (o, e) =>
            {
                FlingAnimation flingAnim = new FlingAnimation(viewFling, DynamicAnimation.TranslationY);
                flingAnim.SetStartVelocity(DpToPx(shouldFlingUpwards ? -1500 : 1500));
                //flingAnim.SetFriction(2);
                flingAnim.Start();
                shouldFlingUpwards = !shouldFlingUpwards;
            };
        }

        private float DpToPx(float dp)
        {
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, dp, Resources.DisplayMetrics);
        }
    }
}
