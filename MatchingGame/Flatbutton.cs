using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace MatchingGame
{
    class Flatbutton : Control
    {
        // variables
        private SolidBrush borderBrush, textBrush;
        private Rectangle borderRectangle;
        private bool active = false;
        private StringFormat stringFormat = new StringFormat();
        
        //properties
        public override Cursor Cursor { get; set; } = Cursors.Hand;
        public float BorderThickness { get; set; } = 1;

        public System.Windows.Forms.FlatButtonAppearance FlatButtonAppearance { get; set; }
        public System.Windows.Forms.FlatStyle FlatStyle { get; set; }

        //public override string Text { get => base.Text; set => base.Text = "7"; }  





        //constructor
        public Flatbutton()
        {
            borderBrush = new SolidBrush(ColorTranslator.FromHtml("White"));
            textBrush = new SolidBrush(ColorTranslator.FromHtml("White"));
            base.BackColor = ColorTranslator.FromHtml("RoyalBlue");
            Font = new Font("Segoe UI", 9f);




            // nachher weiter suchen
            //var c = from controls in this.Controls.OfType<Button>()
            //        select controls;
            //foreach (var control in c)
            //    //control.FlatStyle = FlatStyle.Flat;


            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;


            this.Paint += Flatbutton_Paint;
        }
        //event
        private void Flatbutton_Paint(object sender, PaintEventArgs e)
        {
            borderRectangle = new Rectangle(0, 0, Width, Height);
            e.Graphics.DrawRectangle(new Pen(borderBrush, BorderThickness), borderRectangle);
            e.Graphics.DrawString(this.Text, this.Font, (active) ? textBrush : borderBrush, borderRectangle, stringFormat);

        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (BackColor == ColorTranslator.FromHtml("Royalblue"))
            {
                base.BackColor = ColorTranslator.FromHtml("SkyBlue");
            }
            active = true;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if( BackColor == ColorTranslator.FromHtml("Skyblue"))
            {
                base.BackColor = ColorTranslator.FromHtml("RoyalBlue");
            }
            active = false;
        }
    }
}
