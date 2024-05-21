using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSSReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
           List<News> Sources = XMLConvert();
           lst_baslik.DataSource = Sources;
        }

        private List<News> XMLConvert()


        {

            List<News> NewsList = new List<News>();
            XDocument xmlDoc =XDocument.Load(txt_rssurl.Text);
            List<XElement> Rows = xmlDoc.Descendants("item").ToList();
            foreach (XElement row in Rows)
            {
                News tempNews = new News();
                tempNews.Title = row.Element("title").Value;
                tempNews.Link = row.Element("link").Value;
                tempNews.Description = row.Element("description").Value;
                NewsList.Add(tempNews);

            }
            return NewsList;    

        }

        private void lst_baslik_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox selectedItem = (ListBox)sender;
            News selectedNews = (News)selectedItem.SelectedItem;
            web_browser.DocumentText = selectedNews.Description;






        }
    }
}
