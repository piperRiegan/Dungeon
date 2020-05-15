using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.A)
            {
                pic_main.Left -= 10;
            }
            if (e.KeyCode == Keys.D)
            {
                pic_main.Left += 10;
            }
            if (e.KeyCode == Keys.S)
            {
                pic_main.Top += 10;
            }
            if (e.KeyCode == Keys.W)
            {
                pic_main.Top -= 10;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (pic_main.Right >= pic_dor1.Left)
            {
                Form2 f = new Form2();
                f.Show();
                timer1.Enabled = false;
            }
            else if(pic_main.Bottom>=pic_dor2.Top)
            {
                Form4 f = new Form4();
                f.Show();
                timer1.Enabled = false;
            }
        }
    }
}
