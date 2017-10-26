using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiSPanel
{
    class MultipleSlidingPAnel
    {
        Panel span;
        Button button;
        bool horizontal;
        bool hidden;
        string hText;
        string sText;
        int size;
        Timer t;

        public MultipleSlidingPAnel(ref Panel p,ref Button b,bool hor,string hText,string stext)
        {
            this.span = p;
            this.button = b;
            this.horizontal = hor;
            hidden = false;
            this.hText = hText;
            this.sText = stext;

            if (horizontal) size = p.Height;
            else size = p.Width;


            b.Click += new EventHandler(button_clicked);

            t = new Timer();
            t.Interval = 100;
            t.Tick += new EventHandler(t_tick); 
        }
        void ChangeSize(int val)
        {
            
                span.Height += val;

                if(span.Height >= size || span.Height <= 0)
                {
                    t.Stop();
                    hidden = !hidden;
                }
            
            
        }
        private void t_tick(object sender, EventArgs e)
        {
            if (hidden) ChangeSize(+30);
            else ChangeSize(-30);
        }

        private void button_clicked(object sender, EventArgs e)
        {
            if (!hidden) button.Text = sText;
            else button.Text = hText;

            t.Start();
        }
    }
}
