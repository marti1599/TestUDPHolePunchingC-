
namespace TestUDPHolePunching
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnStart1 = new System.Windows.Forms.Button();
            this.LblNetType1 = new System.Windows.Forms.Label();
            this.LblNetType1Value = new System.Windows.Forms.Label();
            this.LblLocalEndPoint1 = new System.Windows.Forms.Label();
            this.LblPublicEndPoint1 = new System.Windows.Forms.Label();
            this.LblLocalEndPoint1Value = new System.Windows.Forms.Label();
            this.LblPublicEndPoint1Value = new System.Windows.Forms.Label();
            this.BtnStart2 = new System.Windows.Forms.Button();
            this.LblRemotePublicEndPoint2 = new System.Windows.Forms.Label();
            this.LblRemoteLocalEndPoint2 = new System.Windows.Forms.Label();
            this.TxtbxRemoteLocalIP2Value = new System.Windows.Forms.TextBox();
            this.TxtbxRemotePublicIP2Value = new System.Windows.Forms.TextBox();
            this.NudRemoteLocalPort2Value = new System.Windows.Forms.NumericUpDown();
            this.NudRemotePublicPort2Value = new System.Windows.Forms.NumericUpDown();
            this.LblPublicEndPoint2Value = new System.Windows.Forms.Label();
            this.LblLocalEndPoint2Value = new System.Windows.Forms.Label();
            this.LblPublicEndPoint2 = new System.Windows.Forms.Label();
            this.LblLocalEndPoint2 = new System.Windows.Forms.Label();
            this.LblNetType2Value = new System.Windows.Forms.Label();
            this.LblNetType2 = new System.Windows.Forms.Label();
            this.BtnStartSendMessages1 = new System.Windows.Forms.Button();
            this.BtnStartSendMessages2 = new System.Windows.Forms.Button();
            this.NudPortDestination1 = new System.Windows.Forms.NumericUpDown();
            this.TxtbxIPDestination1 = new System.Windows.Forms.TextBox();
            this.LblDestination1 = new System.Windows.Forms.Label();
            this.NudPortDestination2 = new System.Windows.Forms.NumericUpDown();
            this.TxtbxIPDestination2 = new System.Windows.Forms.TextBox();
            this.LblDestination2 = new System.Windows.Forms.Label();
            this.TxtbxLog1 = new System.Windows.Forms.TextBox();
            this.TxtbxLog2 = new System.Windows.Forms.TextBox();
            this.BtnStopReceiveMessages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudRemoteLocalPort2Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRemotePublicPort2Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPortDestination1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPortDestination2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStart1
            // 
            this.BtnStart1.Location = new System.Drawing.Point(13, 13);
            this.BtnStart1.Name = "BtnStart1";
            this.BtnStart1.Size = new System.Drawing.Size(277, 54);
            this.BtnStart1.TabIndex = 0;
            this.BtnStart1.Text = "Start";
            this.BtnStart1.UseVisualStyleBackColor = true;
            this.BtnStart1.Click += new System.EventHandler(this.BtnStart1_Click);
            // 
            // LblNetType1
            // 
            this.LblNetType1.AutoSize = true;
            this.LblNetType1.Location = new System.Drawing.Point(10, 74);
            this.LblNetType1.Name = "LblNetType1";
            this.LblNetType1.Size = new System.Drawing.Size(54, 13);
            this.LblNetType1.TabIndex = 1;
            this.LblNetType1.Text = "Net Type:";
            // 
            // LblNetType1Value
            // 
            this.LblNetType1Value.AutoSize = true;
            this.LblNetType1Value.Location = new System.Drawing.Point(70, 74);
            this.LblNetType1Value.Name = "LblNetType1Value";
            this.LblNetType1Value.Size = new System.Drawing.Size(42, 13);
            this.LblNetType1Value.TabIndex = 2;
            this.LblNetType1Value.Text = "VALUE";
            // 
            // LblLocalEndPoint1
            // 
            this.LblLocalEndPoint1.AutoSize = true;
            this.LblLocalEndPoint1.Location = new System.Drawing.Point(10, 96);
            this.LblLocalEndPoint1.Name = "LblLocalEndPoint1";
            this.LblLocalEndPoint1.Size = new System.Drawing.Size(82, 13);
            this.LblLocalEndPoint1.TabIndex = 3;
            this.LblLocalEndPoint1.Text = "Local EndPoint:";
            // 
            // LblPublicEndPoint1
            // 
            this.LblPublicEndPoint1.AutoSize = true;
            this.LblPublicEndPoint1.Location = new System.Drawing.Point(10, 118);
            this.LblPublicEndPoint1.Name = "LblPublicEndPoint1";
            this.LblPublicEndPoint1.Size = new System.Drawing.Size(85, 13);
            this.LblPublicEndPoint1.TabIndex = 4;
            this.LblPublicEndPoint1.Text = "Public EndPoint:";
            // 
            // LblLocalEndPoint1Value
            // 
            this.LblLocalEndPoint1Value.AutoSize = true;
            this.LblLocalEndPoint1Value.Location = new System.Drawing.Point(98, 96);
            this.LblLocalEndPoint1Value.Name = "LblLocalEndPoint1Value";
            this.LblLocalEndPoint1Value.Size = new System.Drawing.Size(42, 13);
            this.LblLocalEndPoint1Value.TabIndex = 5;
            this.LblLocalEndPoint1Value.Text = "VALUE";
            // 
            // LblPublicEndPoint1Value
            // 
            this.LblPublicEndPoint1Value.AutoSize = true;
            this.LblPublicEndPoint1Value.Location = new System.Drawing.Point(98, 118);
            this.LblPublicEndPoint1Value.Name = "LblPublicEndPoint1Value";
            this.LblPublicEndPoint1Value.Size = new System.Drawing.Size(42, 13);
            this.LblPublicEndPoint1Value.TabIndex = 6;
            this.LblPublicEndPoint1Value.Text = "VALUE";
            // 
            // BtnStart2
            // 
            this.BtnStart2.Location = new System.Drawing.Point(296, 13);
            this.BtnStart2.Name = "BtnStart2";
            this.BtnStart2.Size = new System.Drawing.Size(284, 54);
            this.BtnStart2.TabIndex = 7;
            this.BtnStart2.Text = "Start";
            this.BtnStart2.UseVisualStyleBackColor = true;
            this.BtnStart2.Click += new System.EventHandler(this.BtnStart2_Click);
            // 
            // LblRemotePublicEndPoint2
            // 
            this.LblRemotePublicEndPoint2.AutoSize = true;
            this.LblRemotePublicEndPoint2.Location = new System.Drawing.Point(293, 103);
            this.LblRemotePublicEndPoint2.Name = "LblRemotePublicEndPoint2";
            this.LblRemotePublicEndPoint2.Size = new System.Drawing.Size(85, 13);
            this.LblRemotePublicEndPoint2.TabIndex = 9;
            this.LblRemotePublicEndPoint2.Text = "Public EndPoint:";
            // 
            // LblRemoteLocalEndPoint2
            // 
            this.LblRemoteLocalEndPoint2.AutoSize = true;
            this.LblRemoteLocalEndPoint2.Location = new System.Drawing.Point(293, 77);
            this.LblRemoteLocalEndPoint2.Name = "LblRemoteLocalEndPoint2";
            this.LblRemoteLocalEndPoint2.Size = new System.Drawing.Size(82, 13);
            this.LblRemoteLocalEndPoint2.TabIndex = 8;
            this.LblRemoteLocalEndPoint2.Text = "Local EndPoint:";
            // 
            // TxtbxRemoteLocalIP2Value
            // 
            this.TxtbxRemoteLocalIP2Value.Location = new System.Drawing.Point(381, 74);
            this.TxtbxRemoteLocalIP2Value.Name = "TxtbxRemoteLocalIP2Value";
            this.TxtbxRemoteLocalIP2Value.Size = new System.Drawing.Size(127, 20);
            this.TxtbxRemoteLocalIP2Value.TabIndex = 10;
            // 
            // TxtbxRemotePublicIP2Value
            // 
            this.TxtbxRemotePublicIP2Value.Location = new System.Drawing.Point(381, 100);
            this.TxtbxRemotePublicIP2Value.Name = "TxtbxRemotePublicIP2Value";
            this.TxtbxRemotePublicIP2Value.Size = new System.Drawing.Size(127, 20);
            this.TxtbxRemotePublicIP2Value.TabIndex = 11;
            // 
            // NudRemoteLocalPort2Value
            // 
            this.NudRemoteLocalPort2Value.Location = new System.Drawing.Point(514, 75);
            this.NudRemoteLocalPort2Value.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NudRemoteLocalPort2Value.Name = "NudRemoteLocalPort2Value";
            this.NudRemoteLocalPort2Value.Size = new System.Drawing.Size(66, 20);
            this.NudRemoteLocalPort2Value.TabIndex = 12;
            // 
            // NudRemotePublicPort2Value
            // 
            this.NudRemotePublicPort2Value.Location = new System.Drawing.Point(514, 100);
            this.NudRemotePublicPort2Value.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NudRemotePublicPort2Value.Name = "NudRemotePublicPort2Value";
            this.NudRemotePublicPort2Value.Size = new System.Drawing.Size(66, 20);
            this.NudRemotePublicPort2Value.TabIndex = 13;
            // 
            // LblPublicEndPoint2Value
            // 
            this.LblPublicEndPoint2Value.AutoSize = true;
            this.LblPublicEndPoint2Value.Location = new System.Drawing.Point(381, 190);
            this.LblPublicEndPoint2Value.Name = "LblPublicEndPoint2Value";
            this.LblPublicEndPoint2Value.Size = new System.Drawing.Size(42, 13);
            this.LblPublicEndPoint2Value.TabIndex = 19;
            this.LblPublicEndPoint2Value.Text = "VALUE";
            // 
            // LblLocalEndPoint2Value
            // 
            this.LblLocalEndPoint2Value.AutoSize = true;
            this.LblLocalEndPoint2Value.Location = new System.Drawing.Point(381, 168);
            this.LblLocalEndPoint2Value.Name = "LblLocalEndPoint2Value";
            this.LblLocalEndPoint2Value.Size = new System.Drawing.Size(42, 13);
            this.LblLocalEndPoint2Value.TabIndex = 18;
            this.LblLocalEndPoint2Value.Text = "VALUE";
            // 
            // LblPublicEndPoint2
            // 
            this.LblPublicEndPoint2.AutoSize = true;
            this.LblPublicEndPoint2.Location = new System.Drawing.Point(293, 190);
            this.LblPublicEndPoint2.Name = "LblPublicEndPoint2";
            this.LblPublicEndPoint2.Size = new System.Drawing.Size(85, 13);
            this.LblPublicEndPoint2.TabIndex = 17;
            this.LblPublicEndPoint2.Text = "Public EndPoint:";
            // 
            // LblLocalEndPoint2
            // 
            this.LblLocalEndPoint2.AutoSize = true;
            this.LblLocalEndPoint2.Location = new System.Drawing.Point(293, 168);
            this.LblLocalEndPoint2.Name = "LblLocalEndPoint2";
            this.LblLocalEndPoint2.Size = new System.Drawing.Size(82, 13);
            this.LblLocalEndPoint2.TabIndex = 16;
            this.LblLocalEndPoint2.Text = "Local EndPoint:";
            // 
            // LblNetType2Value
            // 
            this.LblNetType2Value.AutoSize = true;
            this.LblNetType2Value.Location = new System.Drawing.Point(353, 146);
            this.LblNetType2Value.Name = "LblNetType2Value";
            this.LblNetType2Value.Size = new System.Drawing.Size(42, 13);
            this.LblNetType2Value.TabIndex = 15;
            this.LblNetType2Value.Text = "VALUE";
            // 
            // LblNetType2
            // 
            this.LblNetType2.AutoSize = true;
            this.LblNetType2.Location = new System.Drawing.Point(293, 146);
            this.LblNetType2.Name = "LblNetType2";
            this.LblNetType2.Size = new System.Drawing.Size(54, 13);
            this.LblNetType2.TabIndex = 14;
            this.LblNetType2.Text = "Net Type:";
            // 
            // BtnStartSendMessages1
            // 
            this.BtnStartSendMessages1.Location = new System.Drawing.Point(12, 237);
            this.BtnStartSendMessages1.Name = "BtnStartSendMessages1";
            this.BtnStartSendMessages1.Size = new System.Drawing.Size(278, 49);
            this.BtnStartSendMessages1.TabIndex = 20;
            this.BtnStartSendMessages1.Text = "Send";
            this.BtnStartSendMessages1.UseVisualStyleBackColor = true;
            this.BtnStartSendMessages1.Click += new System.EventHandler(this.BtnStartSendMessages1_Click);
            // 
            // BtnStartSendMessages2
            // 
            this.BtnStartSendMessages2.Location = new System.Drawing.Point(296, 237);
            this.BtnStartSendMessages2.Name = "BtnStartSendMessages2";
            this.BtnStartSendMessages2.Size = new System.Drawing.Size(212, 49);
            this.BtnStartSendMessages2.TabIndex = 21;
            this.BtnStartSendMessages2.Text = "Send";
            this.BtnStartSendMessages2.UseVisualStyleBackColor = true;
            this.BtnStartSendMessages2.Click += new System.EventHandler(this.BtnStartSendMessages2_Click);
            // 
            // NudPortDestination1
            // 
            this.NudPortDestination1.Location = new System.Drawing.Point(215, 292);
            this.NudPortDestination1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NudPortDestination1.Name = "NudPortDestination1";
            this.NudPortDestination1.Size = new System.Drawing.Size(75, 20);
            this.NudPortDestination1.TabIndex = 24;
            this.NudPortDestination1.Value = new decimal(new int[] {
            11000,
            0,
            0,
            0});
            // 
            // TxtbxIPDestination1
            // 
            this.TxtbxIPDestination1.Location = new System.Drawing.Point(82, 291);
            this.TxtbxIPDestination1.Name = "TxtbxIPDestination1";
            this.TxtbxIPDestination1.Size = new System.Drawing.Size(127, 20);
            this.TxtbxIPDestination1.TabIndex = 23;
            this.TxtbxIPDestination1.Text = "195.223.73.74";
            // 
            // LblDestination1
            // 
            this.LblDestination1.AutoSize = true;
            this.LblDestination1.Location = new System.Drawing.Point(13, 295);
            this.LblDestination1.Name = "LblDestination1";
            this.LblDestination1.Size = new System.Drawing.Size(63, 13);
            this.LblDestination1.TabIndex = 22;
            this.LblDestination1.Text = "Destination:";
            // 
            // NudPortDestination2
            // 
            this.NudPortDestination2.Location = new System.Drawing.Point(514, 292);
            this.NudPortDestination2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NudPortDestination2.Name = "NudPortDestination2";
            this.NudPortDestination2.Size = new System.Drawing.Size(66, 20);
            this.NudPortDestination2.TabIndex = 27;
            // 
            // TxtbxIPDestination2
            // 
            this.TxtbxIPDestination2.Location = new System.Drawing.Point(365, 292);
            this.TxtbxIPDestination2.Name = "TxtbxIPDestination2";
            this.TxtbxIPDestination2.Size = new System.Drawing.Size(143, 20);
            this.TxtbxIPDestination2.TabIndex = 26;
            this.TxtbxIPDestination2.Text = "192.168.43.185";
            // 
            // LblDestination2
            // 
            this.LblDestination2.AutoSize = true;
            this.LblDestination2.Location = new System.Drawing.Point(296, 295);
            this.LblDestination2.Name = "LblDestination2";
            this.LblDestination2.Size = new System.Drawing.Size(63, 13);
            this.LblDestination2.TabIndex = 25;
            this.LblDestination2.Text = "Destination:";
            // 
            // TxtbxLog1
            // 
            this.TxtbxLog1.Location = new System.Drawing.Point(12, 324);
            this.TxtbxLog1.Multiline = true;
            this.TxtbxLog1.Name = "TxtbxLog1";
            this.TxtbxLog1.Size = new System.Drawing.Size(278, 271);
            this.TxtbxLog1.TabIndex = 28;
            // 
            // TxtbxLog2
            // 
            this.TxtbxLog2.Location = new System.Drawing.Point(302, 324);
            this.TxtbxLog2.Multiline = true;
            this.TxtbxLog2.Name = "TxtbxLog2";
            this.TxtbxLog2.Size = new System.Drawing.Size(278, 271);
            this.TxtbxLog2.TabIndex = 29;
            // 
            // BtnStopReceiveMessages
            // 
            this.BtnStopReceiveMessages.Location = new System.Drawing.Point(515, 237);
            this.BtnStopReceiveMessages.Name = "BtnStopReceiveMessages";
            this.BtnStopReceiveMessages.Size = new System.Drawing.Size(65, 49);
            this.BtnStopReceiveMessages.TabIndex = 30;
            this.BtnStopReceiveMessages.Text = "Stop";
            this.BtnStopReceiveMessages.UseVisualStyleBackColor = true;
            this.BtnStopReceiveMessages.Click += new System.EventHandler(this.BtnStopReceiveMessages_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 607);
            this.Controls.Add(this.BtnStopReceiveMessages);
            this.Controls.Add(this.TxtbxLog2);
            this.Controls.Add(this.TxtbxLog1);
            this.Controls.Add(this.NudPortDestination2);
            this.Controls.Add(this.TxtbxIPDestination2);
            this.Controls.Add(this.LblDestination2);
            this.Controls.Add(this.NudPortDestination1);
            this.Controls.Add(this.TxtbxIPDestination1);
            this.Controls.Add(this.LblDestination1);
            this.Controls.Add(this.BtnStartSendMessages2);
            this.Controls.Add(this.BtnStartSendMessages1);
            this.Controls.Add(this.LblPublicEndPoint2Value);
            this.Controls.Add(this.LblLocalEndPoint2Value);
            this.Controls.Add(this.LblPublicEndPoint2);
            this.Controls.Add(this.LblLocalEndPoint2);
            this.Controls.Add(this.LblNetType2Value);
            this.Controls.Add(this.LblNetType2);
            this.Controls.Add(this.NudRemotePublicPort2Value);
            this.Controls.Add(this.NudRemoteLocalPort2Value);
            this.Controls.Add(this.TxtbxRemotePublicIP2Value);
            this.Controls.Add(this.TxtbxRemoteLocalIP2Value);
            this.Controls.Add(this.LblRemotePublicEndPoint2);
            this.Controls.Add(this.LblRemoteLocalEndPoint2);
            this.Controls.Add(this.BtnStart2);
            this.Controls.Add(this.LblPublicEndPoint1Value);
            this.Controls.Add(this.LblLocalEndPoint1Value);
            this.Controls.Add(this.LblPublicEndPoint1);
            this.Controls.Add(this.LblLocalEndPoint1);
            this.Controls.Add(this.LblNetType1Value);
            this.Controls.Add(this.LblNetType1);
            this.Controls.Add(this.BtnStart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NudRemoteLocalPort2Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRemotePublicPort2Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPortDestination1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPortDestination2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart1;
        private System.Windows.Forms.Label LblNetType1;
        private System.Windows.Forms.Label LblNetType1Value;
        private System.Windows.Forms.Label LblLocalEndPoint1;
        private System.Windows.Forms.Label LblPublicEndPoint1;
        private System.Windows.Forms.Label LblLocalEndPoint1Value;
        private System.Windows.Forms.Label LblPublicEndPoint1Value;
        private System.Windows.Forms.Button BtnStart2;
        private System.Windows.Forms.Label LblRemotePublicEndPoint2;
        private System.Windows.Forms.Label LblRemoteLocalEndPoint2;
        private System.Windows.Forms.TextBox TxtbxRemoteLocalIP2Value;
        private System.Windows.Forms.TextBox TxtbxRemotePublicIP2Value;
        private System.Windows.Forms.NumericUpDown NudRemoteLocalPort2Value;
        private System.Windows.Forms.NumericUpDown NudRemotePublicPort2Value;
        private System.Windows.Forms.Label LblPublicEndPoint2Value;
        private System.Windows.Forms.Label LblLocalEndPoint2Value;
        private System.Windows.Forms.Label LblPublicEndPoint2;
        private System.Windows.Forms.Label LblLocalEndPoint2;
        private System.Windows.Forms.Label LblNetType2Value;
        private System.Windows.Forms.Label LblNetType2;
        private System.Windows.Forms.Button BtnStartSendMessages1;
        private System.Windows.Forms.Button BtnStartSendMessages2;
        private System.Windows.Forms.NumericUpDown NudPortDestination1;
        private System.Windows.Forms.TextBox TxtbxIPDestination1;
        private System.Windows.Forms.Label LblDestination1;
        private System.Windows.Forms.NumericUpDown NudPortDestination2;
        private System.Windows.Forms.TextBox TxtbxIPDestination2;
        private System.Windows.Forms.Label LblDestination2;
        private System.Windows.Forms.TextBox TxtbxLog1;
        private System.Windows.Forms.TextBox TxtbxLog2;
        private System.Windows.Forms.Button BtnStopReceiveMessages;
    }
}

