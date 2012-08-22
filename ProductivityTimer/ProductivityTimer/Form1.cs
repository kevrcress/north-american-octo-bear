using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace ProductivityTimer
{
    public partial class frmTimer : Form
    {
        public System.ComponentModel.BackgroundWorker backgroundWorker1;

        public string TimerText
        {
            get { return lblTimerText.Text; }
            set
            {
                lblTimerText.Text = value;
                lblTimerText.Refresh();

                Application.DoEvents();
            }
        }

        public void SetTimerText_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do not access the form's BackgroundWorker reference directly.
            // Instead, use the reference provided by the sender parameter.
            BackgroundWorker bw = sender as BackgroundWorker;

            // Extract the argument.
            Stopwatch arg = (Stopwatch)e.Argument;

            // Start the time-consuming operation.
            e.Result = SetTimerText(bw, arg);

            // If the operation was canceled by the user, 
            // set the DoWorkEventArgs.Cancel property to true.
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private object SetTimerText(BackgroundWorker bw, Stopwatch arg)
        {
            while (!bw.CancellationPending)
            {
                TimeSpan ts = arg.Elapsed;
                string eTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                TimerText = eTime;
            }
            return true;
        }


        public frmTimer()
        {
            InitializeComponent();
            lblTimerText.Text = "wtf";
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SetTimerText_DoWork);
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            TimerThread tt = new TimerThread();
            Thread timerThread = new Thread(new ThreadStart(tt.StartTimer));

            if (!string.IsNullOrWhiteSpace(txtTime.Text))
            {
                int timerLength = -1;
                if (int.TryParse(txtTime.Text, out timerLength))
                    tt.timerLength = timerLength * 1000;
            }

            timerThread.Start();
            timerThread.IsBackground = true;
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            TimerThread tt = new TimerThread();

            if (tt.isTimerRunning())
            {
                tt.PauseTimer();
            }
            else
            {
                tt.ContinueTimer();
            }
        }

    }
    public class TimerThread
    {
        public int timerLength { get; set; }


        public void StartTimer()
        {
            if (timerLength <= -1)
            {
                timerLength = 1000;
            }

            Program.timer.Start();

            while (Program.timer.IsRunning)
            {
                TimeSpan ts = Program.timer.Elapsed;
                string eTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                frmTimer frm1 = new frmTimer();
                //  frm1.backgroundWorker1.RunWorkerAsync(Program.timer);
                frm1.TimerText = eTime;
               

                if (Program.timer.ElapsedMilliseconds >= timerLength)
                {
                    Program.timer.Stop();
                    //MessageBox.Show(eTime);
                    NotifyIcon ni = new NotifyIcon();
                    ni.Visible = true;
                    System.Drawing.Icon icon = new System.Drawing.Icon("C:\\Users\\Kevin\\Programming\\ProductivityTimer\\ProductivityTimer\\res\\timericon.ico");
                    ni.Icon = icon;
                    ni.ShowBalloonTip(5000, "Time's up", eTime, ToolTipIcon.Info);
                    Thread.Sleep(1000);
                    Thread.CurrentThread.Abort();
                }
            }

        }

        public Boolean isTimerRunning()
        {

            if (Program.timer.IsRunning)
                return true;
            else
                return false;
        }

        public void PauseTimer()
        {
            Program.timer.Stop();
        }

        public void ContinueTimer()
        {
            Program.timer.Start();
        }
    }
}
