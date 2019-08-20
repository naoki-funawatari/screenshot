using System;
using System.Drawing;
using System.Windows.Forms;

namespace screenshot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void main_screen_Click(object sender, EventArgs e)
        {

            Screen s = Screen.AllScreens[0];
            int x = s.Bounds.X;
            int y = s.Bounds.Y;
            int w = s.Bounds.Width;
            int h = s.Bounds.Height;

            using (Bitmap b = new Bitmap(w, h))
            using (Graphics g = Graphics.FromImage(b))
            {
                g.CopyFromScreen(new Point(x, y), new Point(0, 0), b.Size);
                Clipboard.SetImage(b);
            }
        }

        private void sub_screen_Click(object sender, EventArgs e)
        {

            Screen s = Screen.AllScreens[1];
            int x = s.Bounds.X;
            int y = s.Bounds.Y;
            int w = s.Bounds.Width;
            int h = s.Bounds.Height;

            using (Bitmap b = new Bitmap(w, h))
            using (Graphics g = Graphics.FromImage(b))
            {
                g.CopyFromScreen(new Point(x, y), new Point(0, 0), b.Size);
                Clipboard.SetImage(b);
            }
        }
    }
}
