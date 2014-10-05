namespace MMForm
{
    partial class FormEditCommand
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
            this.command_cbx = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.error_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.typecommand_tbx = new System.Windows.Forms.TextBox();
            this.id_tbx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.command_olv = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.allCommand_tbx = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.command_olv)).BeginInit();
            this.SuspendLayout();
            // 
            // command_cbx
            // 
            this.command_cbx.FormattingEnabled = true;
            this.command_cbx.Location = new System.Drawing.Point(6, 19);
            this.command_cbx.Name = "command_cbx";
            this.command_cbx.Size = new System.Drawing.Size(121, 21);
            this.command_cbx.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.command_cbx);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 411);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.error_lbl);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.update_btn);
            this.groupBox3.Controls.Add(this.typecommand_tbx);
            this.groupBox3.Controls.Add(this.id_tbx);
            this.groupBox3.Location = new System.Drawing.Point(6, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 135);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.ForeColor = System.Drawing.Color.Crimson;
            this.error_lbl.Location = new System.Drawing.Point(6, 90);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(35, 13);
            this.error_lbl.TabIndex = 6;
            this.error_lbl.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(126, 106);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 3;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // typecommand_tbx
            // 
            this.typecommand_tbx.Location = new System.Drawing.Point(101, 57);
            this.typecommand_tbx.Name = "typecommand_tbx";
            this.typecommand_tbx.Size = new System.Drawing.Size(100, 20);
            this.typecommand_tbx.TabIndex = 5;
            // 
            // id_tbx
            // 
            this.id_tbx.Location = new System.Drawing.Point(101, 19);
            this.id_tbx.Name = "id_tbx";
            this.id_tbx.Size = new System.Drawing.Size(100, 20);
            this.id_tbx.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 184);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // command_olv
            // 
            this.command_olv.AllColumns.Add(this.olvColumn1);
            this.command_olv.AllColumns.Add(this.olvColumn2);
            this.command_olv.AllColumns.Add(this.olvColumn3);
            this.command_olv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.command_olv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3});
            this.command_olv.FullRowSelect = true;
            this.command_olv.GridLines = true;
            this.command_olv.Location = new System.Drawing.Point(263, 77);
            this.command_olv.Name = "command_olv";
            this.command_olv.ShowGroups = false;
            this.command_olv.Size = new System.Drawing.Size(563, 334);
            this.command_olv.TabIndex = 3;
            this.command_olv.UseCompatibleStateImageBehavior = false;
            this.command_olv.View = System.Windows.Forms.View.Details;
            this.command_olv.VirtualMode = true;
            this.command_olv.SelectedIndexChanged += new System.EventHandler(this.command_olv_SelectedIndexChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Id";
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.Text = "Id";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Type";
            this.olvColumn2.CellPadding = null;
            this.olvColumn2.Text = "Type";
            this.olvColumn2.Width = 123;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Data";
            this.olvColumn3.CellPadding = null;
            this.olvColumn3.Text = "Data";
            this.olvColumn3.Width = 97;
            // 
            // allCommand_tbx
            // 
            this.allCommand_tbx.Location = new System.Drawing.Point(263, 33);
            this.allCommand_tbx.Name = "allCommand_tbx";
            this.allCommand_tbx.Size = new System.Drawing.Size(314, 20);
            this.allCommand_tbx.TabIndex = 4;
            // 
            // save_btn
            // 
            this.save_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save_btn.Location = new System.Drawing.Point(614, 30);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // FormEditCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 407);
            this.Controls.Add(this.allCommand_tbx);
            this.Controls.Add(this.command_olv);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEditCommand";
            this.Text = "FormEditCommand";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.command_olv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox command_cbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private BrightIdeasSoftware.FastObjectListView command_olv;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox typecommand_tbx;
        private System.Windows.Forms.TextBox id_tbx;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label error_lbl;
        private System.Windows.Forms.TextBox allCommand_tbx;
        private System.Windows.Forms.Button save_btn;
    }
}