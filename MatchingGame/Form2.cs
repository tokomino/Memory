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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        //set Feld in Front
        private void flatbutton1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = flatbutton1.Height;
            SidePanel.Top = flatbutton1.Top;
            option_Feld1.BringToFront();
        }

        //Set Playernumber in Front
        private void flatbutton2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = flatbutton2.Height;
            SidePanel.Top = flatbutton2.Top;
            option_num1.BringToFront();
        }
        //Set Colorchoice in Front
        private void flatbutton3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = flatbutton3.Height;
            SidePanel.Top = flatbutton3.Top;
            option_Color1.BringToFront();

        }

        //Back to Menu
        private void flatbutton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Close();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
        //Control if the settings are correct
        private void mylabel2_Click(object sender, EventArgs e)
        {


            int w = data.GetcolumnCount();
            int h = data.GetrowCount();
            int result;
            result = w * h;
            int ColorP1 = data.getColorP1();
            int ColorP2 = data.getColorP2();
            int ColorP3 = data.getColorP3();
            int ColorP4 = data.getColorP4();

            if (data.getColorP3() == data.getColorP4() || data.getColorP3() == data.getColorP1() || data.getColorP3() == data.getColorP2() || data.getColorP4() == data.getColorP1() || data.getColorP4() == data.getColorP2() || data.getColorP1() == data.getColorP2())
            {
                MessageBox.Show("Eine Farbe wurde mehrfach gewählt");
            }
            else if (result % 2 == 0)
            {
                Form1 f1 = new Form1();
                this.Hide();
                f1.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Das Spielfeld wäre ungerade, Zahlen ändern.");
            }

        }
    }
}
