using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_WinForms
{
    public partial class Form2 : Form
    {
        int movex;
        int movey;
        public Form2()
        {
            InitializeComponent();
            movex = 15;
            movey = 15;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Location = new Point(
                button1.Location.X + movex,
                button1.Location.Y + movey
                );

            if (button1.Location.Y < 0)
                movey = 15;
            if (button1.Location.X < 0)
                movex = 15;
            if (button1.Location.X > this.ClientSize.Width - button1.Size.Width)
                movex = -15;
            if (button1.Location.Y > this.ClientSize.Height - button1.Size.Height)
                movey = -15;

        }
    }
}
