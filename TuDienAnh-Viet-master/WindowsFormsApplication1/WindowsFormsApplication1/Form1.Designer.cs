namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnspkEng = new System.Windows.Forms.Button();
            this.cbWord = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbTrans = new System.Windows.Forms.TextBox();
            this.buttonSpkTrans = new System.Windows.Forms.Button();
            this.tbMean = new System.Windows.Forms.TextBox();
            this.btnSpkMean = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnspkEng);
            this.panel1.Controls.Add(this.cbWord);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnspkEng
            // 
            this.btnspkEng.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.kisspng_emoji_loudspeaker_sound_unicode_symbol_5ae58e97a5e8d0_4828862015249936876796;
            resources.ApplyResources(this.btnspkEng, "btnspkEng");
            this.btnspkEng.Name = "btnspkEng";
            this.btnspkEng.UseVisualStyleBackColor = true;
            this.btnspkEng.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbWord
            // 
            this.cbWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbWord.FormattingEnabled = true;
            resources.ApplyResources(this.cbWord, "cbWord");
            this.cbWord.Name = "cbWord";
            this.cbWord.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tbTrans);
            this.flowLayoutPanel1.Controls.Add(this.buttonSpkTrans);
            this.flowLayoutPanel1.Controls.Add(this.tbMean);
            this.flowLayoutPanel1.Controls.Add(this.btnSpkMean);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // tbTrans
            // 
            resources.ApplyResources(this.tbTrans, "tbTrans");
            this.tbTrans.Name = "tbTrans";
            // 
            // buttonSpkTrans
            // 
            this.buttonSpkTrans.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.kisspng_emoji_loudspeaker_sound_unicode_symbol_5ae58e97a5e8d0_4828862015249936876796;
            resources.ApplyResources(this.buttonSpkTrans, "buttonSpkTrans");
            this.buttonSpkTrans.Name = "buttonSpkTrans";
            this.buttonSpkTrans.UseVisualStyleBackColor = true;
            this.buttonSpkTrans.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbMean
            // 
            resources.ApplyResources(this.tbMean, "tbMean");
            this.tbMean.Name = "tbMean";
            // 
            // btnSpkMean
            // 
            this.btnSpkMean.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.kisspng_emoji_loudspeaker_sound_unicode_symbol_5ae58e97a5e8d0_4828862015249936876796;
            resources.ApplyResources(this.btnSpkMean, "btnSpkMean");
            this.btnSpkMean.Name = "btnSpkMean";
            this.btnSpkMean.UseVisualStyleBackColor = true;
            this.btnSpkMean.Click += new System.EventHandler(this.btnSpkMean_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbWord;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tbTrans;
        private System.Windows.Forms.TextBox tbMean;
        private System.Windows.Forms.Button btnspkEng;
        private System.Windows.Forms.Button buttonSpkTrans;
        private System.Windows.Forms.Button btnSpkMean;
    }
}

