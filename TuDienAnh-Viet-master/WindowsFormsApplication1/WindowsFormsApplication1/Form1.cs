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
    public partial class Form1 : Form
    {
        DictManager dictionary;
        SpeakText speakvn;
        SpeakText speakeng;
        public Form1()
        {
            InitializeComponent();

            cbWord.DisplayMember = "Key";
            WebBrowser wbvn = new WebBrowser();
            wbvn.Width = 0;
            wbvn.Height = 0;
            wbvn.Visible = false;
            wbvn.ScriptErrorsSuppressed = true;
            wbvn.Navigate(Cons.vietnamlink);
            this.Controls.Add(wbvn);

            WebBrowser wbeng = new WebBrowser();
            wbeng.Width = 500 ;
            wbeng.Height = 500;
            wbeng.Visible = true;
            wbeng.ScriptErrorsSuppressed = true;
            wbeng.Navigate(Cons.englishlink);
            this.Controls.Add(wbeng);

            speakvn = new SpeakText(wbvn);
            speakeng = new SpeakText(wbeng);
            dictionary = new DictManager();

            dictionary.LoadDataToCombobox(cbWord);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = cbWord as ComboBox;

            if (cb.DataSource == null)
                return;

            DictData data = cb.SelectedItem as DictData;

            tbMean.Text = data.Mean;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            speakeng.Speak((cbWord.SelectedItem as DictData).Key);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?" , "Thông báo" , MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSpkMean_Click(object sender, EventArgs e)
        {
            speakvn.Speak((cbWord.SelectedItem as DictData).Mean);
        }
    }
}
