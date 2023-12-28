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
            this.Location = new Point(res.Right - Size.Width + 180);


            InitializeComponent();
        }
        int workTimer = 25 * 60;     // sec
        int breakTimer = 5 * 60;        // sec
        Boolean workMode = true;
        Color workColor = Color.FromArgb(192, 192, 0);
        Color breakColor = Color.Pink;

        private const int CP_NOCLOSE_BUTTON = 0x200;

        private void button_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                timer.Start();
            }
            else
            {
                timer.Stop();
                workMode = true;
                workTimer = 25 * 60;
                updateDisplay(workTimer, workColor);
            }
            
        }

        private void display_Click(object sender, EventArgs e)
        {

        }

        private void updateDisplay(int time, Color color)
        {
            String text = "";
            if (time > 60)
            {
                text = time / 60 + " Min";
            }
            else
            {
                text = time + " Sec";
            }
            display.Text = text;
            display.BackColor = color;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (workMode)
            {
                updateDisplay(workTimer, workColor);
                button.Text = "Work";
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
                button.Text = "Chill";
                updateDisplay(breakTimer, breakColor);
                if (breakTimer > 0)
                {
                    breakTimer--;
                }
                else
                {
                    workMode = true;
                    SoundPlayer sound = new SoundPlayer("C:\\Users\\kanwa\\Documents\\CODE\\MS Visual Studio\\Pomodoro_Timer\\Break_End.wav");
                    sound.Play();
                    timer.Stop();
                    button.Text = "Start";
                }
                
            }
        }
    }
}
