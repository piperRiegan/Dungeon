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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode==Keys.A)
            {
                pic_main.Left -= 10;
            }
            if(e.KeyCode==Keys.D)
            {
                pic_main.Left += 10;
            }
            if(e.KeyCode==Keys.S)
            {
                pic_main.Top += 10;
            }
            if(e.KeyCode==Keys.W)
            {
                pic_main.Top -= 10;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
      
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (pic_main.Left<=pic_dor1.Right)
            {
                Form3 f = new Form3();
                f.Show();
                timer1.Enabled = false;
            }
        }
    }
}
