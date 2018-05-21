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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ok");
        }

        //private void button2_MouseHover(object sender, EventArgs e)
        //{
        //    Random r = new Random();
        //    button2.Location = new Point(r.Next(400, 700), button2.Location.Y);
        //}


        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            button2.Location = new Point(r.Next(0, this.ClientSize.Width- button2.Size.Height), r.Next(0, this.ClientSize.Height - button2.Size.Height));
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            button2.Location = new Point(r.Next(0, this.ClientSize.Width - button2.Size.Height), r.Next(0, this.ClientSize.Height - button2.Size.Height));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
