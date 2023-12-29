using System.Media;


namespace Pomodoro_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.TopLevel = true;
            this.TopMost = true;
            this.StartPosition = FormStartPosition.Manual;
            /*foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - this.Width, scrn.Bounds.Top);
                    return;
                }
            }
            */
            Rectangle res = Screen.PrimaryScreen.Bounds;
            //this.Location = new Point(res.Bounds.Right - this.Width, res.Bounds.Top);
            this.Location = new Point(res.Right - Size.Width + 210);

            //button.MouseEnter = OnMouseEnterButton1;
            //this.button.MouseLeave += OnMouseLeaveButton1;
            //this.button.Visible = false;
            InitializeComponent();

        }


        int workTimer = 25 * 60;     // sec
        int breakTimer = 5 * 60;        // sec
        Boolean workMode = true;
        Color formWorkColor = Color.FromArgb(64, 64, 64);
        Color formBreakColor = Color.Pink;

        Color resetColor = Color.FromArgb(128, 128, 255);


        private void button_Click(object sender, EventArgs e)
        {

            resetAll();
            if (!timer.Enabled)
            {
                updateDisplay(workTimer);
                updateForm(formWorkColor);
                button.Text = "Reset";
                timer.Start();
            }
            else
            {
                timer.Stop();
            }

        }

        private void display_Click(object sender, EventArgs e)
        {

        }

        private void updateDisplay(int time)
        {
            display.Text = (time >= 60) ? Math.Ceiling(time / 60f) + " Min" : time + " Sec";
            //display.BackColor = color;
        }


        private void updateForm(Color color)
        {
            BackColor = color;
        }

        private void resetAll()
        {
            button.Text = "Start";
            workMode = true;
            workTimer = 25 * 60;
            breakTimer = 5 * 60;

            updateDisplay(workTimer);
            updateForm(resetColor);
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (workMode)
            {
                updateForm(formWorkColor);
                updateDisplay(workTimer);

                if (workTimer > 0)
                {
                    workTimer--;
                }
                else
                {
                    workMode = false;
                    SoundPlayer sound = new SoundPlayer("C:\\Users\\kanwa\\Documents\\CODE\\MS Visual Studio\\Pomodoro_Timer\\Work_End.wav");
                    
                    sound.Play();
                }

            }
            else
            {
                updateForm(formBreakColor);
                updateDisplay(breakTimer);
                if (breakTimer > 0)
                {
                    breakTimer--;
                }
                else
                {
                    timer.Stop();
                    SoundPlayer sound = new SoundPlayer("C:\\Users\\kanwa\\Documents\\CODE\\MS Visual Studio\\Pomodoro_Timer\\Break_End.wav");
                    sound.Play();
                    resetAll();

                }

            }
        }

    }
}
