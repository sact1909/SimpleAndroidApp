using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using Android.Content;
using Android.Views;

namespace SimpleAndroidApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        //private ListView listnames;
        //private List<string> itemlist;

        //public static Context context;
        public static List<LGResult> UserInfoList = new List<LGResult>();
        public static ListView ListViewWebService;

        public static int TYPE_ITEM = 0;
        public static int TYPE_SEPORATOR = 1;
        List<IMenuItemsType> item = new List<IMenuItemsType>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // Get our UI controls from the loaded layout
            //EditText phoneNumberText = FindViewById<EditText>(Resource.Id.PhoneNumberText);
            //TextView translatedPhoneWord = FindViewById<TextView>(Resource.Id.TranslatedPhoneword);
            //Button translateButton = FindViewById<Button>(Resource.Id.TranslateButton);

            //TextView lblid = FindViewById<TextView>(Resource.Id.lblid);
            //TextView lbltitle = FindViewById<TextView>(Resource.Id.lbltitle);
            //TextView lblbody = FindViewById<TextView>(Resource.Id.lblbody);
            Button btnLoadWebService = FindViewById<Button>(Resource.Id.btnLoadWebservice);

            ListViewWebService = FindViewById<ListView>(Resource.Id.LV_listwebservice);
            ListViewWebService.Divider = null;
            /*Progress LayOut*/

            LinearLayout progressLayout = FindViewById<LinearLayout>(Resource.Id.progressLayout);
            progressLayout.Visibility = ViewStates.Gone;

            /*Final Progress LayOuy*/

            // Add code to translate number
            //translateButton.Click += (sender, e) =>
            //{
            //    // Translate user's alphanumeric phone number to numeric
            //    string translatedNumber = Core.PhonewordTranslator.ToNumber(phoneNumberText.Text);
            //    if (string.IsNullOrWhiteSpace(translatedNumber))
            //    {
            //        translatedPhoneWord.Text = string.Empty;
            //    }
            //    else
            //    {
            //        translatedPhoneWord.Text = translatedNumber;
            //    }
            //};

            btnLoadWebService.Click += (sender, e) => {

                progressLayout.Visibility = ViewStates.Visible;
                btnLoadWebService.Enabled = false;

                var NxtAct = new Intent(this, typeof(ActivityWriters));
                StartActivity(NxtAct);

                //LGClient client = new LGClient();
                //var result = await client.Get("http://bibleapi.somee.com/api/nestedlibros");


                //itemlist = new List<string>();
                //foreach (var resultado in result)
                //{
                //    //lblid.Text = $"{resultado.id}";
                //    //lbltitle.Text = resultado.employee_name;
                //    //lblbody.Text = resultado.employee_salary;
                //    //itemlist.Add(resultado.employee_name);

                //    //UserInfoList.Add(resultado);


                //    item.Add(new MenuHeaderItem(resultado.AUTOR));

                //    for (var i=0;i < resultado.LIBROS.Count;i++) {
                //        item.Add(new MenuContentItem(

                //            resultado.LIBROS[i].Descripcion,
                //            resultado.LIBROS[i].Capitulo,
                //            resultado.LIBROS[i].Versiculos

                //            ));
                //    }


                //}


                //ListViewWebService.Adapter = new ArrayAdapter<LGClient>(this,Android.Resource.Layout.SimpleListItem1, UserInfoList);
                //ArrayAdapter<WSResult> adapter = new ArrayAdapter<WSResult>(this, Android.Resource.Layout.SimpleListItem1, UserInfoList);


                //ListViewWebService.Adapter = new UserInfoListAdapter(context, UserInfoList);
                //ListViewWebService.Adapter = new ListViewAdapter(this, item);

                //ListViewWebService.SetAdapter(result);
                //if (result != null)
                //{

                //    //lblid.Text = $"{result.id}";
                //    //lbltitle.Text = result.employee_name;
                //    //lblbody.Text = result.employee_salary;
                //}
                //progressLayout.Visibility = ViewStates.Gone;
                //btnLoadWebService.Enabled = true;
            };

            

        }

        public interface IMenuItemsType
        {
            int GetMenuItemsType();
        }

        
    }
}