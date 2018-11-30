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
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 507);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnspkEng
            // 
            this.btnspkEng.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.kisspng_emoji_loudspeaker_sound_unicode_symbol_5ae58e97a5e8d0_4828862015249936876796;
            this.btnspkEng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnspkEng.Location = new System.Drawing.Point(164, 3);
            this.btnspkEng.Name = "btnspkEng";
            this.btnspkEng.Size = new System.Drawing.Size(33, 25);
            this.btnspkEng.TabIndex = 1;
            this.btnspkEng.UseVisualStyleBackColor = true;
            this.btnspkEng.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbWord
            // 
            this.cbWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbWord.FormattingEnabled = true;
            this.cbWord.Location = new System.Drawing.Point(0, 4);
            this.cbWord.Name = "cbWord";
            this.cbWord.Size = new System.Drawing.Size(158, 505);
            this.cbWord.TabIndex = 0;
            this.cbWord.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tbTrans);
            this.flowLayoutPanel1.Controls.Add(this.buttonSpkTrans);
            this.flowLayoutPanel1.Controls.Add(this.tbMean);
            this.flowLayoutPanel1.Controls.Add(this.btnSpkMean);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(218, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(575, 507);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tbTrans
            // 
            this.tbTrans.Location = new System.Drawing.Point(3, 3);
            this.tbTrans.Name = "tbTrans";
            this.tbTrans.Size = new System.Drawing.Size(519, 22);
            this.tbTrans.TabIndex = 1;
            // 
            // buttonSpkTrans
            // 
            this.buttonSpkTrans.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.kisspng_emoji_loudspeaker_sound_unicode_symbol_5ae58e97a5e8d0_4828862015249936876796;
            this.buttonSpkTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSpkTrans.Location = new System.Drawing.Point(528, 3);
            this.buttonSpkTrans.Name = "buttonSpkTrans";
            this.buttonSpkTrans.Size = new System.Drawing.Size(33, 25);
            this.buttonSpkTrans.TabIndex = 2;
            this.buttonSpkTrans.UseVisualStyleBackColor = true;
            this.buttonSpkTrans.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbMean
            // 
            this.tbMean.Location = new System.Drawing.Point(3, 34);
            this.tbMean.Multiline = true;
            this.tbMean.Name = "tbMean";
            this.tbMean.Size = new System.Drawing.Size(519, 463);
            this.tbMean.TabIndex = 0;
            // 
            // btnSpkMean
            // 
            this.btnSpkMean.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.kisspng_emoji_loudspeaker_sound_unicode_symbol_5ae58e97a5e8d0_4828862015249936876796;
            this.btnSpkMean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpkMean.Location = new System.Drawing.Point(528, 34);
            this.btnSpkMean.Name = "btnSpkMean";
            this.btnSpkMean.Size = new System.Drawing.Size(33, 25);
            this.btnSpkMean.TabIndex = 3;
            this.btnSpkMean.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 526);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Anh - Việt | Dictionary";
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

