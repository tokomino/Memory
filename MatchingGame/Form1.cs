using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MatchingGame
{

    public partial class Form1 : Form
    {
        int player = 1;

        int win1;
        int win2;
        int win3;
        int win4;

        Random random = new Random();
        // firstClicked points to the first Label control 
        // that the player clicks, but it will be null 
        // if the player hasn't clicked a label yet
        Label firstClicked = null;
        // secondClicked points to the second Label control 
        // that the player clicks
        Label secondClicked = null;

        public Form1()
        {
            InitializeComponent();
            GenerateTable();
            Generateicons();
            AssignIconsToSquares();
        }
        
        //labels get safed here
        List<Label> Bilder = new List<Label>()
        {

        };
        //icon get safed here
        List<string> icons = new List<string>()
        {

        };

        private void GenerateTable()
        {
            int columnCount;
            int rowCount;
            int breite;
            int höhe;

            columnCount = data.GetcolumnCount();
            rowCount = data.GetrowCount();

            breite = 100 / columnCount;
            höhe = 100 / rowCount;

            //Clear out the existing controls, we are generating a new table layout
            tableLayoutPanel1.Controls.Clear();

            //Clear out the existing row and column styles
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();


            //Now we will generate the table, setting up the row and column counts first
            tableLayoutPanel1.ColumnCount = columnCount;
            tableLayoutPanel1.RowCount = rowCount;

            for (int x = 0; x < columnCount; x++)
            {
                //First add a column
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, breite));

                for (int y = 0; y < rowCount; y++)
                {
                    //Next, add a row.  Only do this when once, when creating the first column
                    if (x == 0)
                    {
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, höhe));
                    }

                    //creat Label
                    Label Bild = new Label();

                    Bild.Font = new Font("Webdings", 48);
                    Bild.Dock = DockStyle.Fill;
                    Bild.Text = "!";
                    Bild.TextAlign = ContentAlignment.MiddleCenter;
                    Bild.Click += new EventHandler(label_Click);

                    Bilder.Add(new Label());

                    tableLayoutPanel1.Controls.Add(Bild, x, y);
                }
            }
            tableLayoutPanel1.Dock = DockStyle.Fill;
        }
        private void Generateicons()
        {

            int countOfLabel = Bilder.OfType<Label>().Count() / 2;

            for (int Paarzahl = 0; Paarzahl < countOfLabel; ++Paarzahl)
            {

                int Randomzahl;
                //create Randomnumber and safe it 2 times in the list
                Randomzahl = random.Next(40, 125);                 
                string Zeichen_1 = Convert.ToChar(Randomzahl).ToString();
                icons.Add(Zeichen_1);
                icons.Add(Zeichen_1);
            }
        }
        private void AssignIconsToSquares()
        {
            foreach (Control Feld in tableLayoutPanel1.Controls)
            {
                Label Bild = Feld as Label;

                if (Bild.Text == "!")
                {
                    //every Label get a random number (Icon because of WEDINGS)
                    int randomNumber = random.Next(icons.Count);
                    Bild.Text = icons[randomNumber];
                    Bild.ForeColor = Bild.BackColor;
                    //Randomnumber gets deleted from the list
                    icons.RemoveAt(randomNumber);
                }
            }
        }
        /// <summary>
        /// Every label's Click event is handled by this event handler
        /// </summary>
        /// <param name="sender">The label that was clicked</param>
        /// <param name="e"></param>
        private void label_Click(object sender, EventArgs e)
        {

            // The timer is only on after two non-matching 
            // icons have been shown to the player, 
            // so ignore any clicks if the timer is running
            if (timer1.Enabled == true)
                return;


            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor != Color.Blue)
                {
                    return;
                }


                // If firstClicked is null, this is the first icon 
                // in the pair that the player clicked,
                // so set firstClicked to the label that the player 
                // clicked, change its color, and return
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    this.color_1();
                    return;
                }
                // If the player gets this far, the timer isn't
                // running and firstClicked isn't null,
                // so this must be the second icon the player clicked
                secondClicked = clickedLabel;
                color_2();

                if (firstClicked == secondClicked)
                {
                    return;
                }

                // same icon
                if (firstClicked.Text == secondClicked.Text)
                {
                    color_3();

                    firstClicked = null;
                    secondClicked = null;


                    // Check to see if one player won
                    CheckForWinner();
                    return;
                }



                // If the player gets this far, the player 
                // clicked two different icons, so start the 
                // timer (which will wait three quarters of 
                // a second, and then hide the icons)
                timer1.Start();


                if(player != data.getPlayernum())
                {
                    player = player + 1;
                }
                else 
                {
                    player = 1;
                }
            }
        }
        // which players turn is it and what color does he have? (turn 1)
        private void color_1()
        {
            switch (player)
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
                case 1: firstClicked.ForeColor = Color.Violet; ; break;
                case 2: firstClicked.ForeColor = Color.Green; ; break;
                case 3: firstClicked.ForeColor = Color.Gray; ; break;
                case 4: firstClicked.ForeColor = Color.Red; ; break;
                case 5: firstClicked.ForeColor = Color.Yellow; ; break;
                case 6: firstClicked.ForeColor = Color.Black; ; break;
                default: firstClicked.ForeColor = Color.White; ; break;
            }
        }
        // which players turn is it and what color does he have? (turn 2)
        private void color_2()
        {
            switch (player)
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
                case 1: secondClicked.ForeColor = Color.Violet; ; break;
                case 2: secondClicked.ForeColor = Color.Green; ; break;
                case 3: secondClicked.ForeColor = Color.Gray; ; break;
                case 4: secondClicked.ForeColor = Color.Red; ; break;
                case 5: secondClicked.ForeColor = Color.Yellow; ; break;
                case 6: secondClicked.ForeColor = Color.Black; ; break;
                default: secondClicked.ForeColor = Color.White; ; break;
            }
        }
        // which player found 2 matching icons and get a point? (after turn 2)
        private void color_3()
        {
            switch (player)
            {
                case 1:
                    data.SetColor(data.getColorP1());
                    win1 = win1 + 1;
                    break;
                case 2:
                    data.SetColor(data.getColorP2());
                    win2 = win2 + 1;
                    break;
                case 3:
                    data.SetColor(data.getColorP3());
                    win3 = win3 + 1;
                    break;
                case 4:
                    data.SetColor(data.getColorP4());
                    win4 = win4 + 1;
                    break;
            }

            switch (data.getColor())
            {
                case 1:
                    firstClicked.ForeColor = Color.Violet;
                    secondClicked.ForeColor = Color.Violet; ; break;
                case 2:
                    firstClicked.ForeColor = Color.Green;
                    secondClicked.ForeColor = Color.Green; ; break;
                case 3:
                    firstClicked.ForeColor = Color.Gray;
                    secondClicked.ForeColor = Color.Gray; ; break;
                case 4:
                    firstClicked.ForeColor = Color.Red;
                    secondClicked.ForeColor = Color.Red; ; break;
                case 5:
                    firstClicked.ForeColor = Color.Yellow;
                    secondClicked.ForeColor = Color.Yellow; ; break;
                case 6:
                    firstClicked.ForeColor = Color.Black;
                    secondClicked.ForeColor = Color.Black; ; break;
                default:
                    firstClicked.ForeColor = Color.White;
                    secondClicked.ForeColor = Color.White; ; break;
            }
        }

        /// <summary>
        /// This timer is started when the player clicks 
        /// two icons that don't match,
        /// so it counts three quarters of a second 
        /// and then turns itself off and hides both icons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            timer1.Stop();

            // Hide both icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            // Reset firstClicked and secondClicked 
            // so the next time a label is
            // clicked, the program knows it's the first click
            firstClicked = null;
            secondClicked = null;
        }

        /// <summary>
        /// Check every icon to see if it is matched, by 
        /// comparing its foreground color to its background color. 
        /// If all of the icons are matched, the player wins
        /// </summary>
        private void CheckForWinner()
        {
            // Go through all of the labels in the TableLayoutPanel, 
            // checking each one to see if its icon is matched
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            // If the loop didn’t return, it didn't find
            // any unmatched icons
            // That means the user won. Show a message and close the form
            this.Hide();
            data.Setwin1(win1);
            data.Setwin2(win2);
            data.Setwin3(win3);
            data.Setwin4(win4);
            Form3 f3 = new Form3();
            f3.ShowDialog();
            Close();
        }
    }
}


