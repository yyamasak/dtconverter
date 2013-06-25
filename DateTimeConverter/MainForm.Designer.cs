namespace DateTimeConverter
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtpInput1 = new System.Windows.Forms.DateTimePicker();
            this.tbxOutput1 = new System.Windows.Forms.TextBox();
            this.btnConv1 = new System.Windows.Forms.Button();
            this.btnConv2 = new System.Windows.Forms.Button();
            this.btnJustTime = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnNow = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.tbxInput2 = new System.Windows.Forms.MaskedTextBox();
            this.tbxInput3 = new System.Windows.Forms.MaskedTextBox();
            this.btnConv3 = new System.Windows.Forms.Button();
            this.cbxFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCulture = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxInput4 = new System.Windows.Forms.MaskedTextBox();
            this.btnConv4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.linkVersion = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxInput5 = new System.Windows.Forms.TextBox();
            this.btnConv5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpInput1
            // 
            this.dtpInput1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpInput1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpInput1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInput1.Location = new System.Drawing.Point(64, 38);
            this.dtpInput1.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtpInput1.Name = "dtpInput1";
            this.dtpInput1.Size = new System.Drawing.Size(178, 23);
            this.dtpInput1.TabIndex = 0;
            // 
            // tbxOutput1
            // 
            this.tbxOutput1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxOutput1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOutput1.Location = new System.Drawing.Point(4, 339);
            this.tbxOutput1.Multiline = true;
            this.tbxOutput1.Name = "tbxOutput1";
            this.tbxOutput1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOutput1.Size = new System.Drawing.Size(335, 80);
            this.tbxOutput1.TabIndex = 1;
            this.tbxOutput1.Text = "Readable  : 2011-06-22 22:31:28\r\nC# Ticks  : 634443786880000000\r\nNTP Time  : 3517" +
    "738288\r\nUNIX Epoch: 1308749488\r\nExcel     : 40716.9385185185\r\n";
            this.toolTip1.SetToolTip(this.tbxOutput1, "Scroll up to see the history.");
            // 
            // btnConv1
            // 
            this.btnConv1.Location = new System.Drawing.Point(273, 35);
            this.btnConv1.Name = "btnConv1";
            this.btnConv1.Size = new System.Drawing.Size(61, 33);
            this.btnConv1.TabIndex = 2;
            this.btnConv1.Text = "Convert";
            this.btnConv1.UseVisualStyleBackColor = true;
            this.btnConv1.Click += new System.EventHandler(this.btnConv1_Click);
            // 
            // btnConv2
            // 
            this.btnConv2.Location = new System.Drawing.Point(274, 73);
            this.btnConv2.Name = "btnConv2";
            this.btnConv2.Size = new System.Drawing.Size(61, 33);
            this.btnConv2.TabIndex = 4;
            this.btnConv2.Text = "Convert";
            this.btnConv2.UseVisualStyleBackColor = true;
            this.btnConv2.Click += new System.EventHandler(this.btnConv2_Click);
            // 
            // btnJustTime
            // 
            this.btnJustTime.BackColor = System.Drawing.Color.SkyBlue;
            this.btnJustTime.Location = new System.Drawing.Point(248, 41);
            this.btnJustTime.Name = "btnJustTime";
            this.btnJustTime.Size = new System.Drawing.Size(18, 18);
            this.btnJustTime.TabIndex = 5;
            this.btnJustTime.Text = "0";
            this.toolTip1.SetToolTip(this.btnJustTime, "Set time to 00:00:00.");
            this.btnJustTime.UseVisualStyleBackColor = false;
            this.btnJustTime.Click += new System.EventHandler(this.btnJustTime_Click);
            // 
            // btnNow
            // 
            this.btnNow.AutoSize = true;
            this.btnNow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNow.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNow.Location = new System.Drawing.Point(9, 12);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(35, 21);
            this.btnNow.TabIndex = 18;
            this.btnNow.Text = "Now";
            this.toolTip1.SetToolTip(this.btnNow, "Set current time.");
            this.btnNow.UseVisualStyleBackColor = true;
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.AutoSize = true;
            this.btnCopy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopy.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCopy.Location = new System.Drawing.Point(52, 312);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(38, 21);
            this.btnCopy.TabIndex = 19;
            this.btnCopy.Text = "Copy";
            this.toolTip1.SetToolTip(this.btnCopy, "Copy output to clipboard.");
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.AutoSize = true;
            this.Clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Clear.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Clear.Location = new System.Drawing.Point(299, 312);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(39, 21);
            this.Clear.TabIndex = 20;
            this.Clear.Text = "Clear";
            this.toolTip1.SetToolTip(this.Clear, "Clear output");
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // tbxInput2
            // 
            this.tbxInput2.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbxInput2.Location = new System.Drawing.Point(64, 80);
            this.tbxInput2.Mask = "999999999999999999";
            this.tbxInput2.Name = "tbxInput2";
            this.tbxInput2.Size = new System.Drawing.Size(193, 23);
            this.tbxInput2.TabIndex = 6;
            // 
            // tbxInput3
            // 
            this.tbxInput3.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbxInput3.Location = new System.Drawing.Point(64, 118);
            this.tbxInput3.Mask = "9999999999";
            this.tbxInput3.Name = "tbxInput3";
            this.tbxInput3.Size = new System.Drawing.Size(193, 23);
            this.tbxInput3.TabIndex = 9;
            // 
            // btnConv3
            // 
            this.btnConv3.Location = new System.Drawing.Point(274, 111);
            this.btnConv3.Name = "btnConv3";
            this.btnConv3.Size = new System.Drawing.Size(61, 33);
            this.btnConv3.TabIndex = 8;
            this.btnConv3.Text = "Convert";
            this.btnConv3.UseVisualStyleBackColor = true;
            this.btnConv3.Click += new System.EventHandler(this.btnConv3_Click);
            // 
            // cbxFormat
            // 
            this.cbxFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFormat.FormattingEnabled = true;
            this.cbxFormat.Location = new System.Drawing.Point(64, 252);
            this.cbxFormat.Name = "cbxFormat";
            this.cbxFormat.Size = new System.Drawing.Size(265, 20);
            this.cbxFormat.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Format";
            // 
            // cbxCulture
            // 
            this.cbxCulture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCulture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCulture.FormattingEnabled = true;
            this.cbxCulture.Location = new System.Drawing.Point(64, 278);
            this.cbxCulture.Name = "cbxCulture";
            this.cbxCulture.Size = new System.Drawing.Size(265, 20);
            this.cbxCulture.TabIndex = 10;
            this.cbxCulture.SelectedIndexChanged += new System.EventHandler(this.cbxCulture_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Culture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Readable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "C# Ticks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "NTP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "UNIX";
            // 
            // tbxInput4
            // 
            this.tbxInput4.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbxInput4.Location = new System.Drawing.Point(64, 156);
            this.tbxInput4.Mask = "9999999999";
            this.tbxInput4.Name = "tbxInput4";
            this.tbxInput4.Size = new System.Drawing.Size(193, 23);
            this.tbxInput4.TabIndex = 15;
            // 
            // btnConv4
            // 
            this.btnConv4.Location = new System.Drawing.Point(274, 149);
            this.btnConv4.Name = "btnConv4";
            this.btnConv4.Size = new System.Drawing.Size(61, 33);
            this.btnConv4.TabIndex = 14;
            this.btnConv4.Text = "Convert";
            this.btnConv4.UseVisualStyleBackColor = true;
            this.btnConv4.Click += new System.EventHandler(this.btnConv4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "Output";
            // 
            // linkVersion
            // 
            this.linkVersion.AutoSize = true;
            this.linkVersion.Location = new System.Drawing.Point(253, 9);
            this.linkVersion.Name = "linkVersion";
            this.linkVersion.Size = new System.Drawing.Size(78, 12);
            this.linkVersion.TabIndex = 21;
            this.linkVersion.TabStop = true;
            this.linkVersion.Text = "Version 1.0.0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "Excel";
            // 
            // tbxInput5
            // 
            this.tbxInput5.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbxInput5.Location = new System.Drawing.Point(64, 194);
            this.tbxInput5.Name = "tbxInput5";
            this.tbxInput5.Size = new System.Drawing.Size(193, 23);
            this.tbxInput5.TabIndex = 23;
            // 
            // btnConv5
            // 
            this.btnConv5.Location = new System.Drawing.Point(274, 187);
            this.btnConv5.Name = "btnConv5";
            this.btnConv5.Size = new System.Drawing.Size(61, 33);
            this.btnConv5.TabIndex = 22;
            this.btnConv5.Text = "Convert";
            this.btnConv5.UseVisualStyleBackColor = true;
            this.btnConv5.Click += new System.EventHandler(this.btnConv5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 425);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxInput5);
            this.Controls.Add(this.btnConv5);
            this.Controls.Add(this.linkVersion);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxInput4);
            this.Controls.Add(this.btnConv4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCulture);
            this.Controls.Add(this.cbxFormat);
            this.Controls.Add(this.tbxInput3);
            this.Controls.Add(this.btnConv3);
            this.Controls.Add(this.tbxInput2);
            this.Controls.Add(this.btnJustTime);
            this.Controls.Add(this.btnConv2);
            this.Controls.Add(this.btnConv1);
            this.Controls.Add(this.tbxOutput1);
            this.Controls.Add(this.dtpInput1);
            this.Name = "MainForm";
            this.Text = "DateTimeConverter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpInput1;
        private System.Windows.Forms.TextBox tbxOutput1;
        private System.Windows.Forms.Button btnConv1;
        private System.Windows.Forms.Button btnConv2;
        private System.Windows.Forms.Button btnJustTime;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox tbxInput2;
        private System.Windows.Forms.MaskedTextBox tbxInput3;
        private System.Windows.Forms.Button btnConv3;
        private System.Windows.Forms.ComboBox cbxFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCulture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tbxInput4;
        private System.Windows.Forms.Button btnConv4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.LinkLabel linkVersion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxInput5;
        private System.Windows.Forms.Button btnConv5;
    }
}

