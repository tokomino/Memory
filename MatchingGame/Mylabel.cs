using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    class Mylabel : Label
    {
        public Mylabel()
        {
            Font = new Font("Tahoma", 25f);
            base.ForeColor = Color.White;
        }
    }
}
