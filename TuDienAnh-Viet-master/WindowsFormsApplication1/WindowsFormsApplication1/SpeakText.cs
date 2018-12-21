using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class SpeakText
    {
        private WebBrowser wbweb;
public WebBrowser Wbweb
        {
            get
            {
                return wbweb;
            }

            set
            {
                wbweb = value;
            }
        }
        public SpeakText(WebBrowser wb)
        {
            this.wbweb = wb;
        }
        private void settext(string data)
        {
            wbweb.Document.GetElementById("cdo-search-input").InnerText = data;
            
            
            
        }
        private void speaktxt()
        {
             HtmlElement element = wbweb.Document.GetElementById("cdo-search-input");
            element.InvokeMember("click");
            
        }
       
        public  void Speak(string data)
        {
            settext(data);
           speaktxt();
                        
        }
    }
}
 