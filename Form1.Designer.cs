namespace CookieClicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cookie = new Button();
            cookieTotal = new Label();
            pictureBox1 = new PictureBox();
            cookiesPS = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // cookie
            // 
            cookie.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cookie.BackColor = Color.Transparent;
            cookie.BackgroundImage = (Image)resources.GetObject("cookie.BackgroundImage");
            cookie.BackgroundImageLayout = ImageLayout.Zoom;
            cookie.FlatStyle = FlatStyle.Popup;
            cookie.ForeColor = Color.Transparent;
            cookie.Image = (Image)resources.GetObject("cookie.Image");
            cookie.Location = new Point(-22, 95);
            cookie.Name = "cookie";
            cookie.Size = new Size(719, 671);
            cookie.TabIndex = 0;
            cookie.TextImageRelation = TextImageRelation.ImageAboveText;
            cookie.UseVisualStyleBackColor = false;
            cookie.Click += cookie_Click;
            // 
            // cookieTotal
            // 
            cookieTotal.AutoSize = true;
            cookieTotal.BackColor = SystemColors.ControlDarkDark;
            cookieTotal.Font = new Font("Microsoft Himalaya", 27.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cookieTotal.Location = new Point(180, 95);
            cookieTotal.Name = "cookieTotal";
            cookieTotal.Size = new Size(315, 75);
            cookieTotal.TabIndex = 1;
            cookieTotal.Text = "XXX cookies";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.Location = new Point(1, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(697, 94);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // cookiesPS
            // 
            cookiesPS.AutoSize = true;
            cookiesPS.BackColor = SystemColors.ControlDarkDark;
            cookiesPS.Font = new Font("Microsoft Himalaya", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cookiesPS.Location = new Point(232, 143);
            cookiesPS.Name = "cookiesPS";
            cookiesPS.Size = new Size(187, 48);
            cookiesPS.TabIndex = 3;
            cookiesPS.Text = "per second: ";
            cookiesPS.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.panelVertical;
            pictureBox2.Location = new Point(692, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 988);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.panelVertical;
            pictureBox3.Location = new Point(1290, -20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 988);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ControlDarkDark;
            pictureBox4.Location = new Point(1309, 45);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(490, 94);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Font = new Font("Microsoft Himalaya", 27.85715F, FontStyle.Bold);
            label1.Location = new Point(1482, 55);
            label1.Name = "label1";
            label1.Size = new Size(143, 75);
            label1.TabIndex = 7;
            label1.Text = "Store";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            BackgroundImage = Properties.Resources.OIP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1784, 980);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(cookiesPS);
            Controls.Add(cookieTotal);
            Controls.Add(pictureBox1);
            Controls.Add(cookie);
            Controls.Add(pictureBox4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cookie;
        private Label cookieTotal;
        private PictureBox pictureBox1;
        private Label cookiesPS;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
    }
}
