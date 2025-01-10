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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            cookie.Location = new Point(-20, 89);
            cookie.Name = "cookie";
            cookie.Size = new Size(664, 629);
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
            cookieTotal.Location = new Point(166, 89);
            cookieTotal.Name = "cookieTotal";
            cookieTotal.Size = new Size(273, 65);
            cookieTotal.TabIndex = 1;
            cookieTotal.Text = "XXX cookies";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.Location = new Point(1, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(643, 88);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // cookiesPS
            // 
            cookiesPS.AutoSize = true;
            cookiesPS.BackColor = SystemColors.ControlDarkDark;
            cookiesPS.Font = new Font("Microsoft Himalaya", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cookiesPS.Location = new Point(214, 134);
            cookiesPS.Name = "cookiesPS";
            cookiesPS.Size = new Size(164, 42);
            cookiesPS.TabIndex = 3;
            cookiesPS.Text = "per second: ";
            cookiesPS.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            BackgroundImage = Properties.Resources.OIP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1228, 799);
            Controls.Add(cookiesPS);
            Controls.Add(cookieTotal);
            Controls.Add(pictureBox1);
            Controls.Add(cookie);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cookie;
        private Label cookieTotal;
        private PictureBox pictureBox1;
        private Label cookiesPS;
    }
}
