namespace WindowsFormsApp2
{
    partial class RFID
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
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.libInfo = new System.Windows.Forms.ListBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lbFirmVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerGen2Identify = new System.Windows.Forms.Timer(this.components);
            this.lbUniqueTags = new System.Windows.Forms.Label();
            this.UniqueTags = new System.Windows.Forms.Label();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.timerReconnect = new System.Windows.Forms.Timer(this.components);
            this.timerRate = new System.Windows.Forms.Timer(this.components);
            this.lbTotalReads = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPeakRate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTestDuration = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbReadTimes = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbAverageRate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.livGen2Identify = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 58);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(56, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(54, 32);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 20);
            this.tbPort.TabIndex = 1;
            this.tbPort.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(54, 6);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 20);
            this.tbIP.TabIndex = 3;
            this.tbIP.Text = "172.16.101.200";
            // 
            // libInfo
            // 
            this.libInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libInfo.FormattingEnabled = true;
            this.libInfo.ItemHeight = 12;
            this.libInfo.Location = new System.Drawing.Point(12, 104);
            this.libInfo.Name = "libInfo";
            this.libInfo.Size = new System.Drawing.Size(142, 364);
            this.libInfo.TabIndex = 5;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(84, 58);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(70, 23);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lbFirmVersion
            // 
            this.lbFirmVersion.AutoSize = true;
            this.lbFirmVersion.Location = new System.Drawing.Point(81, 84);
            this.lbFirmVersion.Name = "lbFirmVersion";
            this.lbFirmVersion.Size = new System.Drawing.Size(0, 13);
            this.lbFirmVersion.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "FirmVersion";
            // 
            // timerGen2Identify
            // 
            this.timerGen2Identify.Interval = 10;
            this.timerGen2Identify.Tick += new System.EventHandler(this.timerInventory_Tick);
            // 
            // lbUniqueTags
            // 
            this.lbUniqueTags.AutoSize = true;
            this.lbUniqueTags.Location = new System.Drawing.Point(253, 416);
            this.lbUniqueTags.Name = "lbUniqueTags";
            this.lbUniqueTags.Size = new System.Drawing.Size(13, 13);
            this.lbUniqueTags.TabIndex = 17;
            this.lbUniqueTags.Text = "0";
            // 
            // UniqueTags
            // 
            this.UniqueTags.AutoSize = true;
            this.UniqueTags.Location = new System.Drawing.Point(173, 416);
            this.UniqueTags.Name = "UniqueTags";
            this.UniqueTags.Size = new System.Drawing.Size(65, 13);
            this.UniqueTags.TabIndex = 16;
            this.UniqueTags.Text = "UniqueTags";
            // 
            // btnIdentify
            // 
            this.btnIdentify.Location = new System.Drawing.Point(176, 3);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(75, 23);
            this.btnIdentify.TabIndex = 22;
            this.btnIdentify.Text = "Identify";
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // timerReconnect
            // 
            this.timerReconnect.Interval = 3000;
            this.timerReconnect.Tick += new System.EventHandler(this.timerReconnect_Tick);
            // 
            // timerRate
            // 
            this.timerRate.Interval = 1000;
            this.timerRate.Tick += new System.EventHandler(this.timerRate_Tick);
            // 
            // lbTotalReads
            // 
            this.lbTotalReads.AutoSize = true;
            this.lbTotalReads.Location = new System.Drawing.Point(416, 416);
            this.lbTotalReads.Name = "lbTotalReads";
            this.lbTotalReads.Size = new System.Drawing.Size(13, 13);
            this.lbTotalReads.TabIndex = 25;
            this.lbTotalReads.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "TotalReads";
            // 
            // lbPeakRate
            // 
            this.lbPeakRate.AutoSize = true;
            this.lbPeakRate.Location = new System.Drawing.Point(565, 416);
            this.lbPeakRate.Name = "lbPeakRate";
            this.lbPeakRate.Size = new System.Drawing.Size(13, 13);
            this.lbPeakRate.TabIndex = 27;
            this.lbPeakRate.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "PeakRate";
            // 
            // lbTestDuration
            // 
            this.lbTestDuration.AutoSize = true;
            this.lbTestDuration.Location = new System.Drawing.Point(253, 455);
            this.lbTestDuration.Name = "lbTestDuration";
            this.lbTestDuration.Size = new System.Drawing.Size(13, 13);
            this.lbTestDuration.TabIndex = 29;
            this.lbTestDuration.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "TestDuration";
            // 
            // lbReadTimes
            // 
            this.lbReadTimes.AutoSize = true;
            this.lbReadTimes.Location = new System.Drawing.Point(416, 455);
            this.lbReadTimes.Name = "lbReadTimes";
            this.lbReadTimes.Size = new System.Drawing.Size(13, 13);
            this.lbReadTimes.TabIndex = 31;
            this.lbReadTimes.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "ReadTimes";
            // 
            // lbAverageRate
            // 
            this.lbAverageRate.AutoSize = true;
            this.lbAverageRate.Location = new System.Drawing.Point(565, 455);
            this.lbAverageRate.Name = "lbAverageRate";
            this.lbAverageRate.Size = new System.Drawing.Size(13, 13);
            this.lbAverageRate.TabIndex = 33;
            this.lbAverageRate.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(485, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "AverageRate";
            // 
            // livGen2Identify
            // 
            this.livGen2Identify.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.livGen2Identify.HideSelection = false;
            this.livGen2Identify.Location = new System.Drawing.Point(176, 35);
            this.livGen2Identify.Name = "livGen2Identify";
            this.livGen2Identify.Size = new System.Drawing.Size(612, 365);
            this.livGen2Identify.TabIndex = 34;
            this.livGen2Identify.UseCompatibleStateImageBehavior = false;
            this.livGen2Identify.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NO.";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "AnteNo.";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "EPC";
            this.columnHeader3.Width = 398;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Times";
            // 
            // RFID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.livGen2Identify);
            this.Controls.Add(this.lbAverageRate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbReadTimes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTestDuration);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbPeakRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTotalReads);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIdentify);
            this.Controls.Add(this.lbUniqueTags);
            this.Controls.Add(this.UniqueTags);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbFirmVersion);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.libInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.btnConnect);
            this.Name = "RFID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.ListBox libInfo;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lbFirmVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerGen2Identify;
        private System.Windows.Forms.Label lbUniqueTags;
        private System.Windows.Forms.Label UniqueTags;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Timer timerReconnect;
        private System.Windows.Forms.Timer timerRate;
        private System.Windows.Forms.Label lbTotalReads;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPeakRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTestDuration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbReadTimes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbAverageRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView livGen2Identify;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        //private System.Windows.Forms.Timer timerRate;
    }
}

