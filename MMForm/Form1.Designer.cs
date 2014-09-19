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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.log_rtb = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunListView)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(816, 302);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gunListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gun";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(517, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 267);
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
            this.panel1.Size = new System.Drawing.Size(282, 132);
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
            this.gunListView.Location = new System.Drawing.Point(3, 0);
            this.gunListView.Name = "gunListView";
            this.gunListView.ShowGroups = false;
            this.gunListView.Size = new System.Drawing.Size(508, 272);
            this.gunListView.TabIndex = 3;
            this.gunListView.UseCompatibleStateImageBehavior = false;
            this.gunListView.View = System.Windows.Forms.View.Details;
            this.gunListView.VirtualMode = true;
            this.gunListView.SelectedIndexChanged += new System.EventHandler(this.gunListView_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bullet";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(808, 276);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Map";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl2.Location = new System.Drawing.Point(0, 300);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(816, 154);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.log_rtb);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(808, 128);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // log_rtb
            // 
            this.log_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log_rtb.Location = new System.Drawing.Point(3, 3);
            this.log_rtb.Name = "log_rtb";
            this.log_rtb.Size = new System.Drawing.Size(802, 122);
            this.log_rtb.TabIndex = 0;
            this.log_rtb.Text = "";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(808, 128);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 454);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunListView)).EndInit();
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
    }
}

