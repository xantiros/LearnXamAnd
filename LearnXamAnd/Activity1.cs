using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;

namespace LearnXamAnd
{
    [Activity(Label = "Activity1", MainLauncher = true)]
    public class Activity1 : Activity
    {
        private List<string> mItems;
        private ListView mListView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout1);
            mListView = FindViewById<ListView>(Resource.Id.listView1);

            mItems = new List<string>();
            mItems.Add("Bob");
            mItems.Add("James");
            mItems.Add("Jimy");

            //ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);

            MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);

            mListView.Adapter = adapter;
        }
    }
}