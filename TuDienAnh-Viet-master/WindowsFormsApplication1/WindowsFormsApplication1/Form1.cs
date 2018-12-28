using System;
using Google;
using Google.API;
using Google.API.Search;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WindowsFormsApplication1
{
    public partial class Form1 : MaterialForm
    {
        DictManager dictionary;
        string gt = "Default";
        string tuoi = "Default";
        SpeechSynthesizer sp;


        public Form1()
        {
            InitializeComponent();
            


            cbWord.DisplayMember = "Key";
            dictionary = new DictManager();
            dictionary.LoadDataToCombobox(cbWord);
            #region webbroswer demo 1
            //  changeloading();
            // WebBrowser wbvn = new WebBrowser();
            // wbvn.Width = 0;
            // wbvn.Height = 0;
            // wbvn.Visible = false;
            // wbvn.ScriptErrorsSuppressed = true;
            // wbvn.Navigate(Cons.vietnamlink);
            // wbvn.DocumentCompleted += Wbvn_DocumentCompleted;
            //this.Controls.Add(wbvn);

            // WebBrowser wbeng = new WebBrowser();
            //wbeng.Width = 500 ;
            //wbeng.Height = 500;
            //wbeng.Visible = true;
            //wbeng.ScriptErrorsSuppressed = true;
            //wbeng.Navigate(Cons.englishlink);
            //wbeng.DocumentCompleted += Wbeng_DocumentCompleted;         
            //this.Controls.Add(wbeng);

            //speakvn = new SpeakText(wbvn);
            //speakeng = new SpeakText(wbeng);
            #endregion
        }
        #region webbroswer demo 2
        // private void Wbeng_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        // {
        //     loading1 = false;
        //     changeloading();
        // }

        // private void Wbvn_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        // {
        //     loading2 = false;
        //     changeloading();
        // }

        // void changeloading()
        // {
        //     this.Enabled = !(loading2 && loading1);
        // }
        #endregion
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = cbWord as ComboBox;

            if (cb.DataSource == null)
                return;

            DictData data = cb.SelectedItem as DictData;
            string data1 = "/"+data.Mean.ToString().Replace("*","\r\n*").Replace("=", "\r\n= ").Replace("-", "\r\n- ");
            tbMean.Text = data1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            SpeechSynthesizer sp = new SpeechSynthesizer();
            #region setGenderAge
            switch (gt)
            {
                case "Male":
                    sp.SelectVoiceByHints(VoiceGender.Male);
                    switch (tuoi)
                    {
                        case "Adult":
                            sp.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
                            break;
                        case "Child":
                            sp.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Child);
                            break;
                        case "Default":
                            sp.SelectVoiceByHints(VoiceGender.Male, VoiceAge.NotSet);
                            break;
                        case "Senior":
                            sp.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior);
                            break;
                        case "Teen":
                            sp.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Teen);
                            break;
                    }
                    break;
                case "Female":
                    sp.SelectVoiceByHints(VoiceGender.Female);
                    switch (tuoi)
                    {
                        case "Adult":
                            sp.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                            break;
                        case "Child":
                            sp.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);
                            break;
                        case "Default":
                            sp.SelectVoiceByHints(VoiceGender.Female, VoiceAge.NotSet);
                            break;
                        case "Senior":
                            sp.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);
                            break;
                        case "Teen":
                            sp.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                            break;
                    }
                    break;
                case "Neutral":
                    sp.SelectVoiceByHints(VoiceGender.Neutral);
                    switch (tuoi)
                    {
                        case "Adult":
                            sp.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.Adult);
                            break;
                        case "Child":
                            sp.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.Child);
                            break;
                        case "Default":
                            sp.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.NotSet);
                            break;
                        case "Senior":
                            sp.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.Senior);
                            break;
                        case "Teen":
                            sp.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.Teen);
                            break;
                    }
                    break;
                case "Default":
                    sp.SelectVoiceByHints(VoiceGender.NotSet);
                    switch (tuoi)
                    {
                        case "Adult":
                            sp.SelectVoiceByHints(VoiceGender.NotSet, VoiceAge.Adult);
                            break;
                        case "Child":
                            sp.SelectVoiceByHints(VoiceGender.NotSet, VoiceAge.Child);
                            break;
                        case "Default":
                            sp.SelectVoiceByHints(VoiceGender.NotSet, VoiceAge.NotSet);
                            break;
                        case "Senior":
                            sp.SelectVoiceByHints(VoiceGender.NotSet, VoiceAge.Senior);
                            break;
                        case "Teen":
                            sp.SelectVoiceByHints(VoiceGender.NotSet, VoiceAge.Teen);
                            break;
                    }
                    break;

            }
            #endregion
            sp.Speak((cbWord.SelectedItem as DictData).Key);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?" , "Thông báo" , MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }       
        private void btimage_Click(object sender, EventArgs e)
        {

            if (InternetConnection.IsConnectedToInternet())
            {
                if ((cbWord.SelectedItem as DictData).Key != null)
                {
                    string data = (cbWord.SelectedItem as DictData).Key;
                    Form2 forma = new Form2(data);
                    forma.Show();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại. Bạn cần kết nối Internet để sử dụng tính năng này.", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 formtt = new Form4();
            formtt.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (InternetConnection.IsConnectedToInternet())
            {
                if ((cbWord.SelectedItem as DictData).Key != null)
                {
                    string data = (cbWord.SelectedItem as DictData).Key;
                    Form3 formb = new Form3(data);
                    formb.Show();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại. Bạn cần kết nối Internet để sử dụng tính năng này.", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #region stripMenu
        private void voiceSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void tuổiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tuoi = "Adult";
            MessageBox.Show("Bạn đã set thành công VoiceAge: Adult ", "Thông báo", MessageBoxButtons.OK);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void childToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tuoi = "Child";
            MessageBox.Show("Bạn đã set thành công VoiceAge: Child", "Thông báo", MessageBoxButtons.OK);
        }

        private void seniorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tuoi = "Senior";
            MessageBox.Show("Bạn đã set thành công VoiceAge: Senior", "Thông báo", MessageBoxButtons.OK);
        }

        private void teenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tuoi = "Teen";
            MessageBox.Show("Bạn đã set thành công VoiceAge: Teen", "Thông báo", MessageBoxButtons.OK);
        }

        private void defaultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tuoi = "Default";
            MessageBox.Show("Bạn đã set thành công VoiceAge: Default", "Thông báo", MessageBoxButtons.OK);
        }

        private void maleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gt = "Male";
            MessageBox.Show("Bạn đã set thành công VoiceGender: Male", "Thông báo", MessageBoxButtons.OK);
        }

        private void femaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gt = "Female";
            MessageBox.Show("Bạn đã set thành công VoiceGender: Female", "Thông báo", MessageBoxButtons.OK);
        }

        private void neutralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gt = "Neutral";
            MessageBox.Show("Bạn đã set thành công VoiceGender: Neutral", "Thông báo", MessageBoxButtons.OK);
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gt = "Default";
            MessageBox.Show("Bạn đã set thành công VoiceGender: Default", "Thông báo", MessageBoxButtons.OK);
        }
        #endregion

        private void tbMean_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }
    }
}
