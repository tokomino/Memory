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
    public partial class Option_Feld : UserControl
    {
        public Option_Feld()
        {
            InitializeComponent();
        }
        

        //only one Number is Allowed
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            textBox1.MaxLength = 1;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            flatbutton1.Enabled = true;
        }
        //put number rowCount
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var width = textBox1.Text;
                int w = Convert.ToInt32(width);
                data.SetcolumnCount(w);
            }
        }
        //put number to columnCount
        private void flatbutton1_Click(object sender, EventArgs e)
        {
            var width = textBox1.Text;
            int w = Convert.ToInt32(width);
            data.SetcolumnCount(w);
        }


        //only one Number is Allowed
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            textBox2.MaxLength = 1;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            flatbutton2.Enabled = true;
        }
        //put number rowCount
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var height = textBox2.Text;
                int h = Convert.ToInt32(height);
                data.SetrowCount(h);
            }
        }
        //put number rowCount
        private void flatbutton2_Click(object sender, EventArgs e)
        {
            var height = textBox2.Text;
            int h = Convert.ToInt32(height);
            data.SetrowCount(h);
        }
    }
}
