namespace MMForm
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
            this.SaveGun_btn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gunPathData_tbx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameGun_cbx = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fillGun_btn = new System.Windows.Forms.Button();
            this.removegun_btn = new System.Windows.Forms.Button();
            this.addgun_btn = new System.Windows.Forms.Button();
            this.InitGun_btn = new System.Windows.Forms.Button();
            this.value_tbx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gunListView = new BrightIdeasSoftware.FastObjectListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.playersaveObjec_lv = new BrightIdeasSoftware.FastObjectListView();
            this.setting_tbx = new System.Windows.Forms.TextBox();
            this.playerdatafile_tbx = new System.Windows.Forms.TextBox();
            this.player_tbx = new System.Windows.Forms.TextBox();
            this.SavePlayer_btn = new System.Windows.Forms.Button();
            this.LoadPlaye_btn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botskin_pnl = new System.Windows.Forms.Panel();
            this.filBotValue_tbx = new System.Windows.Forms.TextBox();
            this.EditCommand_btn = new System.Windows.Forms.Button();
            this.EditSkin_btn = new System.Windows.Forms.Button();
            this.fillbotColumn_btn = new System.Windows.Forms.Button();
            this.botColumn_cbx = new System.Windows.Forms.ComboBox();
            this.bot_olv = new BrightIdeasSoftware.FastObjectListView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.itemmap_cbx = new System.Windows.Forms.ComboBox();
            this.RemoveItem_btn = new System.Windows.Forms.Button();
            this.AddItem = new System.Windows.Forms.Button();
            this.item_olv = new BrightIdeasSoftware.FastObjectListView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.weapon_tbx = new System.Windows.Forms.TextBox();
            this.playery_tbx = new System.Windows.Forms.TextBox();
            this.playerx_tbx = new System.Windows.Forms.TextBox();
            this.mapSound_tbx = new System.Windows.Forms.TextBox();
            this.maptype_tbx = new System.Windows.Forms.TextBox();
            this.mapname_tbx = new System.Windows.Forms.TextBox();
            this.SaveMap_btn = new System.Windows.Forms.Button();
            this.LoadMap_btn = new System.Windows.Forms.Button();
            this.mapid_tbx = new System.Windows.Forms.TextBox();
            this.mapFolder_tbx = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.log_rtb = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.secondwpd_tbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.playerdata_tbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UpdateMap_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunListView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersaveObjec_lv)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bot_olv)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_olv)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveGun_btn
            // 
            this.SaveGun_btn.Location = new System.Drawing.Point(81, 44);
            this.SaveGun_btn.Name = "SaveGun_btn";
            this.SaveGun_btn.Size = new System.Drawing.Size(48, 23);
            this.SaveGun_btn.TabIndex = 0;
            this.SaveGun_btn.Text = "Save";
            this.SaveGun_btn.UseVisualStyleBackColor = true;
            this.SaveGun_btn.Click += new System.EventHandler(this.SaveGun_btn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(838, 354);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gunPathData_tbx);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gunListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(830, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gun";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gunPathData_tbx
            // 
            this.gunPathData_tbx.Location = new System.Drawing.Point(8, 3);
            this.gunPathData_tbx.Name = "gunPathData_tbx";
            this.gunPathData_tbx.Size = new System.Drawing.Size(503, 20);
            this.gunPathData_tbx.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nameGun_cbx);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.fillGun_btn);
            this.groupBox1.Controls.Add(this.removegun_btn);
            this.groupBox1.Controls.Add(this.addgun_btn);
            this.groupBox1.Controls.Add(this.InitGun_btn);
            this.groupBox1.Controls.Add(this.SaveGun_btn);
            this.groupBox1.Controls.Add(this.value_tbx);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(539, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 319);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // nameGun_cbx
            // 
            this.nameGun_cbx.FormattingEnabled = true;
            this.nameGun_cbx.Location = new System.Drawing.Point(8, 18);
            this.nameGun_cbx.Name = "nameGun_cbx";
            this.nameGun_cbx.Size = new System.Drawing.Size(105, 21);
            this.nameGun_cbx.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(6, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 184);
            this.panel1.TabIndex = 3;
            // 
            // fillGun_btn
            // 
            this.fillGun_btn.Location = new System.Drawing.Point(81, 71);
            this.fillGun_btn.Name = "fillGun_btn";
            this.fillGun_btn.Size = new System.Drawing.Size(45, 23);
            this.fillGun_btn.TabIndex = 0;
            this.fillGun_btn.Text = "Fill";
            this.fillGun_btn.UseVisualStyleBackColor = true;
            this.fillGun_btn.Click += new System.EventHandler(this.fillGun_btn_Click);
            // 
            // removegun_btn
            // 
            this.removegun_btn.Location = new System.Drawing.Point(81, 100);
            this.removegun_btn.Name = "removegun_btn";
            this.removegun_btn.Size = new System.Drawing.Size(58, 23);
            this.removegun_btn.TabIndex = 0;
            this.removegun_btn.Text = "Remove";
            this.removegun_btn.UseVisualStyleBackColor = true;
            this.removegun_btn.Click += new System.EventHandler(this.removegun_btn_Click);
            // 
            // addgun_btn
            // 
            this.addgun_btn.Location = new System.Drawing.Point(8, 100);
            this.addgun_btn.Name = "addgun_btn";
            this.addgun_btn.Size = new System.Drawing.Size(45, 23);
            this.addgun_btn.TabIndex = 0;
            this.addgun_btn.Text = "Add";
            this.addgun_btn.UseVisualStyleBackColor = true;
            this.addgun_btn.Click += new System.EventHandler(this.addgun_btn_Click);
            // 
            // InitGun_btn
            // 
            this.InitGun_btn.Location = new System.Drawing.Point(132, 71);
            this.InitGun_btn.Name = "InitGun_btn";
            this.InitGun_btn.Size = new System.Drawing.Size(45, 23);
            this.InitGun_btn.TabIndex = 0;
            this.InitGun_btn.Text = "Init";
            this.InitGun_btn.UseVisualStyleBackColor = true;
            this.InitGun_btn.Click += new System.EventHandler(this.InitGun_btn_Click);
            // 
            // value_tbx
            // 
            this.value_tbx.Location = new System.Drawing.Point(119, 18);
            this.value_tbx.Name = "value_tbx";
            this.value_tbx.Size = new System.Drawing.Size(48, 20);
            this.value_tbx.TabIndex = 2;
            this.value_tbx.Text = "30";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "LoadGun";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gunListView
            // 
            this.gunListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.gunListView.Location = new System.Drawing.Point(3, 24);
            this.gunListView.Name = "gunListView";
            this.gunListView.ShowGroups = false;
            this.gunListView.Size = new System.Drawing.Size(530, 300);
            this.gunListView.TabIndex = 3;
            this.gunListView.UseCompatibleStateImageBehavior = false;
            this.gunListView.View = System.Windows.Forms.View.Details;
            this.gunListView.VirtualMode = true;
            this.gunListView.SelectedIndexChanged += new System.EventHandler(this.gunListView_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.playersaveObjec_lv);
            this.tabPage2.Controls.Add(this.setting_tbx);
            this.tabPage2.Controls.Add(this.playerdatafile_tbx);
            this.tabPage2.Controls.Add(this.player_tbx);
            this.tabPage2.Controls.Add(this.SavePlayer_btn);
            this.tabPage2.Controls.Add(this.LoadPlaye_btn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(830, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "player";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // playersaveObjec_lv
            // 
            this.playersaveObjec_lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playersaveObjec_lv.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only;
            this.playersaveObjec_lv.Location = new System.Drawing.Point(0, 36);
            this.playersaveObjec_lv.Name = "playersaveObjec_lv";
            this.playersaveObjec_lv.ShowGroups = false;
            this.playersaveObjec_lv.Size = new System.Drawing.Size(585, 288);
            this.playersaveObjec_lv.TabIndex = 2;
            this.playersaveObjec_lv.UseCompatibleStateImageBehavior = false;
            this.playersaveObjec_lv.View = System.Windows.Forms.View.Details;
            this.playersaveObjec_lv.VirtualMode = true;
            // 
            // setting_tbx
            // 
            this.setting_tbx.Location = new System.Drawing.Point(607, 115);
            this.setting_tbx.Name = "setting_tbx";
            this.setting_tbx.Size = new System.Drawing.Size(200, 20);
            this.setting_tbx.TabIndex = 1;
            // 
            // playerdatafile_tbx
            // 
            this.playerdatafile_tbx.Location = new System.Drawing.Point(8, 9);
            this.playerdatafile_tbx.Name = "playerdatafile_tbx";
            this.playerdatafile_tbx.Size = new System.Drawing.Size(533, 20);
            this.playerdatafile_tbx.TabIndex = 1;
            // 
            // player_tbx
            // 
            this.player_tbx.Location = new System.Drawing.Point(607, 52);
            this.player_tbx.Name = "player_tbx";
            this.player_tbx.Size = new System.Drawing.Size(200, 20);
            this.player_tbx.TabIndex = 1;
            // 
            // SavePlayer_btn
            // 
            this.SavePlayer_btn.Location = new System.Drawing.Point(732, 6);
            this.SavePlayer_btn.Name = "SavePlayer_btn";
            this.SavePlayer_btn.Size = new System.Drawing.Size(75, 23);
            this.SavePlayer_btn.TabIndex = 0;
            this.SavePlayer_btn.Text = "Save";
            this.SavePlayer_btn.UseVisualStyleBackColor = true;
            this.SavePlayer_btn.Click += new System.EventHandler(this.SavePlayer_btn_Click);
            // 
            // LoadPlaye_btn
            // 
            this.LoadPlaye_btn.Location = new System.Drawing.Point(607, 6);
            this.LoadPlaye_btn.Name = "LoadPlaye_btn";
            this.LoadPlaye_btn.Size = new System.Drawing.Size(75, 23);
            this.LoadPlaye_btn.TabIndex = 0;
            this.LoadPlaye_btn.Text = "Load";
            this.LoadPlaye_btn.UseVisualStyleBackColor = true;
            this.LoadPlaye_btn.Click += new System.EventHandler(this.LoadPlaye_btn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl3);
            this.tabPage3.Controls.Add(this.SaveMap_btn);
            this.tabPage3.Controls.Add(this.LoadMap_btn);
            this.tabPage3.Controls.Add(this.mapid_tbx);
            this.tabPage3.Controls.Add(this.mapFolder_tbx);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(830, 328);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Map";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Location = new System.Drawing.Point(0, 29);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(830, 295);
            this.tabControl3.TabIndex = 2;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox2);
            this.tabPage6.Controls.Add(this.bot_olv);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(822, 269);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Bot";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.botskin_pnl);
            this.groupBox2.Controls.Add(this.filBotValue_tbx);
            this.groupBox2.Controls.Add(this.EditCommand_btn);
            this.groupBox2.Controls.Add(this.EditSkin_btn);
            this.groupBox2.Controls.Add(this.fillbotColumn_btn);
            this.groupBox2.Controls.Add(this.botColumn_cbx);
            this.groupBox2.Location = new System.Drawing.Point(589, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 263);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // botskin_pnl
            // 
            this.botskin_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botskin_pnl.Location = new System.Drawing.Point(6, 158);
            this.botskin_pnl.Name = "botskin_pnl";
            this.botskin_pnl.Size = new System.Drawing.Size(231, 105);
            this.botskin_pnl.TabIndex = 7;
            // 
            // filBotValue_tbx
            // 
            this.filBotValue_tbx.Location = new System.Drawing.Point(6, 43);
            this.filBotValue_tbx.Name = "filBotValue_tbx";
            this.filBotValue_tbx.Size = new System.Drawing.Size(100, 20);
            this.filBotValue_tbx.TabIndex = 6;
            // 
            // EditCommand_btn
            // 
            this.EditCommand_btn.Location = new System.Drawing.Point(6, 98);
            this.EditCommand_btn.Name = "EditCommand_btn";
            this.EditCommand_btn.Size = new System.Drawing.Size(137, 25);
            this.EditCommand_btn.TabIndex = 1;
            this.EditCommand_btn.Text = "EditCommand";
            this.EditCommand_btn.UseVisualStyleBackColor = true;
            this.EditCommand_btn.Click += new System.EventHandler(this.EditCommand_btn_Click);
            // 
            // EditSkin_btn
            // 
            this.EditSkin_btn.Location = new System.Drawing.Point(6, 129);
            this.EditSkin_btn.Name = "EditSkin_btn";
            this.EditSkin_btn.Size = new System.Drawing.Size(137, 23);
            this.EditSkin_btn.TabIndex = 1;
            this.EditSkin_btn.Text = "EditSkin";
            this.EditSkin_btn.UseVisualStyleBackColor = true;
            this.EditSkin_btn.Click += new System.EventHandler(this.EditSkin_btn_Click);
            // 
            // fillbotColumn_btn
            // 
            this.fillbotColumn_btn.Location = new System.Drawing.Point(6, 69);
            this.fillbotColumn_btn.Name = "fillbotColumn_btn";
            this.fillbotColumn_btn.Size = new System.Drawing.Size(105, 23);
            this.fillbotColumn_btn.TabIndex = 1;
            this.fillbotColumn_btn.Text = "FilbotColumn";
            this.fillbotColumn_btn.UseVisualStyleBackColor = true;
            this.fillbotColumn_btn.Click += new System.EventHandler(this.fillbotColumn_btn_Click);
            // 
            // botColumn_cbx
            // 
            this.botColumn_cbx.FormattingEnabled = true;
            this.botColumn_cbx.Location = new System.Drawing.Point(6, 19);
            this.botColumn_cbx.Name = "botColumn_cbx";
            this.botColumn_cbx.Size = new System.Drawing.Size(105, 21);
            this.botColumn_cbx.TabIndex = 5;
            // 
            // bot_olv
            // 
            this.bot_olv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bot_olv.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only;
            this.bot_olv.Location = new System.Drawing.Point(-1, 0);
            this.bot_olv.Name = "bot_olv";
            this.bot_olv.ShowGroups = false;
            this.bot_olv.Size = new System.Drawing.Size(584, 266);
            this.bot_olv.TabIndex = 0;
            this.bot_olv.UseCompatibleStateImageBehavior = false;
            this.bot_olv.View = System.Windows.Forms.View.Details;
            this.bot_olv.VirtualMode = true;
            this.bot_olv.SelectedIndexChanged += new System.EventHandler(this.bot_olv_SelectedIndexChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox3);
            this.tabPage7.Controls.Add(this.item_olv);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(822, 269);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "item";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.itemmap_cbx);
            this.groupBox3.Controls.Add(this.RemoveItem_btn);
            this.groupBox3.Controls.Add(this.AddItem);
            this.groupBox3.Location = new System.Drawing.Point(668, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 263);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // itemmap_cbx
            // 
            this.itemmap_cbx.FormattingEnabled = true;
            this.itemmap_cbx.Location = new System.Drawing.Point(22, 19);
            this.itemmap_cbx.Name = "itemmap_cbx";
            this.itemmap_cbx.Size = new System.Drawing.Size(103, 21);
            this.itemmap_cbx.TabIndex = 2;
            // 
            // RemoveItem_btn
            // 
            this.RemoveItem_btn.Location = new System.Drawing.Point(34, 118);
            this.RemoveItem_btn.Name = "RemoveItem_btn";
            this.RemoveItem_btn.Size = new System.Drawing.Size(75, 23);
            this.RemoveItem_btn.TabIndex = 1;
            this.RemoveItem_btn.Text = "Remove";
            this.RemoveItem_btn.UseVisualStyleBackColor = true;
            this.RemoveItem_btn.Click += new System.EventHandler(this.RemoveItem_btn_Click);
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(34, 58);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(75, 23);
            this.AddItem.TabIndex = 1;
            this.AddItem.Text = "Add";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // item_olv
            // 
            this.item_olv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.item_olv.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.item_olv.Location = new System.Drawing.Point(-1, 10);
            this.item_olv.Name = "item_olv";
            this.item_olv.ShowGroups = false;
            this.item_olv.Size = new System.Drawing.Size(663, 263);
            this.item_olv.TabIndex = 0;
            this.item_olv.UseCompatibleStateImageBehavior = false;
            this.item_olv.View = System.Windows.Forms.View.Details;
            this.item_olv.VirtualMode = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label3);
            this.tabPage8.Controls.Add(this.label8);
            this.tabPage8.Controls.Add(this.UpdateMap_btn);
            this.tabPage8.Controls.Add(this.label7);
            this.tabPage8.Controls.Add(this.label6);
            this.tabPage8.Controls.Add(this.label5);
            this.tabPage8.Controls.Add(this.label4);
            this.tabPage8.Controls.Add(this.label2);
            this.tabPage8.Controls.Add(this.playerdata_tbx);
            this.tabPage8.Controls.Add(this.label1);
            this.tabPage8.Controls.Add(this.secondwpd_tbx);
            this.tabPage8.Controls.Add(this.weapon_tbx);
            this.tabPage8.Controls.Add(this.playery_tbx);
            this.tabPage8.Controls.Add(this.playerx_tbx);
            this.tabPage8.Controls.Add(this.mapSound_tbx);
            this.tabPage8.Controls.Add(this.maptype_tbx);
            this.tabPage8.Controls.Add(this.mapname_tbx);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(822, 269);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "data";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // weapon_tbx
            // 
            this.weapon_tbx.Location = new System.Drawing.Point(294, 76);
            this.weapon_tbx.Name = "weapon_tbx";
            this.weapon_tbx.Size = new System.Drawing.Size(100, 20);
            this.weapon_tbx.TabIndex = 0;
            // 
            // playery_tbx
            // 
            this.playery_tbx.Location = new System.Drawing.Point(294, 50);
            this.playery_tbx.Name = "playery_tbx";
            this.playery_tbx.Size = new System.Drawing.Size(100, 20);
            this.playery_tbx.TabIndex = 0;
            // 
            // playerx_tbx
            // 
            this.playerx_tbx.Location = new System.Drawing.Point(294, 24);
            this.playerx_tbx.Name = "playerx_tbx";
            this.playerx_tbx.Size = new System.Drawing.Size(100, 20);
            this.playerx_tbx.TabIndex = 0;
            // 
            // mapSound_tbx
            // 
            this.mapSound_tbx.Location = new System.Drawing.Point(100, 76);
            this.mapSound_tbx.Name = "mapSound_tbx";
            this.mapSound_tbx.Size = new System.Drawing.Size(100, 20);
            this.mapSound_tbx.TabIndex = 0;
            // 
            // maptype_tbx
            // 
            this.maptype_tbx.Location = new System.Drawing.Point(100, 50);
            this.maptype_tbx.Name = "maptype_tbx";
            this.maptype_tbx.Size = new System.Drawing.Size(100, 20);
            this.maptype_tbx.TabIndex = 0;
            // 
            // mapname_tbx
            // 
            this.mapname_tbx.Location = new System.Drawing.Point(100, 24);
            this.mapname_tbx.Name = "mapname_tbx";
            this.mapname_tbx.Size = new System.Drawing.Size(100, 20);
            this.mapname_tbx.TabIndex = 0;
            // 
            // SaveMap_btn
            // 
            this.SaveMap_btn.Location = new System.Drawing.Point(737, 3);
            this.SaveMap_btn.Name = "SaveMap_btn";
            this.SaveMap_btn.Size = new System.Drawing.Size(75, 23);
            this.SaveMap_btn.TabIndex = 1;
            this.SaveMap_btn.Text = "Save";
            this.SaveMap_btn.UseVisualStyleBackColor = true;
            this.SaveMap_btn.Click += new System.EventHandler(this.SaveMap_btn_Click);
            // 
            // LoadMap_btn
            // 
            this.LoadMap_btn.Location = new System.Drawing.Point(656, 3);
            this.LoadMap_btn.Name = "LoadMap_btn";
            this.LoadMap_btn.Size = new System.Drawing.Size(75, 23);
            this.LoadMap_btn.TabIndex = 1;
            this.LoadMap_btn.Text = "Load";
            this.LoadMap_btn.UseVisualStyleBackColor = true;
            this.LoadMap_btn.Click += new System.EventHandler(this.LoadMap_btn_Click);
            // 
            // mapid_tbx
            // 
            this.mapid_tbx.Location = new System.Drawing.Point(480, 5);
            this.mapid_tbx.Name = "mapid_tbx";
            this.mapid_tbx.Size = new System.Drawing.Size(55, 20);
            this.mapid_tbx.TabIndex = 0;
            // 
            // mapFolder_tbx
            // 
            this.mapFolder_tbx.Location = new System.Drawing.Point(3, 3);
            this.mapFolder_tbx.Name = "mapFolder_tbx";
            this.mapFolder_tbx.Size = new System.Drawing.Size(372, 20);
            this.mapFolder_tbx.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl2.Location = new System.Drawing.Point(0, 352);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(838, 154);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.log_rtb);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(830, 128);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // log_rtb
            // 
            this.log_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log_rtb.Location = new System.Drawing.Point(3, 3);
            this.log_rtb.Name = "log_rtb";
            this.log_rtb.Size = new System.Drawing.Size(824, 122);
            this.log_rtb.TabIndex = 0;
            this.log_rtb.Text = "";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(830, 128);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "mapname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "maptype";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "mapsound";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "player X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "player Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "weaponid";
            // 
            // secondwpd_tbx
            // 
            this.secondwpd_tbx.Location = new System.Drawing.Point(294, 112);
            this.secondwpd_tbx.Name = "secondwpd_tbx";
            this.secondwpd_tbx.Size = new System.Drawing.Size(100, 20);
            this.secondwpd_tbx.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "second weaponid";
            // 
            // playerdata_tbx
            // 
            this.playerdata_tbx.Location = new System.Drawing.Point(294, 143);
            this.playerdata_tbx.Name = "playerdata_tbx";
            this.playerdata_tbx.Size = new System.Drawing.Size(264, 20);
            this.playerdata_tbx.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "playerdata";
            // 
            // UpdateMap_btn
            // 
            this.UpdateMap_btn.Location = new System.Drawing.Point(20, 190);
            this.UpdateMap_btn.Name = "UpdateMap_btn";
            this.UpdateMap_btn.Size = new System.Drawing.Size(75, 23);
            this.UpdateMap_btn.TabIndex = 1;
            this.UpdateMap_btn.Text = "Update";
            this.UpdateMap_btn.UseVisualStyleBackColor = true;
            this.UpdateMap_btn.Click += new System.EventHandler(this.UpdateMap_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 506);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunListView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersaveObjec_lv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bot_olv)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.item_olv)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveGun_btn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox value_tbx;
        private System.Windows.Forms.Button InitGun_btn;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox log_rtb;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button1;
        private BrightIdeasSoftware.FastObjectListView gunListView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button fillGun_btn;
        private System.Windows.Forms.ComboBox nameGun_cbx;
        private System.Windows.Forms.Button removegun_btn;
        private System.Windows.Forms.Button addgun_btn;
        private System.Windows.Forms.TextBox gunPathData_tbx;
        private BrightIdeasSoftware.FastObjectListView playersaveObjec_lv;
        private System.Windows.Forms.TextBox setting_tbx;
        private System.Windows.Forms.TextBox player_tbx;
        private System.Windows.Forms.Button SavePlayer_btn;
        private System.Windows.Forms.Button LoadPlaye_btn;
        private System.Windows.Forms.TextBox playerdatafile_tbx;
        private System.Windows.Forms.Button SaveMap_btn;
        private System.Windows.Forms.Button LoadMap_btn;
        private System.Windows.Forms.TextBox mapid_tbx;
        private System.Windows.Forms.TextBox mapFolder_tbx;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private BrightIdeasSoftware.FastObjectListView bot_olv;
        private BrightIdeasSoftware.FastObjectListView item_olv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button fillbotColumn_btn;
        private System.Windows.Forms.ComboBox botColumn_cbx;
        private System.Windows.Forms.Button EditCommand_btn;
        private System.Windows.Forms.Button EditSkin_btn;
        private System.Windows.Forms.TextBox filBotValue_tbx;
        private System.Windows.Forms.Panel botskin_pnl;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button RemoveItem_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox itemmap_cbx;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox maptype_tbx;
        private System.Windows.Forms.TextBox mapname_tbx;
        private System.Windows.Forms.TextBox mapSound_tbx;
        private System.Windows.Forms.TextBox weapon_tbx;
        private System.Windows.Forms.TextBox playery_tbx;
        private System.Windows.Forms.TextBox playerx_tbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox secondwpd_tbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox playerdata_tbx;
        private System.Windows.Forms.Button UpdateMap_btn;
    }
}

