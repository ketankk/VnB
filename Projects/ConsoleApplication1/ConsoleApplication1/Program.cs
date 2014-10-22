using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Net;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            string URL = "http://localhost/pro/desktop";

            WebClient webClient = new WebClient();
            NameValueCollection formData = new NameValueCollection();
            formData["tag"] = "register";
            formData["name"] = "hvdhvdfvhdffvhd";
            formData["password"] = "url";
            byte[] responseBytes = webClient.UploadValues(URL, "POST", formData);

            string responsefromserver = Encoding.UTF8.GetString(responseBytes);
            Console.WriteLine(responsefromserver);
            webClient.Dispose();



        }
    }
}
