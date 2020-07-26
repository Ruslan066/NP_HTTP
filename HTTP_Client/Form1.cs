using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Linq;
using System.Web;
using HtmlAgilityPack;

namespace HTTP_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(URL.Text);
            req.Method = "GET";
            //if (IfProxy.Checked)
            //{
            //    WebProxy proxy = new WebProxy(proxyAddr.Text);
                
            //    proxy.Credentials = new NetworkCredential(proxyUser.Text, proxyPassword.Text);
            //    req.Proxy = proxy;
            //}
 
            HttpWebResponse rez = (HttpWebResponse)req.GetResponse();
            StreamReader sr = new StreamReader(rez.GetResponseStream(), Encoding.UTF8);
            response.Text = sr.ReadToEnd();

            // Brouse as webPage
            // webBrowser.Navigate(URL.Text);

            HtmlAgilityPack.HtmlDocument html = new HtmlAgilityPack.HtmlDocument();
            html.LoadHtml(response.Text);

            //var hrefs = html.DocumentNode.Descendants("a")
            //                .Select(a => a.GetAttributeValue("href", "/"))
            //                .ToList();
            //listLinks.DataSource = hrefs;

            //HtmlNodeCollection 
            var nodes = html.DocumentNode.SelectNodes("//a[@href]").ToList();

            listLinks.DataSource = nodes;

            //string str = "";
            //foreach (var h in hrefs)
            //{
            //    str += h.GetAttributeValue("href", "");
            //}

            //MessageBox.Show(str);


        }
    }
}