namespace WindowsFormsApplication1 {     partial class Form1     {         /// <summary>         /// Required designer variable.         /// </summary>         private System.ComponentModel.IContainer components = null;          /// <summary>         /// Clean up any resources being used.         /// </summary>         /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>         protected override void Dispose(bool disposing)         {             if (disposing && (components != null))             {                 components.Dispose();             }             base.Dispose(disposing);         }          #region Windows Form Designer generated code          /// <summary>         /// Required method for Designer support - do not modify         /// the contents of this method with the code editor.         /// </summary>         private void InitializeComponent()         {             System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnspkEng = new System.Windows.Forms.Button();
            this.cbWord = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btimage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbMean = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voiceSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiTínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.femaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neutralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tuổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.childToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seniorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            resources.ApplyResources(this.cbWord, "cbWord");
            this.cbWord.FormattingEnabled = true;
            this.cbWord.Name = "cbWord";
            this.cbWord.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btimage);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.tbMean);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btimage
            // 
            resources.ApplyResources(this.btimage, "btimage");
            this.btimage.Name = "btimage";
            this.btimage.UseVisualStyleBackColor = true;
            this.btimage.Click += new System.EventHandler(this.btimage_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbMean
            // 
            this.tbMean.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.tbMean, "tbMean");
            this.tbMean.Name = "tbMean";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voiceSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            // 
            // voiceSettingsToolStripMenuItem
            // 
            this.voiceSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giớiTínhToolStripMenuItem,
            this.tuổiToolStripMenuItem});
            this.voiceSettingsToolStripMenuItem.Name = "voiceSettingsToolStripMenuItem";
            resources.ApplyResources(this.voiceSettingsToolStripMenuItem, "voiceSettingsToolStripMenuItem");
            this.voiceSettingsToolStripMenuItem.Click += new System.EventHandler(this.voiceSettingsToolStripMenuItem_Click);
            // 
            // giớiTínhToolStripMenuItem
            // 
            this.giớiTínhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maleToolStripMenuItem,
            this.femaleToolStripMenuItem,
            this.neutralToolStripMenuItem,
            this.defaultToolStripMenuItem});
            this.giớiTínhToolStripMenuItem.Name = "giớiTínhToolStripMenuItem";
            resources.ApplyResources(this.giớiTínhToolStripMenuItem, "giớiTínhToolStripMenuItem");
            // 
            // maleToolStripMenuItem
            // 
            this.maleToolStripMenuItem.Name = "maleToolStripMenuItem";
            resources.ApplyResources(this.maleToolStripMenuItem, "maleToolStripMenuItem");
            this.maleToolStripMenuItem.Click += new System.EventHandler(this.maleToolStripMenuItem_Click);
            // 
            // femaleToolStripMenuItem
            // 
            this.femaleToolStripMenuItem.Name = "femaleToolStripMenuItem";
            resources.ApplyResources(this.femaleToolStripMenuItem, "femaleToolStripMenuItem");
            this.femaleToolStripMenuItem.Click += new System.EventHandler(this.femaleToolStripMenuItem_Click);
            // 
            // neutralToolStripMenuItem
            // 
            this.neutralToolStripMenuItem.Name = "neutralToolStripMenuItem";
            resources.ApplyResources(this.neutralToolStripMenuItem, "neutralToolStripMenuItem");
            this.neutralToolStripMenuItem.Click += new System.EventHandler(this.neutralToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            resources.ApplyResources(this.defaultToolStripMenuItem, "defaultToolStripMenuItem");
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // tuổiToolStripMenuItem
            // 
            this.tuổiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.childToolStripMenuItem,
            this.seniorToolStripMenuItem,
            this.teenToolStripMenuItem,
            this.defaultToolStripMenuItem1});
            this.tuổiToolStripMenuItem.Name = "tuổiToolStripMenuItem";
            resources.ApplyResources(this.tuổiToolStripMenuItem, "tuổiToolStripMenuItem");
            this.tuổiToolStripMenuItem.Click += new System.EventHandler(this.tuổiToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            resources.ApplyResources(this.aToolStripMenuItem, "aToolStripMenuItem");
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // childToolStripMenuItem
            // 
            this.childToolStripMenuItem.Name = "childToolStripMenuItem";
            resources.ApplyResources(this.childToolStripMenuItem, "childToolStripMenuItem");
            this.childToolStripMenuItem.Click += new System.EventHandler(this.childToolStripMenuItem_Click);
            // 
            // seniorToolStripMenuItem
            // 
            this.seniorToolStripMenuItem.Name = "seniorToolStripMenuItem";
            resources.ApplyResources(this.seniorToolStripMenuItem, "seniorToolStripMenuItem");
            this.seniorToolStripMenuItem.Click += new System.EventHandler(this.seniorToolStripMenuItem_Click);
            // 
            // teenToolStripMenuItem
            // 
            this.teenToolStripMenuItem.Name = "teenToolStripMenuItem";
            resources.ApplyResources(this.teenToolStripMenuItem, "teenToolStripMenuItem");
            this.teenToolStripMenuItem.Click += new System.EventHandler(this.teenToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem1
            // 
            this.defaultToolStripMenuItem1.Name = "defaultToolStripMenuItem1";
            resources.ApplyResources(this.defaultToolStripMenuItem1, "defaultToolStripMenuItem1");
            this.defaultToolStripMenuItem1.Click += new System.EventHandler(this.defaultToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }          #endregion          private System.Windows.Forms.Panel panel1;         private System.Windows.Forms.ComboBox cbWord;         private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;         private System.Windows.Forms.Button btnspkEng;         private System.Windows.Forms.Button btimage;         private System.Windows.Forms.Button button1;         private System.Windows.Forms.Button button2;         private System.Windows.Forms.Label label1;         private System.Windows.Forms.MenuStrip menuStrip1;         private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;         private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;         private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;         private System.Windows.Forms.ToolStripMenuItem voiceSettingsToolStripMenuItem;         private System.Windows.Forms.ToolStripMenuItem giớiTínhToolStripMenuItem;         private System.Windows.Forms.ToolStripMenuItem maleToolStripMenuItem;         private System.Windows.Forms.ToolStripMenuItem femaleToolStripMenuItem;         private System.Windows.Forms.ToolStripMenuItem neutralToolStripMenuItem;         private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;         private System.Windows.Forms.ToolStripMenuItem tuổiToolStripMenuItem;         private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;         private System.Windows.Forms.ToolStripMenuItem childToolStripMenuItem;         private System.Windows.Forms.ToolStripMenuItem seniorToolStripMenuItem;         private System.Windows.Forms.ToolStripMenuItem teenToolStripMenuItem;         private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem1;
        private System.Windows.Forms.Label tbMean;
    } }  