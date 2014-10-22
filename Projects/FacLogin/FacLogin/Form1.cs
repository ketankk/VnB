using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
    public partial class Form1 : Form
    {
        string fac_name,fac_dept,fac_desg,fac_email,fac_pass1,fac_pass2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void name_TextChanged(object sender, EventArgs e)
        {
             fac_name = name.Text;
          
        }

        private void desig_TextChanged(object sender, EventArgs e)
        {
            fac_desg = desig.Text;
        }

        private void dept_TextChanged(object sender, EventArgs e)
        {
            fac_dept = dept.Text;
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            fac_email = email.Text;
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            fac_pass1 = pass.Text;
        }
        //Register Button Event
        private void button1_Click(object sender, EventArgs e)
        {
            string tag = "register";
            string content ="tag="+tag+ "&name="+fac_name + "&desig="+fac_desg + "&dept=" +fac_dept + "&email=" + fac_email +
                "&pass1="+fac_pass1 + "&pass2="+fac_pass2;

            string URL = "http://localhost/pro/desktop1/index.php";
            string URI = "http://k3k.bugs3.com/desktop/index.php";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI);
            request.Method = "POST";
            byte[] byteArray = Encoding.UTF8.GetBytes(content);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();

            dataStream.Write(byteArray,0,byteArray.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = HttpUtility.UrlDecode(reader.ReadToEnd());
           //condition not working :(
            /*
            int a=string.Compare(fac_name,responseFromServer);
            if (a==0)
                MessageBox.Show("Registration SUCCESSFULL with " + fac_name);
            else
                MessageBox.Show(responseFromServer+" Registration Not Successfull "+fac_name);
             * */
            MessageBox.Show("Registration Successfull " + fac_name);
            reader.Close();
            dataStream.Close();
            response.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
           // this.Close();
        }
    }
}
