using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mime;
using System.IO;
using System.Web;
using System.Net.NetworkInformation;
using System.Collections.Specialized;
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        
        private void button1_Click(object sender, EventArgs e)
        {
           /* string URL = "http://localhost/pro/desktop";

            WebClient webClient = new WebClient();
            NameValueCollection formData = new NameValueCollection();
            
            String data = "tag=register&name=url&password=url";
            String responseBytes = webClient.UploadString(URL, "POST", data);

            //string responsefromserver = Encoding.UTF8.GetString(responseBytes);
            string responseFromServer = HttpUtility.UrlDecode(responseBytes.ReadToEnd());
            MessageBox.Show(responseBytes);
            webClient.Dispose();
           */ HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost/pro/desktop/index.php");
            request.Method = "POST";
            string s="register",s1 = "kk", s2 = "vj";
            String formContent = "tag=" + s + "&name="+ s1+"&password="+s2;

            byte[] byteArray = Encoding.UTF8.GetBytes(formContent);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = HttpUtility.UrlDecode(reader.ReadToEnd());
            MessageBox.Show(responseFromServer);
          
            //You may need HttpUtility.HtmlDecode depending on the response

            reader.Close();
            dataStream.Close();
            response.Close();
        }

    }
}
