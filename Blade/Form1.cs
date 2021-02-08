using System;
using System.Drawing;
using System.Windows.Forms;
using Colore;
using ColoreColor = Colore.Data.Color;
using ColoreKey = Colore.Effects.Keyboard.Key;

namespace Blade
{
    public partial class window1 : Form
    {
        public window1()
        {
            InitializeComponent();
        }

        // Window logic
        Point lastPoint;
        private void window1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void window1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Main Window Elements

        private async void blue_color_Click(object sender, EventArgs e)
        {
            var chroma = await ColoreProvider.CreateNativeAsync();
            await chroma.SetAllAsync(ColoreColor.Blue);
        }

        private async void black_color_Click(object sender, EventArgs e)
        {
            var chroma = await ColoreProvider.CreateNativeAsync();
            await chroma.SetAllAsync(ColoreColor.Black);
        }

        private async void reset_button_Click(object sender, EventArgs e)
        {
            var chroma = await ColoreProvider.CreateNativeAsync();
            await chroma.UninitializeAsync();
        }

        private async void green_button_Click(object sender, EventArgs e)
        {
            var chroma = await ColoreProvider.CreateNativeAsync();
            await chroma.SetAllAsync(ColoreColor.Green);
        }

        private async void hotpink_button_Click(object sender, EventArgs e)
        {
            var chroma = await ColoreProvider.CreateNativeAsync();
            await chroma.SetAllAsync(ColoreColor.HotPink);
        }

        private async void orange_button_Click(object sender, EventArgs e)
        {
            var chroma = await ColoreProvider.CreateNativeAsync();
            await chroma.SetAllAsync(ColoreColor.Orange);
        }

        private async void pink_button_Click(object sender, EventArgs e)
        {
            var chroma = await ColoreProvider.CreateNativeAsync();
            await chroma.SetAllAsync(ColoreColor.Pink);
        }

        private async void purple_button_Click(object sender, EventArgs e)
        {
            var chroma = await ColoreProvider.CreateNativeAsync();
            await chroma.SetAllAsync(ColoreColor.Purple);
        }

        private async void red_button_Click(object sender, EventArgs e)
        {
            var chroma = await ColoreProvider.CreateNativeAsync();
            await chroma.SetAllAsync(ColoreColor.Red);
        }

        private async void white_button_Click(object sender, EventArgs e)
        {
            var chroma = await ColoreProvider.CreateNativeAsync();
            await chroma.SetAllAsync(ColoreColor.White);
        }

        private async void yellow_button_Click(object sender, EventArgs e)
        {
            var chroma = await ColoreProvider.CreateNativeAsync();
            await chroma.SetAllAsync(ColoreColor.Yellow);
        }

        private async void typingmode_button_Click(object sender, EventArgs e)
        {
            var chroma = await ColoreProvider.CreateNativeAsync();
            await chroma.SetAllAsync(ColoreColor.Black);
            await chroma.Keyboard.SetKeysAsync(ColoreColor.White, ColoreKey.A, ColoreKey.S, ColoreKey.D, ColoreKey.F, ColoreKey.J, ColoreKey.K, ColoreKey.L, ColoreKey.OemSemicolon);
        }
    }
}