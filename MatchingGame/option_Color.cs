using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class option_Color : UserControl
    {
        public option_Color()
        {
            InitializeComponent();
        }

        //set Color for Player 1
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Color = listBox1.SelectedItem.ToString();
            int ColorP1;

            switch (Color)
            {
                case "Weiß":
                    ColorP1 = 0;
                    data.SetColorP1(ColorP1);
                    break;
                case "Violett":
                    ColorP1 = 1;
                    data.SetColorP1(ColorP1);
                    break;
                case "Grün":
                    ColorP1 = 2;
                    data.SetColorP1(ColorP1);
                    break;
                case "Grau":
                    ColorP1 = 3;
                    data.SetColorP1(ColorP1);
                    break;
                case "Rot":
                    ColorP1 = 4;
                    data.SetColorP1(ColorP1);
                    break;
                case "Gelb":
                    ColorP1 = 5;
                    data.SetColorP1(ColorP1);
                    break;
                case "Schwarz":
                    ColorP1 = 6;
                    data.SetColorP1(ColorP1);
                    break;
            }
        }

        //set Color for Player 2
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Color = listBox2.SelectedItem.ToString();
            int ColorP2;

            switch (Color)
            {
                case "Weiß":
                    ColorP2 = 0;
                    data.SetColorP1(ColorP2);
                    break;
                case "Violett":
                    ColorP2 = 1;
                    data.SetColorP1(ColorP2);
                    break;
                case "Grün":
                    ColorP2 = 2;
                    data.SetColorP1(ColorP2);
                    break;
                case "Grau":
                    ColorP2 = 3;
                    data.SetColorP1(ColorP2);
                    break;
                case "Rot":
                    ColorP2 = 4;
                    data.SetColorP1(ColorP2);
                    break;
                case "Gelb":
                    ColorP2 = 5;
                    data.SetColorP1(ColorP2);
                    break;
                case "Schwarz":
                    ColorP2 = 6;
                    data.SetColorP1(ColorP2);
                    break;
            }
        }

        //set Color for Player 3
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Color = listBox3.SelectedItem.ToString();
            int ColorP3;

            switch (Color)
            {
                case "Weiß":
                    ColorP3 = 0;
                    data.SetColorP1(ColorP3);
                    break;
                case "Violett":
                    ColorP3 = 1;
                    data.SetColorP1(ColorP3);
                    break;
                case "Grün":
                    ColorP3 = 2;
                    data.SetColorP1(ColorP3);
                    break;
                case "Grau":
                    ColorP3 = 3;
                    data.SetColorP1(ColorP3);
                    break;
                case "Rot":
                    ColorP3 = 4;
                    data.SetColorP1(ColorP3);
                    break;
                case "Gelb":
                    ColorP3 = 5;
                    data.SetColorP1(ColorP3);
                    break;
                case "Schwarz":
                    ColorP3 = 6;
                    data.SetColorP1(ColorP3);
                    break;
            }
        }

        //set Color for Player 4
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Color = listBox4.SelectedItem.ToString();
            int ColorP4;

            switch (Color)
            {
                case "Weiß":
                    ColorP4 = 0;
                    data.SetColorP1(ColorP4);
                    break;
                case "Violett":
                    ColorP4 = 1;
                    data.SetColorP1(ColorP4);
                    break;
                case "Grün":
                    ColorP4 = 2;
                    data.SetColorP1(ColorP4);
                    break;
                case "Grau":
                    ColorP4 = 3;
                    data.SetColorP1(ColorP4);
                    break;
                case "Rot":
                    ColorP4 = 4;
                    data.SetColorP1(ColorP4);
                    break;
                case "Gelb":
                    ColorP4 = 5;
                    data.SetColorP1(ColorP4);
                    break;
                case "Schwarz":
                    ColorP4 = 6;
                    data.SetColorP1(ColorP4);
                    break;
            }
        }
       
        //enable Colorchoice for Player 3/4 if that many Players play        
        private void tableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (data.getPlayernum() == 3)
            {
                listBox3.Enabled = true;
                listBox4.Enabled = false;
            }
            else if (data.getPlayernum() == 4)
            {
                listBox3.Enabled = true;
                listBox4.Enabled = true;
            }
            else
            {
                listBox3.Enabled = false;
                listBox4.Enabled = false;
            }
        }
    }
}
