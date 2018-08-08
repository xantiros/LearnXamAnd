using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;

namespace LearnXamAnd
{
    public class MyListViewAdapter : BaseAdapter<string>
    {
        private List<string> mItems;
        private Context mcontext;

        public MyListViewAdapter(Context context, List<string> items)
        {
            mcontext = context;
            mItems = items;
        }

        public override string this[int position]
        {
            get { return mItems[position]; }
        }

        public override int Count => mItems.Count;

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if(row == null)
            {
                row = LayoutInflater.From(mcontext).Inflate(Resource.Layout.listview_row, null, false);
            }
            TextView txtName = row.FindViewById<TextView>(Resource.Id.txtFirstName);
            txtName.Text = mItems[position];

            return row;
        }
    }
}