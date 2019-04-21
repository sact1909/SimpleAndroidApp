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
    public class WSResult
    {
        public int ID { get; set; }
        public string COD_LIBRO { get; set; }
        public string DESCRIPCION { get; set; }
        public string CAPITULO { get; set; }
        public string VERSICULOS { get; set; }
        public string AUTOR { get; set; }
        public object TITULO_AUTOR { get; set; }
        public object TITULO_CAPITULO { get; set; }
        public object TITULO_VERSICULO { get; set; }
        public object TITULO_CONSULTA { get; set; }
        public object TITULO_GENERAL { get; set; }
        public object BUSCAR { get; set; }
        public object TITULO_REPORTE1 { get; set; }
        public object TITULO_REPORTE2 { get; set; }
        public object CONTENIDO { get; set; }
    }
}