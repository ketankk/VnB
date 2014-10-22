using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int i1, i2;
        string username, pass;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string conn="Server = localhost;Database=android;uid=root;Pwd=;";

            string conn = "Server = localhost;Database=android;uid=root;Pwd=;";
            string name;
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd;
            con.Open();

            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "Insert into trial(user,password) values(@user,@password)";
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.ExecuteNonQuery();

            }
            catch (Exception) { throw; }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                //LoadData();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pass = textBox2.Text;
        }
        /*private void LoadData(){
        
        MySqlConnection con = new MySqlConnection(conn);
            con.Open();
            try{
            MySqlCommand cmd;
                cmd= con.CreateCommand();
                cmd.CommandText = "SELECT * FROM android";
                MySqlAdapter  adap = new MySqlAdapter(cmd);
                DataSet ds = new DataSet();
                adap.f


            }
            catch{
            
            }*/

        }
    }

