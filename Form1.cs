using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace HtmlWeb
{
    public partial class btnGetData : Form
    {
        public btnGetData()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var url = "https://mimihan.tw/tainan-foods/";
            var web = new HtmlAgilityPack.HtmlWeb();
            var doc = web.Load(url);
            List<string> Title = new List<string>();

            //因為網頁格式不齊，所以很難抓

            //選取h4底下的第二個span有style文字大小為16px
            HtmlNodeCollection uiListNodes = doc.DocumentNode.SelectNodes("//h4/span[2][@style='font-size: 16px;']");
            foreach (var item in uiListNodes)
            {
                Title.Add(item.InnerText);
            }
            //凰商號-聯盈發港式點心專賣店
            HtmlNodeCollection uiListNodes2 = doc.DocumentNode.SelectNodes("//span[@style='color: #ff0000; font-size: 12pt;']");
            foreach (var item in uiListNodes2)
            {
                Title.Add(item.InnerText);
            }
        }
    }
}
