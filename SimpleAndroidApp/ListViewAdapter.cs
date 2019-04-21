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
using static SimpleAndroidApp.MainActivity;

namespace SimpleAndroidApp
{
    public class ListViewAdapter : ArrayAdapter<IMenuItemsType>
    {
        private Context context;
        private List<IMenuItemsType> items;
        private LayoutInflater inflater;

        public ListViewAdapter(Context context, List<IMenuItemsType> items) : base(context, 0, items)
        {
            this.context = context;
            this.items = items;
            this.inflater = (LayoutInflater)this.context.GetSystemService(Context.LayoutInflaterService);
        }


        public override int Count
        {
            get
            {
                //throw new System.NotImplementedException();
                return items.Count;
            }
        }

        public override long GetItemId(int position)
        {
            //throw new System.NotImplementedException();
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            //throw new System.NotImplementedException();
            View view = convertView;
            try
            {
                IMenuItemsType item = items[position];
                if (item.GetMenuItemsType() == TYPE_ITEM)
                {
                    MenuHeaderItem _headerItem = (MenuHeaderItem)item;
                    view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.ListViewHeaderItem, parent, false);
                    // user dont click header item
                    view.Clickable = false;

                    TextView headerName = view.FindViewById<TextView>(Resource.Id.txtHeader);
                    headerName.Text = _headerItem.HeaderText;

                }
                else if (item.GetMenuItemsType() == TYPE_SEPORATOR)
                {
                    MenuContentItem _contentItem = (MenuContentItem)item;
                    view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.CardView, parent, false);
                    view.Clickable = true;

                    TextView _Descripcion = view.FindViewById<TextView>(Resource.Id.txtDescripcion);
                    TextView _Capitulo = view.FindViewById<TextView>(Resource.Id.txtCapitulo);
                    TextView _Versiculos = view.FindViewById<TextView>(Resource.Id.txtVersiculos);
                    //var _imgIcon = view.FindViewById<ImageView>(Resource.Id.imgIcon);
                    //var _subTitle = view.FindViewById<TextView>(Resource.Id.txtSubTitle);

                    _Descripcion.Text = _contentItem.Descripcion;
                    _Capitulo.Text = "Cantidad de Capitulos: " + _contentItem.Capitulo;
                    _Versiculos.Text = "Cantidad de Versiculos: " + _contentItem.Versiculos;
                    //_imgIcon.SetBackgroundResource(_contentItem.IconImage);
                    //_subTitle.Text = _contentItem.SubTitle;
                }
            }
            catch (Exception ex)
            {
                Toast.MakeText(context, ex.Message, ToastLength.Long);
            }
            return view;
        }
    }

}