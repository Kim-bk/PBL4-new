
namespace PBL4
{
    partial class Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbOptions = new System.Windows.Forms.ComboBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.richtxtChat = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFrench = new System.Windows.Forms.RichTextBox();
            this.txtEnglish = new System.Windows.Forms.RichTextBox();
            this.txtVietnamese = new System.Windows.Forms.RichTextBox();
            this.lblErr = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbFile = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(91, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(91, 70);
            this.txtIP.Margin = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(154, 30);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "26.109.234.241";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(91, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(92, 162);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(152, 30);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "6969";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.AliceBlue;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConnect.Location = new System.Drawing.Point(44, 541);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(138, 41);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(10, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tiếng Việt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(328, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tiếng Anh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(644, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tiếng Pháp";
            // 
            // cbbOptions
            // 
            this.cbbOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbOptions.ForeColor = System.Drawing.Color.Black;
            this.cbbOptions.FormattingEnabled = true;
            this.cbbOptions.Items.AddRange(new object[] {
            "Nhập tay",
            "Chọn File"});
            this.cbbOptions.Location = new System.Drawing.Point(132, 59);
            this.cbbOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbOptions.Name = "cbbOptions";
            this.cbbOptions.Size = new System.Drawing.Size(148, 33);
            this.cbbOptions.TabIndex = 12;
            this.cbbOptions.SelectedIndexChanged += new System.EventHandler(this.cbbOptions_SelectedIndexChanged);
            // 
            // txtFile
            // 
            this.txtFile.BackColor = System.Drawing.Color.White;
            this.txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.Location = new System.Drawing.Point(205, 105);
            this.txtFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(581, 30);
            this.txtFile.TabIndex = 14;
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnChon.Location = new System.Drawing.Point(799, 100);
            this.btnChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(138, 40);
            this.btnChon.TabIndex = 15;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(15, 161);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(771, 74);
            this.txtInput.TabIndex = 20;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSend.Location = new System.Drawing.Point(799, 162);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(138, 74);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnShutDown
            // 
            this.btnShutDown.BackColor = System.Drawing.Color.Red;
            this.btnShutDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutDown.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnShutDown.Location = new System.Drawing.Point(44, 614);
            this.btnShutDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(138, 41);
            this.btnShutDown.TabIndex = 22;
            this.btnShutDown.Text = "Ngắt";
            this.btnShutDown.UseVisualStyleBackColor = false;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // richtxtChat
            // 
            this.richtxtChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtChat.Location = new System.Drawing.Point(15, 250);
            this.richtxtChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richtxtChat.Name = "richtxtChat";
            this.richtxtChat.ReadOnly = true;
            this.richtxtChat.Size = new System.Drawing.Size(922, 274);
            this.richtxtChat.TabIndex = 23;
            this.richtxtChat.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnShutDown);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.txtIP);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 736);
            this.panel1.TabIndex = 25;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(93, 250);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 30);
            this.txtName.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(91, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(7, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 46);
            this.label6.TabIndex = 28;
            this.label6.Text = "HĐH và MMT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PBL4.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(30, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 82);
            this.label7.TabIndex = 27;
            this.label7.Text = "PBL4";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtFrench);
            this.panel2.Controls.Add(this.txtEnglish);
            this.panel2.Controls.Add(this.txtVietnamese);
            this.panel2.Controls.Add(this.lblErr);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lbFile);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.cbbOptions);
            this.panel2.Controls.Add(this.txtInput);
            this.panel2.Controls.Add(this.richtxtChat);
            this.panel2.Controls.Add(this.txtFile);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.btnChon);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(272, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 736);
            this.panel2.TabIndex = 26;
            // 
            // txtFrench
            // 
            this.txtFrench.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFrench.Location = new System.Drawing.Point(649, 554);
            this.txtFrench.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFrench.Name = "txtFrench";
            this.txtFrench.ReadOnly = true;
            this.txtFrench.Size = new System.Drawing.Size(288, 139);
            this.txtFrench.TabIndex = 32;
            this.txtFrench.Text = "";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEnglish.Location = new System.Drawing.Point(334, 554);
            this.txtEnglish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.ReadOnly = true;
            this.txtEnglish.Size = new System.Drawing.Size(285, 139);
            this.txtEnglish.TabIndex = 31;
            this.txtEnglish.Text = "";
            // 
            // txtVietnamese
            // 
            this.txtVietnamese.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVietnamese.Location = new System.Drawing.Point(15, 555);
            this.txtVietnamese.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVietnamese.Name = "txtVietnamese";
            this.txtVietnamese.ReadOnly = true;
            this.txtVietnamese.Size = new System.Drawing.Size(289, 139);
            this.txtVietnamese.TabIndex = 30;
            this.txtVietnamese.Text = "";
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErr.ForeColor = System.Drawing.Color.Red;
            this.lblErr.Location = new System.Drawing.Point(304, 62);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(0, 25);
            this.lblErr.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(181, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(625, 32);
            this.label8.TabIndex = 28;
            this.label8.Text = "Chương trình Client - Server đổi số thành chữ";
            // 
            // lbFile
            // 
            this.lbFile.AutoSize = true;
            this.lbFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFile.ForeColor = System.Drawing.Color.Black;
            this.lbFile.Location = new System.Drawing.Point(127, 105);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(72, 29);
            this.lbFile.TabIndex = 25;
            this.lbFile.Text = "File :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PBL4.Properties.Resources._5;
            this.pictureBox2.Location = new System.Drawing.Point(9, 22);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1233, 736);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Client";
            this.Text = "Client";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbOptions;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.RichTextBox richtxtChat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.RichTextBox txtFrench;
        private System.Windows.Forms.RichTextBox txtEnglish;
        private System.Windows.Forms.RichTextBox txtVietnamese;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
    }
}

