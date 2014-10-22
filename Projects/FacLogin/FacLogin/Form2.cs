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


namespace FacLogin
{
    public partial class Form2 : Form
    {
        string email, password;
        public Form2()
        {
            InitializeComponent();
        }
        private void emai_TextChanged_1(object sender, EventArgs e)
        {
            email = emai.Text;
        }
       

        private void pass_TextChanged(object sender, EventArgs e)
        {
            password = pass.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string URL = "http://localhost/pro/desktop1/index.php";
            string URI = "http://k3k.bugs3.com/desktop/index.php";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI);
            request.Method = "POST";
            string tag = "login";
            String formContent = "tag=" + tag + "&email=" + email+ "&password=" + password;

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
            MessageBox.Show("LOGGED IN");

            //You may need HttpUtility.HtmlDecode depending on the response

            reader.Close();
            dataStream.Close();
            response.Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
           
        }

        
    }
}
