namespace GameCaro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LAN = new System.Windows.Forms.Button();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.progressBarCooldown = new System.Windows.Forms.ProgressBar();
            this.NamePlayer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 879);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImage = global::GameCaro.Properties.Resources.caro;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(917, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 320);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.LAN);
            this.panel3.Controls.Add(this.textBoxIP);
            this.panel3.Controls.Add(this.pictureBox);
            this.panel3.Controls.Add(this.progressBarCooldown);
            this.panel3.Controls.Add(this.NamePlayer);
            this.panel3.Location = new System.Drawing.Point(918, 339);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 552);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "5 in aLine To Win";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LAN
            // 
            this.LAN.Location = new System.Drawing.Point(25, 171);
            this.LAN.Name = "LAN";
            this.LAN.Size = new System.Drawing.Size(109, 39);
            this.LAN.TabIndex = 4;
            this.LAN.Text = "Kết nối";
            this.LAN.UseVisualStyleBackColor = true;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(8, 143);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(162, 22);
            this.textBoxIP.TabIndex = 3;
            this.textBoxIP.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox.Location = new System.Drawing.Point(188, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(143, 137);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // progressBarCooldown
            // 
            this.progressBarCooldown.Location = new System.Drawing.Point(8, 46);
            this.progressBarCooldown.Name = "progressBarCooldown";
            this.progressBarCooldown.Size = new System.Drawing.Size(162, 91);
            this.progressBarCooldown.TabIndex = 1;
            // 
            // NamePlayer
            // 
            this.NamePlayer.Location = new System.Drawing.Point(8, 3);
            this.NamePlayer.Name = "NamePlayer";
            this.NamePlayer.ReadOnly = true;
            this.NamePlayer.Size = new System.Drawing.Size(162, 22);
            this.NamePlayer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 100);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hướng dẫn :\r\nTheo lần lượt từng người chơi \r\nAi được 5 đường ke thì win :)) \r\nGam" +
    "e Ez mà bạn \r\n";
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 903);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LAN;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ProgressBar progressBarCooldown;
        private System.Windows.Forms.TextBox NamePlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmCoolDown;
    }
}

