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
    public class MenuContentItem : IMenuItemsType
    {
        public string Descripcion { get; set; }
        public string Capitulo { get; set; }
        public string Versiculos { get; set; }

        public int GetMenuItemsType()
        {
            return TYPE_SEPORATOR;// return 1
        }

        public MenuContentItem(string _Descripcion,string _Capitulo,string _Versiculos)
        {
            Descripcion = _Descripcion;
            Capitulo = _Capitulo;
            Versiculos = _Versiculos;
            //SubTitle = _subtitle;
            //IconImage = _iconImage;
        }
    }
}