using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace restApi.shared
{
    public class HttpClientHelper
    {
        //toDo
        //public HttpClientHelper()
        //{

        //}
        //public string SendPOSTRequest(string userName, string password,string endPoint, object postData)
        //{
        //    string urlPathForRequest = _jPlatformServiceUrl + "https://rtdc-apitest.engingrup.com/api/AYK/";
        //    urlPathForRequest = urlPathForRequest + endpoint;

        //    var jsonModel = JsonSerializer.Serialize(postData);
        //    var postDataByte = Encoding.ASCII.GetBytes(jsonModel);

        //    WebRequest webrequest = WebRequest.Create(urlPathForRequest);
        //    webrequest.Method = "POST";
        //    webrequest.ContentType = "application/json";
        //    webrequest.Headers.Add("accept", "application/json");
        //    webrequest.Headers.Add("auth-token", getEncodedAuthToken(token)); // getEncodedAuthToken(token));

        //    string responseString = "";
        //    try
        //    {
        //        using (var stream = webrequest.GetRequestStream())
        //        {
        //            stream.Write(postDataByte, 0, postDataByte.Length);
        //        }

        //        var response = (HttpWebResponse)webrequest.GetResponse();
        //        responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
        //    }
        //    catch (WebException webEx)
        //    {
        //        var response = ((HttpWebResponse)webEx.Response);
        //        StreamReader content = new StreamReader(response.GetResponseStream());
        //        responseString = content.ReadToEnd();

        //        return responseString;
        //    }

        //    return responseString;
        //}

    }
}
