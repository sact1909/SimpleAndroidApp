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
    [Activity(Label = "ActivityWriters")]
    public class ActivityWriters : Activity
    {

        public static List<LGResult> UserInfoList = new List<LGResult>();
        public static ListView LV_Writer;

        public static int TYPE_ITEM = 0;
        public static int TYPE_SEPORATOR = 1;
        List<IMenuItemsType> item = new List<IMenuItemsType>();

        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Writer_Activity);

            // Create your application here


            LinearLayout progressLayout = FindViewById<LinearLayout>(Resource.Id.progressLayout);
            LV_Writer = FindViewById<ListView>(Resource.Id.LV_Writer);
            LV_Writer.Divider = null;
            progressLayout.Visibility = ViewStates.Visible;
            LGClient client = new LGClient();
            var result = await client.Get("http://bibleapi.somee.com/api/nestedlibros");
            foreach (var resultado in result)
            {
                item.Add(new MenuHeaderItem(resultado.AUTOR));
                for (var i = 0; i < resultado.LIBROS.Count; i++)
                {
                    item.Add(new MenuContentItem(
                        resultado.LIBROS[i].Descripcion,
                        resultado.LIBROS[i].Capitulo,
                        resultado.LIBROS[i].Versiculos
                        ));
                }
            }
            LV_Writer.Adapter = new ListViewAdapter(this, item);
            progressLayout.Visibility = ViewStates.Gone;


        }

    
    }
}