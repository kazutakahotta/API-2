using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace API課題
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = textBox1.Text;
            var client = new RestClient();
            var request = new RestRequest();


            client.BaseUrl = new Uri("http://zipcloud.ibsnet.co.jp/api/search");

            request.Method = Method.GET;
            request.AddParameter("zipcode", code, ParameterType.GetOrPost);
            var response = client.Execute(request);
            string json = response.Content.ToString();
            var t = Newtonsoft.Json.JsonConvert.DeserializeObject<Postzip>(json);

            if (t.status != "200")
            {
                textBox2.Text = t.message;
            }
            else
            {
                textBox2.Text = t.results[0].address1 + t.results[0].address2 + t.results[0].address3;
            }
            
        }
    }
}
