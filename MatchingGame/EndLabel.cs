using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    class EndLabel : Label
    {
        public EndLabel()
        {
            Font = new Font("Tahoma", 14.5f);
            base.ForeColor = Color.White;
        }
    }
}
