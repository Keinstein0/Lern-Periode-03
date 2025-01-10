using System.Threading.Tasks;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        int cookies = 0;
        int clickStrength = 1;
        int cookieSize = 664;
        int csSpeed = 0;

        public Form1()
        {
            InitializeComponent();
            always();

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
            csSpeed += -10;

        }
        private async void always()
        {
            while (true)
            {
                await Task.Delay(50);

                ResizeButtonX(cookie, cookieSize);
                cookieSize += csSpeed;
            }
        }


        public void ResizeButtonX(Button button, int newWidth)
        {
            if (button == null || newWidth <= 0)
                throw new ArgumentException("Invalid button or width.");

            // Calculate the aspect ratio of the button
            float aspectRatio = (float)button.Height / button.Width;

            // Calculate the new height to maintain the aspect ratio
            int newHeight = (int)(newWidth * aspectRatio);

            // Calculate the center point of the button
            Point center = new Point(button.Left + button.Width / 2, button.Top + button.Height / 2);

            // Adjust the size of the button
            button.Size = new Size(newWidth, newHeight);

            // Recalculate the position to keep the center in the same place
            button.Left = center.X - button.Width / 2;
            button.Top = center.Y - button.Height / 2;

            button.BackgroundImageLayout = ImageLayout.None;

            // Ensure the image stays centered
            //button.BackgroundImageLayout = ContentAlignment.MiddleCenter; //= ContentAlignment.MiddleCenter;
            button.ImageAlign = ContentAlignment.MiddleCenter;
            button.TextAlign = ContentAlignment.MiddleCenter; // Adjust if text is present

            Image originalImage = button.Image;

            float newiWidth = newWidth - 250;

            // Calculate the new height to maintain aspect ratio
            int targetHeight = (int)(newiWidth / aspectRatio);

            // Resize the image
            Bitmap resizedImage = new Bitmap(originalImage, new Size(Convert.ToInt32(newiWidth), targetHeight));

            // Set the resized image back to the button
            button.Image = resizedImage;




        }

    }
}
