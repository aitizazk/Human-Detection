namespace trackk
{
    partial class f21
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
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.camerasCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.videoSourcePlayer2 = new AForge.Controls.VideoSourcePlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.videoSourcePlayer3 = new AForge.Controls.VideoSourcePlayer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(22, 12);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(392, 385);
            this.videoSourcePlayer1.TabIndex = 3;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.ShowHelp = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.camerasCombo);
            this.groupBox1.Location = new System.Drawing.Point(22, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "connection";
            this.groupBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // camerasCombo
            // 
            this.camerasCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camerasCombo.FormattingEnabled = true;
            this.camerasCombo.Location = new System.Drawing.Point(17, 26);
            this.camerasCombo.Name = "camerasCombo";
            this.camerasCombo.Size = new System.Drawing.Size(167, 21);
            this.camerasCombo.TabIndex = 5;
            this.camerasCombo.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 113);
            this.button1.TabIndex = 6;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // videoSourcePlayer2
            // 
            this.videoSourcePlayer2.Location = new System.Drawing.Point(420, 12);
            this.videoSourcePlayer2.Name = "videoSourcePlayer2";
            this.videoSourcePlayer2.Size = new System.Drawing.Size(392, 385);
            this.videoSourcePlayer2.TabIndex = 4;
            this.videoSourcePlayer2.Text = "videoSourcePlayer2";
            this.videoSourcePlayer2.VideoSource = null;
            this.videoSourcePlayer2.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer1_NewFrame);
            this.videoSourcePlayer2.Click += new System.EventHandler(this.videoSourcePlayer2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 117);
            this.label1.TabIndex = 12;
            this.label1.Text = "CS-418\r\n\r\nDigital Image Processing Project by\r\n\r\nAitizaz Khan\r\n\r\nShahrukh Khan\r\n\r" +
    "\nSheece Raza";
            // 
            // videoSourcePlayer3
            // 
            this.videoSourcePlayer3.Location = new System.Drawing.Point(834, 12);
            this.videoSourcePlayer3.Name = "videoSourcePlayer3";
            this.videoSourcePlayer3.Size = new System.Drawing.Size(392, 385);
            this.videoSourcePlayer3.TabIndex = 7;
            this.videoSourcePlayer3.Text = "videoSourcePlayer3";
            this.videoSourcePlayer3.VideoSource = null;
            this.videoSourcePlayer3.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer3_NewFrame);
            this.videoSourcePlayer3.Click += new System.EventHandler(this.videoSourcePlayer3_Click);
            // 
            // f21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1284, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videoSourcePlayer3);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.videoSourcePlayer2);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "f21";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Human detection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f21_FormClosing);
            this.Load += new System.EventHandler(this.f21_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox camerasCombo;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer2;
        private System.Windows.Forms.Label label1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer3;
    }
}

