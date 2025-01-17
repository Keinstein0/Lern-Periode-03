using CookieClicker;
using System.Threading.Tasks;


namespace CookieClicker
{
    public partial class Form1 : Form
    {
        int cookies = 0;
        int clickStrength = 1;
        bool cookieSize = true;
        int csSpeed = 0;
        int cps = 0;
        StoreEntry grandmother;

        public Form1()
        {
            InitializeComponent();
            always();

            Thread spinny = new Thread(spinnyThing);
            spinny.Start();

            resize(cookie, 660);

            grandmother = new StoreEntry(1, this, @"C:\Users\alex\source\repos\CookieClicker\CookieClicker\grandmaIcon.png", "Grandma", 100);

            //StoreEntry whatever = new StoreEntry(2,this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void cookie_Click(object sender, EventArgs e)
        {
            cookies += clickStrength;
            cookieTotal.Text = $"{cookies} cookies";
            cookieSize = false;
            /*
            if (ApiInformation.IsMethodPresent("Windows.UI.Xaml.Media.Imaging.BitmapImage", "Play"))
            {
                cookie.Play();
            }*/

        }
        private async void always()
        {
            bool nextFrame = false;


            while (true)
            {
                await Task.Delay(10);

                if (!cookieSize)
                {
                    cookieSize = true;

                    resize(cookie, 640);

                    await Task.Delay(50);



                    resize(cookie, 660);

                }
                cookiesPS.Text = $"{cps} per second";
                grandmother.render(cookies);


            }
        }
        public void purchase(int addCps,int cost)
        {
            cps += addCps;
            cookies -= cost;
        }

        private async void spinnyThing()
        {
            List<Bitmap> frames = new List<Bitmap>();

            for (int i = 0; i < 280; i++)
            {
                Image img = Image.FromFile($@"C:\Users\alex\Downloads\images\0117-{i}.png"); //FIX IMMEDIATELY

                frames.Add(new Bitmap(img));
            }


            int index = 0;
            while (true)
            {
                await Task.Delay(20);
                index++;

                cookie.BackgroundImage = frames[index];

                if (index >= 279)
                {
                    index = 0;
                }


            }
        }


        public void resize(Button button, int newWidth)
        {
            if (button == null || newWidth <= 0)
                throw new ArgumentException("Invalid button or width.");

            float aspectRatio = (float)button.Height / button.Width;

            int newHeight = (int)(newWidth * aspectRatio);

            Point center = new Point(button.Left + button.Width / 2, button.Top + button.Height / 2);

            button.Size = new Size(newWidth, newHeight);

            button.Left = center.X - button.Width / 2;
            button.Top = center.Y - button.Height / 2;


            button.ImageAlign = ContentAlignment.MiddleCenter;
            button.TextAlign = ContentAlignment.MiddleCenter; // Adjust if text is present

            Image originalImage = Image.FromFile(@"C:\Users\alex\Downloads\cookie-cookie-from-cookie-clicker-11563236737bj2c4xyraj-removebg-preview (1).png"); // FIX ASAP Really bad stuff right here

            float newiWidth = newWidth - 250;

            int targetHeight = (int)(newiWidth / aspectRatio);

            Bitmap resizedImage = new Bitmap(originalImage, new Size(Convert.ToInt32(newiWidth), targetHeight));

            button.Image = resizedImage;

            if (newiWidth == 664)
            {
                button.Image = originalImage;
            }




        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

public class StoreEntry:Form
{
    int pos;
    int cost;
    int cookies;
    Button button = new Button();
    Label nameLabel = new Label();
    Label costLabel = new Label();
    Form form;
    public StoreEntry(int pos,Form form,string icon,string name, int cost)
    {
        this.pos = pos;
        this.cost = cost;
        this.form = form;

        button.Location = new Point(1310,150+(pos*120));
        button.Size = new Size(500,120);
        button.Visible = true;

        button.BackgroundImage = Image.FromFile(@"C:\Users\alex\source\repos\CookieClicker\CookieClicker\storeTile.jpg");
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
        costLabel.Font = new Font("Mictosoft Himalaya", 9, FontStyle.Bold);
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
    }
    
    private void shopClick(object sender, EventArgs e)
    {
        //Button clickedButton = sender as Button;
        if (cost <= cookies)
        {
            form.purchase(1, cost);
        }







    }


}
