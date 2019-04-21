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
    public class MenuHeaderItem : IMenuItemsType
    {
        public string HeaderText { get; set; }

        public int GetMenuItemsType()
        {
            return TYPE_ITEM;// return 0. It is header
        }

        public MenuHeaderItem(string _headerText)
        {
            HeaderText = _headerText;// return title of header
        }
    }
}