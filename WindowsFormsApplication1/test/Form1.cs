using Google.API.Search;
using System;
using System.Collections.Generic;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WebBrowser webreslut = new WebBrowser();
            panel1.Controls.Add(webreslut);
            webreslut.Height = 500;
            webreslut.Width = 500;
            webreslut.Visible = true;
            GimageSearchClient client = new GimageSearchClient("https://images.google.com/");
            IList<IImageResult> results;
            results = client.Search("abc", 5);
            
        }
    }
}
