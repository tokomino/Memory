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
    public partial class option_num : UserControl
    {
        public option_num()
        {
            InitializeComponent();
        }
        private void flatbutton1_Click(object sender, EventArgs e)
        {
            data.SetPlayernum(2);
            flatbutton1.BackColor = ColorTranslator.FromHtml("MediumBlue");
            flatbutton2.BackColor = ColorTranslator.FromHtml("RoyalBlue");
            flatbutton3.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        private void flatbutton2_Click(object sender, EventArgs e)
        {
            data.SetPlayernum(3);
            flatbutton1.BackColor = ColorTranslator.FromHtml("RoyalBlue");
            flatbutton2.BackColor = ColorTranslator.FromHtml("MediumBlue");
            flatbutton3.BackColor = ColorTranslator.FromHtml("RoyalBlue");
        }

        private void flatbutton3_Click(object sender, EventArgs e)
        {
            data.SetPlayernum(4);
            flatbutton1.BackColor = ColorTranslator.FromHtml("RoyalBlue");
            flatbutton2.BackColor = ColorTranslator.FromHtml("RoyalBlue");
            flatbutton3.BackColor = ColorTranslator.FromHtml("MediumBlue");
        }
    }
}
