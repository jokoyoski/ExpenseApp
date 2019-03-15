using ExpensesApp.Helper;
using ExpensesApp.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesApp.Client
{
    public class RestClient
    {
        public async Task<HttpResponseMessage> SaveExpenses(Expenses expenses)
        {
            var client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;

            var uri = string.Format(Constant.AZURE + "/createexpense");
            var json = JsonConvert.SerializeObject(expenses);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = null;
            response = await client.PostAsync(uri, content);



            var ode = await response.Content.ReadAsStringAsync();

            var joko = JObject.Parse(ode);

            var alao = joko["Amount"];


            return response;


        }








        public async Task<List<Expenses>> ListExpenses()
        {
            var client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;

            var uri = string.Format(Constant.AZURE + "/listexpenses");


            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = null;
            response = await client.GetAsync(uri);



            var ode = await response.Content.ReadAsStringAsync();



            return new List<Expenses>();


        }
    }
}
