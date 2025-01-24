using CookieClicker;
using System.Threading.Tasks;


namespace CookieClicker
{
    public partial class Form1 : Form
    {
        int cookies = 0;
        int clickStrength = 1;
        int cookieSizeTarget = 50;
        int csSpeed = 0;
        int cps = 0;
        bool mic = false;
        StoreEntry grandmother;

        public Form1()
        {
            InitializeComponent();
            always();
            alwaysSecond();

            Thread spinny = new Thread(spinnyThing);
            spinny.Start();

            cookie.MouseEnter += OnMouseEntercookie;
            cookie.MouseLeave += OnMouseLeavecookie;
            

            resize(50);

            grandmother = new StoreEntry(1, this, @"..\..\..\..\CookieClicker\grandmaIcon.png", "Grandma", 100,1);

            //StoreEntry whatever = new StoreEntry(2,this);
        }

        public void purchase(int addCps, int cost)
        {
            cps += addCps;
            cookies -= cost;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private async void cookie_Click(object sender, EventArgs e)
        {
            cookies += clickStrength;
            
            cookieSizeTarget = 20;

            await Task.Delay(300);

            cookieSizeTarget = 50;
            if (mic)
            {
                cookieSizeTarget = 90;
            }



            /*
            if (ApiInformation.IsMethodPresent("Windows.UI.Xaml.Media.Imaging.BitmapImage", "Play"))
            {
                cookie.Play();
            }*/

        }
        private void OnMouseEntercookie(object sender, EventArgs e)
        {
            cookieSizeTarget = 90;
            mic = true;
            
        }
        private void OnMouseLeavecookie(object sender, EventArgs e)
        {
            cookieSizeTarget = 50;
            mic = false;
        }





        private async void always()
        {
            bool nextFrame = false;
            double resizeSpeed = 0;
            int accSize = 50;
            int accLast = 50;

            while (true)
            {
                await Task.Delay(10);

                resize(accSize);

                accSize = Convert.ToInt32(accSize + resizeSpeed);



                resizeSpeed = (cookieSizeTarget - accLast) * 0.3;
                accLast = accSize;

                cookiesPS.Text = $"{cps} per second";
                cookieTotal.Text = $"{cookies} cookies";
                grandmother.render(cookies);


            }
        }
        private async void alwaysSecond()
        {
            while (true)
            {
                await Task.Delay(1000);
                cookies += cps;
            }
        }



        private async void spinnyThing()
        {
            List<Bitmap> frames = new List<Bitmap>();

            for (int i = 0; i < 280; i++)
            {
                Image img = Image.FromFile($@"..\..\..\..\CookieClicker\imagesBG\0117(2)-{i}.png"); 

                frames.Add(new Bitmap(img));
            }


            int index = 0;
            while (true)
            {
                await Task.Delay(35);
                index++;

                cookie.BackgroundImage = frames[index];

                if (index >= 279)
                {
                    index = 0;
                }


            }
        }

        

        
        public void resize(int size)
        {
            cookie.ImageAlign = ContentAlignment.MiddleCenter;

            size = Math.Clamp(size, 0, 99);

            Image image = Image.FromFile(@$"..\..\..\..\CookieClicker\imagesCookie\cookieAnimation-{size}.png");

            cookie.Image = new Bitmap(image, new Size(400, 400));
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

public partial class StoreEntry : Form
{
    int pos;
    int cost;
    int cookies;
    int cps;
    Button button = new Button();
    Label nameLabel = new Label();
    Label costLabel = new Label();
    Form1 form;
    //public partial void purchase();
    public StoreEntry(int pos,Form1 form,string icon,string name, int cost, int cps)
    {
        this.pos = pos;
        this.cost = cost;
        this.form = form;
        this.cps = cps;

        button.Location = new Point(1310,150+(pos*120));
        button.Size = new Size(500,120);
        button.Visible = true;

        button.BackgroundImage = Image.FromFile(@"..\..\..\..\CookieClicker\storeTile.jpg");
        button.BackgroundImageLayout = ImageLayout.Stretch;

        button.Image = Image.FromFile(icon);
        button.ImageAlign = ContentAlignment.MiddleLeft;

        nameLabel.Location = new Point(1410, 170 + (pos * 120));
        nameLabel.Size = new Size(270, 50);
        nameLabel.Text = name;

        nameLabel.BackColor = Color.FromArgb(177, 174, 161);
        nameLabel.Font = new Font("MicrosoftHimalaya", 17, FontStyle.Bold);

        costLabel.Location = new Point(1410, 220 + (pos*120));
        costLabel.Size = new Size(170, 30);
        costLabel.Font = new Font("Microsoft Himalya", 9, FontStyle.Bold);
        costLabel.Text = Convert.ToString(cost);
        costLabel.BackColor = Color.FromArgb(177, 174, 161);
        costLabel.ForeColor = Color.Firebrick;

        button.Click += shopClick;


        form.Controls.Add(costLabel);
        form.Controls.Add(nameLabel);
        form.Controls.Add(button);
    }

    public void render(int amountOfCookies)
    {
        if (cost <= amountOfCookies)
        {
            costLabel.ForeColor = Color.Green;
        }
        else
        {
            costLabel.ForeColor = Color.Red;
        }
        cookies = amountOfCookies;
        costLabel.Text = Convert.ToString(cost);
    }
    
    private void shopClick(object sender, EventArgs e)
    {
        //Button clickedButton = sender as Button;
        if (cost <= cookies)
        {
            Console.WriteLine(form);
            form.purchase(cps,cost);

            cost = Convert.ToInt32(cost * 1.15);
            
        }







    }


}
