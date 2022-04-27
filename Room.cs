using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Zoom_上課
{
    public partial class Room : UserControl
    {
        public Room(string str)
        {
            InitializeComponent();
            if (str.Count(s => s == ',') == 2)
            {
                var s = str.Split(',').ToList();
                s.ForEach(e => e.Trim());
                GoToRoom.Text = s[0];
                id.Text = s[1];
                password.Text = s[2];
            }
            else
            {
                id.Text = str;
                id.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
                GoToRoom.Visible = password.Visible = false;
            }
        }

        public string Topic { get => id.Text; }
        public string Link { get => password.Text; }

        private void GoToRoom_Click(object sender, EventArgs e) => Process.Start(password.Text);
    }
}
