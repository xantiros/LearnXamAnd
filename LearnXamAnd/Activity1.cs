using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;

namespace LearnXamAnd
{
    [Activity(Label = "Activity1", MainLauncher = true)]
    public class Activity1 : Activity
    {
        private List<Person> mItems;
        private ListView mListView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout1);
            mListView = FindViewById<ListView>(Resource.Id.listView1);

            mItems = new List<Person>();
            mItems.Add(new Person() { FirstName = "Joe", LastName = "Smith", Age = "21", Gender = "Male" });
            mItems.Add(new Person() { FirstName = "Joe2", LastName = "Smith2", Age = "55", Gender = "Male" });
            mItems.Add(new Person() { FirstName = "Joe3", LastName = "Smith2", Age = "11", Gender = "Female" });

            //ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);

            MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);

            mListView.Adapter = adapter; //custom adapter
        }
    }
}