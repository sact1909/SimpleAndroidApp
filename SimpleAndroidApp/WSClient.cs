using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;

namespace SimpleAndroidApp
{
    class WSClient
    {
        
        public async Task<List<WSResult>> Get(string url)
        {
              
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);

            
            
                var json = await response.Content.ReadAsStringAsync();
                var items = JsonConvert.DeserializeObject<List<WSResult>>(json);
                
                return (items);
            
        }
    }
}