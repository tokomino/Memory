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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void flatbutton1_Click(object sender, EventArgs e)
        {
            int w = data.GetcolumnCount();
            int h = data.GetrowCount();
            int result;
            result = w * h;
            int ColorP1 = data.getColorP1();
            int ColorP2 = data.getColorP2();
            int ColorP3 = data.getColorP3();
            int ColorP4 = data.getColorP4();

            if (data.getColorP3() == data.getColorP4() || data.getColorP3() == data.getColorP1() || data.getColorP3() == data.getColorP2() || data.getColorP4() == data.getColorP1() || data.getColorP4() == data.getColorP2()||data.getColorP1() == data.getColorP2())
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

        private void flatbutton2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            Close();
        }

        private void flatbutton4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
