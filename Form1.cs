using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoom_上課
{
    public partial class main : Form
    {
        public main()
        {
            Common.NoSameApp();
            Console.WriteLine(Environment.UserName);
            Process.Start($@"C:\Users\{Environment.UserName}\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Zoom\Zoom.lnk");
            InitializeComponent();

            RoomList = new List<Room>();
            using StreamReader sr = new StreamReader(path);
            while (sr.Peek() != -1)
                RoomList.Add(new Room(sr.ReadLine()));

            flowLayoutPanel.Controls.AddRange(RoomList.ToArray());
            foreach (Control control in flowLayoutPanel.Controls)
                (control as Room).GoToRoom.Click += GoToRoom_Click;
            Application.DoEvents();

            setAutoStart();
        }

        const string path = @"List.txt";
        List<Room> RoomList;
        Common.StreamService streamService = new Common.StreamService("settings.txt");
        string link;

        void setAutoStart()
        {
            var list = RoomList.Select(x => x.Topic).ToList();
            var oList = new List<string>(list);
            int index = list.IndexOf(DateTime.Now.DayOfWeek.ToString());
            if (index < 0)
            {
                MessageBox.Show($"Cannot find {DateTime.Now.DayOfWeek}");
                return;
            }
            list.RemoveRange(0, index + 1);
            foreach (var span in list)
            {
                if (!span.Contains('-'))
                    break;
                string s = span.Remove(span.IndexOf('-'));
                var time = TimeSpan.Parse(s.Remove(s.Length - 2));
                time = s[s.Length - 2] == 'p' ? time.Add(new TimeSpan(12, 0, 0)) : time;
                var timeLeft = time - DateTime.Now.TimeOfDay + new TimeSpan(0, 5, 0);
                if (timeLeft.TotalMilliseconds < 0)
                    continue;
                timer.Interval = (int)timeLeft.TotalMilliseconds;
                timer.Enabled = true;
                var upComingRoom = RoomList[oList.IndexOf(span)];
                link = upComingRoom.Link;
                MessageBox.Show($"Up coming lesson: {upComingRoom.Topic}\n\nAfter\t{timeLeft.Hours}:{timeLeft.Minutes}\nOn\t{notify.Text = time.To_hhmmtt()}", "Next lesson will be auto started:");
                break;
            }
        }

        private void flowLayoutPanel_Resize(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel.Controls)
                control.Width = flowLayoutPanel.Width;
        }

        private async void GoToRoom_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            await Task.Delay(3000);
            UseWaitCursor = false;
            WindowState = FormWindowState.Minimized;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            Process.Start(link);
            setAutoStart();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            notify.Visible = false;
            Environment.Exit(0);
        }

        private void notify_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Show();
            TopMost = false;
        }

        private void autoHide_Click(object sender, EventArgs e) => streamService.Save(new string[] { (autoHide.Checked = !autoHide.Checked).ToString() });

        private void main_Load(object sender, EventArgs e)
        {
            if (autoHide.Checked = Convert.ToBoolean(streamService.Load().ElementAt(0)))
                this.Hide_InLoad();
        }

        private void openFile_Click(object sender, EventArgs e) => Process.Start(Environment.CurrentDirectory);

        private void edite_Click(object sender, EventArgs e) => Process.Start(path);

        private void main_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    openFile_Click(null, null);
                    break;
                case Keys.F2:
                    edite_Click(null, null);
                    break;
            }
        }
    }
}
