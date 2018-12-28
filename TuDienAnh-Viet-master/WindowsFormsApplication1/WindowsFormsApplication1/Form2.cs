using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2(string data)
        {
            InitializeComponent();
            WebBrowser wb = new WebBrowser();
            panel1.Controls.Add(wb);
            string link = "https://www.google.com/search?q="+ data + "&source=lnms&tbm=isch&sa=X&ved=0ahUKEwjz-qCNkp_fAhWWA4gKHfjiA8oQ_AUIDygC&biw=1536&bih=683";
            wb.Height = panel1.Height;
            wb.Width = panel1.Width;
            wb.Visible = true;
            wb.ScriptErrorsSuppressed = true;
            wb.Navigate(link);            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
