using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace magazin.Serves
{
    public async Task<HttpStatusCode>LoginAsync(string userName, string password)
    {
        try
        {
            var json = new JObject { { "UserName", userName }, { "Password", password } }.ToString();
            return (await _httpClient.PostAsync(new Uri($"{_baseUrl}/login.php"),
            new StringContent(json, Encoding.UTF8, "application/json"))).StatusCode;
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
            return HttpStatusCode.SeeOther;
        }
    }
}


