using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SimpleAndroidApp
{
    class UserInfoListAdapter : BaseAdapter<LGResult>
    {

        Context context;

        private List<LGResult> mItem = new List<LGResult>();
        

        public UserInfoListAdapter(Context mcontext, List<LGResult> mItems)
        {
            mItem.Clear();
            mItem = mItems;
            context = mcontext;
            this.NotifyDataSetChanged();
        }

        public override LGResult this[int position] {
            get { return mItem[position]; }
        }
        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View listitem = convertView;
            //listitem = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.ListViewDesign, parent, false);
            listitem = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.ListViewHeaderItem, parent, false);
            //TextView TxtNo = listitem.FindViewById<TextView>(Resource.Id.TxtNo);
            //LinearLayout layout = listitem.FindViewById<LinearLayout>(Resource.Id.linearLayout1);
            //layout.Visibility = ViewStates.Visible;
            //TextView textView1 = listitem.FindViewById<TextView>(Resource.Id.textView1);

            //ListView ListLibros = listitem.FindViewById<ListView>(Resource.Id.ListLibros);
            List<string> lista = new List<string>();
            //TxtNo.Text = mItem[position].AUTOR;

            TextView txtheader = listitem.FindViewById<TextView>(Resource.Id.txtHeader);
            txtheader.Text = mItem[position].AUTOR;

            //listitem = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.ListViewContentItem, parent, false);
            //TextView txtitems = listitem.FindViewById<TextView>(Resource.Id.txtDescipcion);

            for (var i = 0; i < mItem[position].LIBROS.Count(); i++) {


                //lista.Add(mItem[position].LIBROS[i].Descripcion);
                
            }

            


            //ListLibros.Adapter = new ArrayAdapter<string>(ListLibros.Context, Android.Resource.Layout.SimpleListItem1, lista);
            //ListLibros.NestedScrollingEnabled = true;
            //ListLibros.SetAdapter(arraylist);
            //ArrayAdapter<string> adapter = new ArrayAdapter<string>(context, Android.Resource.Layout.SimpleListItem1, mItems);
            //listitem.Click += (object sender, EventArgs e) => {
            //    Toast.MakeText(parent.Context, "Clicked " + mItem[position].firstname, ToastLength.Long).Show();
            //};
            return listitem;
        }


            //fill in your items
          

        //Fill in cound here, currently 0
        public override int Count
        {
            get
            {
                return mItem.Count;
            }
        }

    }

    class UserInfoListAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}