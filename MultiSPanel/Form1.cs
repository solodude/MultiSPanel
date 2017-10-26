using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiSPanel
{
    public partial class Form1 : Form
    {
        MultipleSlidingPAnel o1, o2, o3, o4;

        private void sliding1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //SETTINGS
        private void hide4_MouseHover(object sender, EventArgs e)
        {
            this.hide4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.options_h));
        }

        private void hide4_MouseLeave(object sender, EventArgs e)
        {
            this.hide4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.options));
        }

        //SAFE BUTTON
        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.signin_h));
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.signin));
        }

        //MISC
        private void hide3_MouseHover(object sender, EventArgs e)
        {
            this.hide3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.misc1_h));
        }

        private void hide3_MouseLeave(object sender, EventArgs e)
        {
            this.hide3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.misc1));
        }
        //Visuals
        private void hide2_MouseHover(object sender, EventArgs e)
        {
            this.hide2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.vis_h));
        }

        private void hide2_MouseLeave(object sender, EventArgs e)
        {
            this.hide2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.vis));
        }

        //AIM
        private void Hide_MouseHover(object sender, EventArgs e)
        {
            this.Hide.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.aim3_h));
        }

        private void Hide_MouseLeave(object sender, EventArgs e)
        {
            this.Hide.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.aim3));
        }



        public Form1()
        {
            InitializeComponent();

            o1 = new MultipleSlidingPAnel(ref sliding1, ref Hide, true, "▲", "▼");
            o2 = new MultipleSlidingPAnel(ref sliding2, ref hide2, true, "▲", "▼");
            o3 = new MultipleSlidingPAnel(ref sliding3, ref hide3, true, "▲", "▼");
            o4 = new MultipleSlidingPAnel(ref sliding4, ref hide4, true, "▲", "▼");
        }
    }
}
