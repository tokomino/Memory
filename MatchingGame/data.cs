using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    class data
    {
        private static int columnCount = 4;
        private static int rowCount = 4;

        public static int GetcolumnCount()
        {
            return columnCount;
        }
        public static void SetcolumnCount(int value)
        {
            columnCount = value;
        }

        public static int GetrowCount()
        {
            return rowCount;
        }
        public static void SetrowCount(int value)
        {
            rowCount = value;
        }



        private static int color;
        private static int colorP1 = 0;
        private static int colorP2 = 6;
        private static int colorP3 = 1;
        private static int colorP4 = 2;
        private static string Endcolor;


        public static void SetEndColor(string value)
        {
            Endcolor = value;
        }
        public static string getEndColor()
        {
            return Endcolor;
        }
        public static void SetColor(int value)
        {
            color = value;
        }
        public static int getColor()
        {
            return color;
        }

        public static void SetColorP1(int value)
        {
            colorP1 = value;
        }
        public static int getColorP1()
        {
            return colorP1;
        }

        public static void SetColorP2(int value)
        {
            colorP2 = value;
        }
        public static int getColorP2()
        {
            return colorP2;
        }

        public static void SetColorP3(int value)
        {
            colorP3 = value;
        }
        public static int getColorP3()
        {
            return colorP3;
        }

        public static void SetColorP4(int value)
        {
            colorP4 = value;
        }
        public static int getColorP4()
        {
            return colorP4;
        }



        private static int Playernum = 2;
        private static int win;
        private static int win1;
        private static int win2;
        private static int win3;
        private static int win4;

        public static void SetPlayernum(int value)
        {
            Playernum = value;
        }
        public static int getPlayernum()
        {
            return Playernum;
        }

        public static void Setwin(int value)
        {
            win = value;
        }
        public static int getwin ()
        {
            return win;
        }

        public static void Setwin1(int value)
        {
            win1 = value;
        }
        public static int Getwin1()
        {
            return win1;
        }

        public static void Setwin2(int value)
        {
            win2 = value;
        }
        public static int Getwin2()
        {
            return win2;
        }

        public static void Setwin3(int value)
        {
            win3 = value;
        }
        public static int Getwin3()
        {
            return win3;
        }

        public static void Setwin4(int value)
        {
            win4 = value;
        }
        public static int Getwin4()
        {
            return win4;
        }

    }
}
