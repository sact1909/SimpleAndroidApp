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
    public class LGResult 
    {
            public string AUTOR { get; set; }
            public List<LIBRO> LIBROS { get; set; }
    }

    public class LIBRO
    {
        public string Descripcion { get; set; }
        public string Capitulo { get; set; }
        public string Versiculos { get; set; }
    }
}