using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form5 : MaterialForm
    {
        DictManager dictionary;
        string gt = "Default";
        string tuoi = "Default";
        int gender = 1;
        bool def = false;
       


        public Form5()
        {
            InitializeComponent();
            var ms = MaterialSkinManager.Instance;
            ms.AddFormToManage(this);
            ms.Theme = MaterialSkinManager.Themes.DARK;
            ms.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            cbWord.DisplayMember = "Key";
            dictionary = new DictManager();
            dictionary.LoadDataToCombobox(cbWord);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            RB1.Checked = true;         

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = cbWord as ComboBox;

            if (cb.DataSource == null)
                return;

            DictData data = cb.SelectedItem as DictData;
            string data1 = "/" + data.Mean.ToString().Replace("*", "\r\n*").Replace("=", "\r\n= ").Replace("-", "\r\n- ");
            tbMean.Text = data1;
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {
                            
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage == tabPage2)
            {
                if (InternetConnection.IsConnectedToInternet())
                {
                    if ((cbWord.SelectedItem as DictData).Key != null)
                    {
                        string data = (cbWord.SelectedItem as DictData).Key;
                        WebBrowser wb1 = new WebBrowser();
                        panel3.Controls.Add(wb1);
                        string link = "https://www.google.com/search?q=" + data + "&source=lnms&tbm=isch&sa=X&ved=0ahUKEwjz-qCNkp_fAhWWA4gKHfjiA8oQ_AUIDygC&biw=1536&bih=683";
                        wb1.Height = panel3.Height;
                        wb1.Width = panel3.Width;
                        wb1.Visible = true;
                        wb1.ScriptErrorsSuppressed = true;
                        wb1.Navigate(link);
                        wb1.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại. Bạn cần kết nối Internet để sử dụng tính năng này.", "Thông báo", MessageBoxButtons.OK);

                }
            }
            if (e.TabPage == tabPage3)
            {
                if (InternetConnection.IsConnectedToInternet())
                {
                    if ((cbWord.SelectedItem as DictData).Key != null)
                    {
                        string data = (cbWord.SelectedItem as DictData).Key;
                        WebBrowser wb2 = new WebBrowser();
                        panel4.Controls.Add(wb2);
                        string link = "https://dictionary.cambridge.org/vi/dictionary/english/" + data;
                        wb2.Height = panel4.Height;
                        wb2.Width = panel4.Width;
                        wb2.Visible = true;
                        wb2.Navigate(link);
                        wb2.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại. Bạn cần kết nối Internet để sử dụng tính năng này.", "Thông báo", MessageBoxButtons.OK);
                }
            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Speech.Synthesis.SpeechSynthesizer sp = new SpeechSynthesizer();
            if (gender == 1)
            {
               sp.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
            }
            else if (gender == 2)
            {
                sp.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            }
            sp.Speak((cbWord.SelectedItem as DictData).Key);
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (def)
            {
                if (RB1.Checked == true)
                {
                    MessageBox.Show("Bạn vừa chọn giọng nói là: " + RB1.Text);
                    gender = 1;

                }
                else if (RB2.Checked == true)
                {
                    MessageBox.Show("Bạn vừa chọn giọng nói là: " + RB2.Text);
                    gender = 2;
                }
            }
            def = true;
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
