using Pomeroo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomeroo
{
    public partial class Form1 : Form
    {
        // for window dragging
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // general parameters
        bool isRunning = false;
        bool isWorkTime = true;
        int completedCycles = 0;
        int timeLeft;
        int workTime;
        int shortRest;
        int longRest;
        int cycleCount;

        public Form1()
        {
            InitializeComponent();

            // for window dragging
            pnlTop.MouseDown += new MouseEventHandler(pnlTop_MouseDown);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            workTime = TimerModel.workTime;
            shortRest = TimerModel.shortRest;
            longRest = TimerModel.longRest;
            cycleCount = TimerModel.cycleCount;

            timeLeft = workTime;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;
                timer1.Start();
                btnStart.Text = "Pause";
            }
            else
            {
                isRunning = false;
                timer1.Stop();
                btnStart.Text = "Start";
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                TimeSpan ts = TimeSpan.FromSeconds(timeLeft);
                lblTimer.Text = ts.ToString(@"mm\:ss");
            }
            else
            {
                timer1.Stop();
                isRunning = false;

                if(isWorkTime)
                {
                    completedCycles++;
                    if (completedCycles % cycleCount == 0)
                    {
                        timeLeft = longRest;
                        lblSession.Text = "Long Rest";
                        notifyIcon1.ShowBalloonTip(2000, "Long Rest", "Time to take a long rest!", ToolTipIcon.Info);
                        SystemSounds.Exclamation.Play();
                    }
                    else
                    {
                        timeLeft = shortRest;
                        lblSession.Text = "Short Rest";
                        notifyIcon1.ShowBalloonTip(2000, "Short Rest", "Time to take a short rest!", ToolTipIcon.Info);
                        SystemSounds.Exclamation.Play();
                    }
                }
                else
                {
                    timeLeft = workTime;
                    lblSession.Text = "Work";
                    notifyIcon1.ShowBalloonTip(2000, "Work", "Time to work!", ToolTipIcon.Info);
                    SystemSounds.Exclamation.Play();
                }

                isWorkTime = !isWorkTime;
                timer1.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
