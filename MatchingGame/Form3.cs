using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            points();
            endscreen();
        }

        //Points from every player and who won?
        private void points()
        { 


            int win1 = data.Getwin1();
            int win2 = data.Getwin2();
            int win3 = data.Getwin3();
            int win4 = data.Getwin3();
            
            if(win1 > win2 && win1 > win3 && win1 > win4)
            {
                MessageBox.Show("Spieler 1 hat gewonnen");
            }
            else if (win2 > win1 && win2 > win3 && win2 > win4)
            {
                MessageBox.Show("Spieler 2 hat gewonnen");
            }
            else if (win3 > win1 && win3 > win2 && win3 > win4)
            {
                MessageBox.Show("Spieler 3 hat gewonnen");
            }
            else if (win4 > win1 && win4 > win2 && win4 > win1)
            {
                MessageBox.Show("Spieler 4 hat gewonnen");
            }
            else
            {
                MessageBox.Show("Mehrere Spieler haben gleich viele punkte und haben gemeinsam gewonnen");
            }


        }

        //generate EndTable
        private void endscreen()
        {
            int x;
            int y = 0;
            int playernum = 1;

            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.ColumnCount = data.getPlayernum();

            for (int num = 0; num < data.getPlayernum(); num++)
            {
                x = 0;
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, data.getPlayernum()));
                EndLabel Player = new EndLabel();
                switch (playernum)
                {
                    case 1:
                        data.SetColor(data.getColorP1());
                        break;
                    case 2:
                        data.SetColor(data.getColorP2());
                        break;
                    case 3:
                        data.SetColor(data.getColorP3());
                        break;
                    case 4:
                        data.SetColor(data.getColorP4());
                        break;
                }

                switch (data.getColor())
                {
                    case 1:  data.SetEndColor("Violett");
                        break;
                    case 2: data.SetEndColor("Grün");
                        break;
                    case 3: data.SetEndColor("Grau");
                        break;
                    case 4: data.SetEndColor("Rot") ;
                        break;
                    case 5: data.SetEndColor("Gelb");
                        break;
                    case 6: data.SetEndColor("Schwarz");
                        break;
                    default: data.SetEndColor("Weiß");
                        break;
                }
                Player.Text = data.getEndColor();
                Player.Dock = DockStyle.Fill;
                Player.TextAlign = ContentAlignment.MiddleCenter;
                tableLayoutPanel1.Controls.Add(Player, x, y);

                EndLabel Points = new EndLabel();
                x = 1;
                switch (playernum)
                {
                    case 1:
                        data.Setwin(data.Getwin1());
                        break;
                    case 2:
                        data.Setwin(data.Getwin2());
                        break;
                    case 3:
                        data.Setwin(data.Getwin3());
                        break;
                    case 4:
                        data.Setwin(data.Getwin4());
                        break;
                }
                if( playernum < data.getPlayernum())
                {
                    playernum = playernum + 1;
                }
                Points.Text = data.getwin().ToString();
                Points.Dock = DockStyle.Fill;
                Points.TextAlign = ContentAlignment.MiddleCenter;
                tableLayoutPanel1.Controls.Add(Points, x, y);
            }

        }

        //return to Menu
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Close();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
