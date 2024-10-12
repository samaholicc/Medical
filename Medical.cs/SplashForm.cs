namespace Medical.cs
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
            }
            else
            {
                // Stop the timer once the progress bar is full
                timer1.Stop();
                LaunchLoginForm();
                this.Hide();
            }
        }
        private void LaunchLoginForm()
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }


}

